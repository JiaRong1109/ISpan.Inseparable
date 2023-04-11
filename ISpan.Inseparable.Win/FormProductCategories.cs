using ISpan.Inseparable.BLL.Interface;
using ISpan.Inseparable.BLL;
using ISpan.Inseparable.SqlDataLayer;
using ISpan.Inseparable.Win.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ISpan.Inseparable.Win
{
	public partial class FormProductCategories : Form
	{
		InseparableEntities InseparableDb = new InseparableEntities();
		ProductCategoryRepository repo;
		ProductCategories productCategories= new ProductCategories();


		public FormProductCategories()
		{
			InitializeComponent();
			repo = new ProductCategoryRepository();

			this.Load += FormProductCategories_Load;
		}
		public void Display()
		{
			var search = repo.Search(textBoxName.Text).Select(pc => new
			{
				類別ID = pc.ProductCategoryID,
				類別名稱 = pc.ProductCategoryName,
			});

			dataGridViewProductCategory.DataSource = search.ToList();
		}

		private void FormProductCategories_Load(object sender, EventArgs e)
		{
			Display();
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			Display();
		}

		private (bool isValid, List<ValidationResult> errors) Validate(ProductCategoryCreateVm vm)
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
				{"ProductCategoryName",textBoxName},

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
		public ProductCategoryCreateVm GetCreateModel()
			=> new ProductCategoryCreateVm
			{
				ProductCategoryName =textBoxName.Text
			};
		private void buttonAdd_Click(object sender, EventArgs e)
		{
			var vm = GetCreateModel();

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

			IProductCategoryRepository repo = new ProductCategoryRepository();
			ProductCategoryService service = new ProductCategoryService(repo);

			try
			{
				service.Create(dto);
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗!!" + ex.Message);
			}
			textBoxName.Clear();
			Display();
		}
		private (bool isValid, List<ValidationResult> errors) Validate(ProductCategoryUpdateVm vm)
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
		public ProductCategoryUpdateVm GetUpdateModel()
			=> new ProductCategoryUpdateVm
			{
				ProductCategoryID =(int)this.dataGridViewProductCategory.CurrentRow.Cells[0].Value,
				ProductCategoryName=textBoxName.Text
			};

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			var vm = GetUpdateModel();

			// 針對view model 進行欄位驗證, 如果有錯誤就顯示錯誤訊息
			(bool isValid, List<ValidationResult> errors) validationResult = Validate(vm);

			if (validationResult.isValid == false)
			{
				this.errorProvider1.Clear();
				DisplayErrors(validationResult.errors);
				return;
			}

			var dto = vm.ToUpdateDto();

			IProductCategoryRepository repo = new ProductCategoryRepository();
			ProductCategoryService service = new ProductCategoryService(repo);

			try { service.Update(dto); } catch (Exception ex) { MessageBox.Show("更新失敗!!" + ex.Message); }
			textBoxName.Clear();
			Display();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (dataGridViewProductCategory.RowCount <= 0)
			{
				MessageBox.Show("你沒有選擇刪除項目!!");
				return;
			}
			int CategoryID = (int)dataGridViewProductCategory.CurrentRow.Cells[0].Value;

			try
			{
				repo.Delete(CategoryID);
			}
			catch(Exception ex) { MessageBox.Show("刪除失敗!!"+ex.Message); }
			Display();
		}
	}
}
