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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.Inseparable.Win
{
	public partial class FormAddProductOrderDetails : Form
	{
		InseparableEntities InseparableDb =new InseparableEntities();
		ProductOrderDetails product =new ProductOrderDetails();
		OrderRepository repo;

		private readonly int orderId;
		private int Num=0;
		private int money;
		private int unitprice = 0;
		private int subtotal=0;
		private int cinemaId = 0;
		private int? productId => comboBoxProduct.SelectedIndex > 0 ? InseparableDb.Products.First(p => p.ProductName == comboBoxProduct.Text).ProductId : (int?)null;
		private int? qty => int.TryParse(textBoxQty.Text, out int Qty) ? Qty : (int?)null;
		private decimal? discount => decimal.TryParse(textBoxDiscount.Text, out decimal discount) ? discount : 1;

		
		public FormAddProductOrderDetails(int orderId,int money)
		{
			InitializeComponent();
			repo = new OrderRepository();

			this.orderId = orderId;
			this.money = money;
			this.Load += FormAddProductOrderDetails_Load;
		}

		private void FormAddProductOrderDetails_Load(object sender, EventArgs e)
		{
			var get = repo.GetOrders(orderId);
			BindForm(get);

			labelModifiedTime.Text =DateTime.Now.ToString();
			var prodcut = InseparableDb.Products.Where(p => p.CinemaID == cinemaId);
			foreach(var item in prodcut)
			{
				comboBoxProduct.Items.Add(item.ProductName);
			}
			comboBoxProduct.SelectedIndex = 0;
		}
		public ProductOrderCreateVm GetModel()
			=> new ProductOrderCreateVm()
			{
				ProductItem_no = Num,
				OrderID = orderId,
				ProductID = (int)productId,
				ProductName = comboBoxProduct.Text,
				ProductQty = (int)qty,
				ProductDiscount = (decimal)discount,
				ProductSubtotal = (int)subtotal,
				ProductUnitprice = (int)unitprice,
			};

		private void BindForm(Orders get)
		{
			labelOrderID.Text = get.OrderID.ToString();
			labelMember.Text = get.Members.LastName + " " + get.Members.FirstName;
			labelCinema.Text = get.Cinemas.CinemaName;
			cinemaId = get.CinemaID;
		}

		private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
		{
			var prodcut = InseparableDb.Products.Where(p => p.CinemaID == cinemaId).Where(p => p.ProductName == comboBoxProduct.Text);
			foreach(var item in prodcut) { labelPrice.Text = item.ProductUnitprice.ToString(); }
		}

		private (bool isValid, List<ValidationResult> errors) Validate(ProductOrderCreateVm vm)
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
				{"ProductID", comboBoxProduct},
				{"ProductName", comboBoxProduct},
				{"ProductQty", textBoxQty},

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
			unitprice = int.Parse(labelPrice.Text);
			subtotal = (int)(qty * discount*unitprice);
			
			//取最大值加1
			List<int> itemno = new List<int>();
			var n = InseparableDb.ProductOrderDetails.Where(t => t.OrderID == orderId).Select(t => t.ProductItem_no);
			foreach (var num in n)
			{
				itemno.Add(num);
			}
			Num = itemno.Count() > 0 ? itemno.Max() + 1 : 1;


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
			IProductOrderRepository repo = new ProductOrderDetailRepository();
			ProductOrderService service = new ProductOrderService(repo);

			var order = InseparableDb.Orders.Where(o => o.OrderID == orderId);
			foreach( var item in order) 
			{
				item.TotalMoney = money + subtotal;
				item.ModifiedTime = DateTime.Parse(labelModifiedTime.Text);
			}

			try
			{
				service.Create(dto);
				InseparableDb.SaveChanges();
			}catch(Exception ex) { MessageBox.Show("新增失敗!!"+ex.Message);}

			
			IGridContainer container =this.Owner as IGridContainer;
			if (container != null) container.Display();
			this.DialogResult = DialogResult.OK;
			
		}

		
	}
}
