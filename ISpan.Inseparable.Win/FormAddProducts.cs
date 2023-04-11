using ISpan.Inseparable.BLL;
using ISpan.Inseparable.BLL.Interface;
using ISpan.Inseparable.SqlDataLayer;
using ISpan.Inseparable.Win.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.Inseparable.Win
{
	public partial class FormAddProducts : Form
	{
		InseparableEntities InseparableDb = new InseparableEntities();
		Products products = new Products();

		private int? categoryID => comboBoxCategory.SelectedIndex > 0 ? InseparableDb.ProductCategories.First(c => c.ProductCategoryName == comboBoxCategory.Text).ProductCategoryID : (int?)null;
		private int? cinemaID => comboBoxCinema.SelectedIndex > 0 ? InseparableDb.Cinemas.First(ci => ci.CinemaName == comboBoxCinema.Text).CinemaID : (int?)null;
		private int?　price =>int.TryParse(textBoxPrice.Text,out int price)? price:(int?)null;
		private int? stock=>int.TryParse(textBoxQty.Text,out int stock)? stock:(int?)null;

		private byte[] image => string.IsNullOrEmpty(str) ? null : ImageTranse();
		public FormAddProducts()
		{
			InitializeComponent();
			this.Load += FormAddProducts_Load;
		}

		private void FormAddProducts_Load(object sender, EventArgs e)
		{
			foreach (var item in InseparableDb.ProductCategories)
			{
				comboBoxCategory.Items.Add(item.ProductCategoryName);
			}
			comboBoxCategory.SelectedIndex = 0;

			foreach (var item in InseparableDb.Cinemas)
			{
				comboBoxCinema.Items.Add(item.CinemaName);
			}
			comboBoxCinema.SelectedIndex = 0;
		}
		public ProductCreateVm GetModel()
			=> new ProductCreateVm
			{
				ProductName = textBoxName.Text,
				ProductCategoryId = this.categoryID,
				ProductUnitprice = this.price,
				CinemaID = this.cinemaID,
				ProductStock = this.stock,
				ProductPicture = image,
			};
		private (bool isValid, List<ValidationResult> errors) Validate(ProductCreateVm vm)
		{
			// 得知要驗證規則
			ValidationContext context = new ValidationContext(vm, null, null);

			// 用來存放錯誤的集合,因為可能有零到多個錯誤
			List<ValidationResult> errors = new List<ValidationResult>();

			// 驗證 model
			bool validateAllProperties = true; // 是否驗證所有規則,而非只驗證Required規則
			bool isValid = Validator.TryValidateObject(vm, context, errors, validateAllProperties);

			return (isValid, errors);
		}
		private void DisplayErrors(List<ValidationResult> errors)
		{
			// 大小寫不同仍視為相同的key
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"ProductName", textBoxName},
				{"ProductCategoryId", comboBoxCategory},
				{"ProductUnitprice", textBoxPrice},
				{"ProductStock", textBoxQty},
				{"CinemaID", comboBoxCinema},
				{"ProductPicture",pictureBoxProduct},

			};

			this.errorProvider1.Clear();

			foreach (ValidationResult error in errors)
			{
				string propName = error.MemberNames.FirstOrDefault();
				if (propName != null && map.TryGetValue(propName, out Control ctrl))
				{
					this.errorProvider1.SetError(ctrl, error.ErrorMessage);
				}
			}
		}
		private void buttonAdd_Click(object sender, EventArgs e)
		{
			var vm = GetModel();

			// 針對view model 進行欄位驗證, 如果有錯誤就顯示錯誤訊息
			(bool isValid, List<ValidationResult> errors) validationResult = Validate(vm);

			if (validationResult.isValid == false)
			{
				this.errorProvider1.Clear();
				DisplayErrors(validationResult.errors);
				return;
			}

			// 如果通過驗證,轉型為CreateDto
			var dto = vm.ToCreateDto();

			//傳給Service

			IProductRepository repo = new ProductRepository();
			ProductService service = new ProductService(repo);

			try
			{
				service.Create(dto);
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗!!" + ex.Message);
			}


			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();
			this.DialogResult = DialogResult.OK;
		}
		string str = string.Empty;
		private void buttonSelectImage_Click(object sender, EventArgs e)
		{
			
			if (openFileDialogImage.ShowDialog() == DialogResult.OK)
			{
				str = openFileDialogImage.FileName;
				pictureBoxProduct.Image=Image.FromFile(str);
			}
		}

		private byte[] ImageTranse()
		{
			FileStream fs = new FileStream(str, FileMode.Open, FileAccess.Read);
			BinaryReader br = new BinaryReader(fs);
			byte[] imgBytesIn = br.ReadBytes(Convert.ToInt32(fs.Length));//转成二进制数据的操作
			return imgBytesIn;
		}
	}
}
