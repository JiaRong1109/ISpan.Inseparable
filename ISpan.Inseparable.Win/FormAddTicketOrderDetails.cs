using ISpan.Inseparable.BLL;
using ISpan.Inseparable.BLL.Interface;
using ISpan.Inseparable.SqlDataLayer;
using ISpan.Inseparable.Win.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.Inseparable.Win
{
	public partial class FormAddTicketOrderDetails : Form
	{

		InseparableEntities InseparableDb = new InseparableEntities();
		OrderRepository repo;
		TicketOrderDetails T= new TicketOrderDetails();

		private readonly int orderId;
		private int money;
		private int unitprice = 0;
		private int subtotal = 0;
		private int cinemaId = 0;
		private int Num = 0;

		private int? movieId => comboBoxMovie.SelectedIndex > 0 ? InseparableDb.Movies.First(m => m.MovieName == comboBoxMovie.Text).MovieID : (int?)null;
		private DateTime? date => DateTime.TryParse(comboBoxDate.Text,out DateTime date) ? date:(DateTime?)null;
		private TimeSpan? time => TimeSpan.TryParse(comboBoxTime.Text,out TimeSpan time)? time:(TimeSpan?)null;
		private int? sessionId => comboBoxDate.SelectedIndex>0? InseparableDb.Sessions.Where(s=>s.SessionDate==date).First(s=>s.SessionTime==time).SessionId : (int?)null;
		private int? roomId =>comboBoxTime.SelectedIndex>0? InseparableDb.Sessions.First(s=>s.SessionId==sessionId).RoomId: (int?)null;
		private int? seatId => comboBoxSeat.SelectedIndex > 0 ? InseparableDb.Seats.Where(st=>st.RoomID==roomId).First(st => st.SeatRow + " " + st.SeatColumn == comboBoxSeat.Text).SeatID : (int?)null;
		private decimal discount => decimal.TryParse(textBoxDiscount.Text, out decimal discount) ? discount : 1;
		
		public FormAddTicketOrderDetails(int orderId, int money)
		{
			InitializeComponent();
			repo = new OrderRepository();

			this.orderId = orderId;
			this.money = money;

			this.Load += FormAddTicketOrderDetails_Load;
		}

		private void FormAddTicketOrderDetails_Load(object sender, EventArgs e)
		{
			var get = repo.GetOrders(orderId);
			BindForm(get);

			labelModifiedTime.Text = DateTime.Now.ToString();
			var movie = InseparableDb.Movies;
			foreach (var item in movie)
			{
				comboBoxMovie.Items.Add(item.MovieName);
			}
			comboBoxMovie.SelectedIndex = 0;
		}
		private void BindForm(Orders get)
		{
			labelOrderID.Text = get.OrderID.ToString();
			labelMember.Text = get.Members.LastName + " " + get.Members.FirstName;
			labelCinema.Text = get.Cinemas.CinemaName;
			cinemaId = get.CinemaID;
		}
		private void comboBoxMovie_SelectedIndexChanged(object sender, EventArgs e)
		{
			comboBoxDate.Items.Clear();
			comboBoxDate.Items.Add("--請選擇--");
			var session = InseparableDb.Sessions.Where(s=>s.CinemaID==cinemaId).Where(s => s.Movies.MovieName == comboBoxMovie.Text);
			foreach (var item in session)
			{
				comboBoxDate.Items.Add(item.SessionDate);
			}
			comboBoxDate.SelectedIndex = 0;
		}
		private void comboBoxDate_SelectedIndexChanged(object sender, EventArgs e)
		{
			comboBoxTime.Items.Clear();
			comboBoxTime.Items.Add("--請選擇--");
			var session = InseparableDb.Sessions.Where(s => s.CinemaID == cinemaId).Where(s => s.Movies.MovieName == comboBoxMovie.Text).Where(s => s.SessionDate== date);
			foreach (var item in session)
			{
				comboBoxTime.Items.Add(item.SessionTime);
			}
			comboBoxTime.SelectedIndex = 0;
		}

		private void comboBoxTime_SelectedIndexChanged(object sender, EventArgs e)
		{
			comboBoxSeat.Items.Clear();
			comboBoxSeat.Items.Add("--請選擇--");
			var session = InseparableDb.Sessions.Where(s => s.CinemaID == cinemaId).Where(s => s.Movies.MovieName == comboBoxMovie.Text).Where(s => s.SessionDate == date).Where(s=>s.SessionTime==time);
			foreach (var item in session) 
			{ 
				labelPrice.Text = item.TicketPrice.ToString(); 
			}

			var seat = InseparableDb.Seats.Where(st => st.RoomID == roomId);
			foreach (var item in seat)
			{
				comboBoxSeat.Items.Add(item.SeatRow + " " + item.SeatColumn);
			}
			comboBoxSeat.SelectedIndex = 0;
		}
		public TicketOrderCreateVm GetModel()
			=> new TicketOrderCreateVm()
			{
				
				TicketItem_no = Num, //todo
				OrderID = int.Parse(labelOrderID.Text),
				MovieID = (int)movieId,
				SessionID = (int)sessionId,
				SeatID = (int)seatId,
				RoomID = (int)roomId,
				TicketUnitprice = unitprice,
				TicketDiscount = (decimal)discount,
				TicketSubtotal = subtotal,
			};
		private (bool isValid, List<ValidationResult> errors) Validate(TicketOrderCreateVm vm)
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
				{"MovieID", comboBoxMovie},
				{"SessionID", comboBoxDate},
				{"SessionID", comboBoxTime},
				{"SeatID",comboBoxSeat },

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
			subtotal = (int)(discount * unitprice);

			List<int> itemno = new List<int>();
			var n = InseparableDb.TicketOrderDetails.Where(t => t.OrderID == orderId).Select(t=>t.TicketItem_no);
			foreach(var num in n)
			{
				itemno.Add(num);
			}
			Num = itemno.Count()>0? itemno.Max()+1:1;
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
			ITicketOrderRepository repo = new TicketOrderDetailRepository();
			TicketOrderService service = new TicketOrderService(repo);


			var order = InseparableDb.Orders.Where(o => o.OrderID == orderId);
			foreach (var item in order)
			{
				item.TotalMoney = money + subtotal;
				item.ModifiedTime = DateTime.Parse(labelModifiedTime.Text);
			}

			try
			{
				service.Create(dto);
				InseparableDb.SaveChanges();
			}
			catch (Exception ex) { MessageBox.Show("新增失敗!!" + ex.Message); }

			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();
			this.DialogResult = DialogResult.OK;
		}
	}
}
