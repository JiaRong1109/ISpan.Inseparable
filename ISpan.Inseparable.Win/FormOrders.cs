using ISpan.Inseparable.BLL.Interface;
using ISpan.Inseparable.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.Inseparable.Win
{
	public partial class FormOrders : Form,IGridContainer
	{
		InseparableEntities InseparableDb = new InseparableEntities();
		ProductOrderDetailRepository productRepo;
		TicketOrderDetailRepository ticketRepo;
		OrderRepository orderRepo;

		private int? memberID => comboBoxMemberID.SelectedIndex > 0 ? int.Parse(comboBoxMemberID.Text) : (int?)null;
		private int? orderID=>comboBoxOrderID.SelectedIndex>0? int.Parse(comboBoxOrderID.Text):(int?)null;
		
		public FormOrders()
		{
			InitializeComponent();

			productRepo = new ProductOrderDetailRepository();
			orderRepo = new OrderRepository();
			ticketRepo = new TicketOrderDetailRepository();

			this.Load += FormOrders_Load;
		}
		public void Display()
		{
			var Ordersearch = orderRepo.Search(memberID, orderID).Select(o => new
			{
				訂單ID=o.OrderID,
				會員=o.Members.LastName+" "+o.Members.FirstName,
				影城=o.Cinemas.CinemaName,
				訂單日期=o.OrderDate,
				修改日期=o.ModifiedTime,
				總金額=o.TotalMoney,
			});

			var productOrderDetial = productRepo.Search(orderID,memberID).Select(po => new
			{
				項次 = po.ProductItem_no,
				訂單ID = po.OrderID,
				產品ID = po.ProductID,
				產品名稱 = po.ProductName,
				單價 = po.ProductUnitprice,
				數量=po.ProductQty,
				折扣 = po.ProductDiscount,
				小記 = po.ProductSubtotal,
			});
			var ticketOrderDetial = ticketRepo.Search(orderID, memberID).Select(t => new
			{
				項次 = t.TicketItem_no,
				訂單ID = t.OrderID,
				電影 = t.Movies.MovieName,
				場次 = t.Sessions.SessionDate + " " + t.Sessions.SessionTime,
				座位 = t.Seats.SeatRow + " " + t.Seats.SeatColumn,
				影廳 = t.Rooms.RoomName,
				影城 = t.Rooms.Cinemas.CinemaName,
				票價 = t.TicketUnitprice,
				折扣 = t.TicketDiscount,
				小記 = t.TicketSubtotal
			});

			dataGridViewTicketDetail.DataSource = ticketOrderDetial.ToList();
			dataGridViewOrder.DataSource = Ordersearch.ToList();
			dataGridViewProductDetail.DataSource = productOrderDetial.ToList();
		}
		
		private void FormOrders_Load(object sender, EventArgs e)
		{
			Display();
			foreach (var item in InseparableDb.Members)
			{
				comboBoxMemberID.Items.Add(item.MemberID);
			}
			comboBoxMemberID.SelectedIndex = 0;
		}

		private void comboBoxMemberID_SelectedIndexChanged(object sender, EventArgs e)
		{
			var order = InseparableDb.Orders.Where(o => o.MemberID == memberID);
			comboBoxOrderID.Items.Clear();
			comboBoxOrderID.Items.Add("--請選擇--");
			foreach (var item in order)
			{
				comboBoxOrderID.Items.Add(item.OrderID);
			}
			comboBoxOrderID.SelectedIndex = 0;

		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			Display();
		}

		private void dataGridViewOrder_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int orderId = (int)dataGridViewOrder.CurrentRow.Cells[0].Value;

			var product = productRepo.Search(orderId, null).Select(po => new
			{
				項次 = po.ProductItem_no,
				訂單ID = po.OrderID,
				產品ID = po.ProductID,
				產品名稱 = po.ProductName,
				單價 = po.ProductUnitprice,
				折扣 = po.ProductDiscount,
				小記 = po.ProductSubtotal,
			});

			var ticket = ticketRepo.Search(orderId, null).Select(t => new
			{
				項次 = t.TicketItem_no,
				訂單ID = t.OrderID,
				電影 = t.Movies.MovieName,
				場次 = t.Sessions.SessionDate + " " + t.Sessions.SessionTime,
				座位 = t.Seats.SeatRow + " " + t.Seats.SeatColumn,
				影廳 = t.Rooms.RoomName,
				影城 = t.Rooms.Cinemas.CinemaName,
				票價 = t.TicketUnitprice,
				折扣 = t.TicketDiscount,
				小記 = t.TicketSubtotal
			});
			dataGridViewTicketDetail.DataSource = ticket.ToList(); ;
			dataGridViewProductDetail.DataSource = product.ToList(); ;
		}

		private void buttonOrderADD_Click(object sender, EventArgs e)
		{
			var frm =new FormAddOrders();

			frm.Owner= this;
			frm.ShowDialog();
		}

		private void buttonOrderEdit_Click(object sender, EventArgs e)
		{
			if (dataGridViewOrder.RowCount <= 0)
			{
				MessageBox.Show("你沒有選擇修改項目!!");
				return;
			}
			int orderId = (int)dataGridViewOrder.CurrentRow.Cells[0].Value;
			var frm = new FormEditOrders(orderId);

			frm.Owner = this;
			frm.ShowDialog();
		}

		private void buttonOrderDelete_Click(object sender, EventArgs e)
		{
			if (dataGridViewOrder.RowCount <= 0)
			{
				MessageBox.Show("你沒有選擇修改項目!!");
				return;
			}
			int orderId = (int)dataGridViewOrder.CurrentRow.Cells[0].Value;
			try
			{
				orderRepo.Delete(orderId);
			}catch(Exception ex)
			{
				MessageBox.Show("刪除失敗!!" + ex.Message);
			}

			Display();
		}

		private void buttonProductAdd_Click(object sender, EventArgs e)
		{
			InseparableEntities inseparableA =new InseparableEntities();
			if (dataGridViewOrder.RowCount <= 0)
			{
				MessageBox.Show("你沒有選擇新增項目!!");
				return;
			}
			int orderId = (int)dataGridViewOrder.CurrentRow.Cells[0].Value;
			int money = inseparableA.Orders.First(o => o.OrderID == orderId).TotalMoney;
			var frm = new FormAddProductOrderDetails(orderId,money);

			frm.Owner = this;
			frm.ShowDialog();
		}

		private void buttonProductEdit_Click(object sender, EventArgs e)
		{
			InseparableEntities inseparableE =new InseparableEntities();
			if (dataGridViewProductDetail.RowCount <= 0)
			{
				MessageBox.Show("你沒有選擇新增項目!!");
				return;
			}
			int orderId = (int)dataGridViewProductDetail.CurrentRow.Cells[1].Value;
			int item = (int)dataGridViewProductDetail.CurrentRow.Cells[0].Value;
			int money = inseparableE.Orders.First(o => o.OrderID == orderId).TotalMoney;
			
			var frm = new FormEditProductOrderDetails(orderId, money,item);

			frm.Owner = this;
			frm.ShowDialog();
		}

		private void buttonProductDelete_Click(object sender, EventArgs e)
		{
			InseparableEntities inseparableD =new InseparableEntities();
			int subtotal = 0;
			DateTime dt=DateTime.Now;
			if (dataGridViewProductDetail.RowCount <= 0)
			{
				MessageBox.Show("你沒有選擇新增項目!!");
				return;
			}
			int itemno = (int)dataGridViewProductDetail.CurrentRow.Cells[0].Value;
			int Id = (int)dataGridViewProductDetail.CurrentRow.Cells[1].Value;

			var subprice = inseparableD.ProductOrderDetails.Where(po => po.ProductItem_no == itemno);
			foreach (var item in subprice) {subtotal = item.ProductSubtotal;}

			var order = inseparableD.Orders.Where(o => o.OrderID == Id);
			foreach (var item in order)
			{
				item.TotalMoney -= subtotal; 
				item.ModifiedTime = dt;
			}
			try
			{
				productRepo.Delete(Id, itemno);
				inseparableD.SaveChanges();
			}catch(Exception ex) { MessageBox.Show("刪除失敗!!"+ex.Message);}
			

			Display();
		}
		private void buttonTicketAdd_Click(object sender, EventArgs e)
		{
			InseparableEntities inseparableA = new InseparableEntities();
			if (dataGridViewOrder.RowCount <= 0)
			{
				MessageBox.Show("你沒有選擇新增項目!!");
				return;
			}
			int orderId = (int)dataGridViewOrder.CurrentRow.Cells[0].Value;
			int money = inseparableA.Orders.First(o => o.OrderID == orderId).TotalMoney;
			var frm = new FormAddTicketOrderDetails(orderId, money);

			frm.Owner = this;
			frm.ShowDialog();
		}

		private void buttonTicketEdit_Click(object sender, EventArgs e)
		{
			InseparableEntities inseparableE = new InseparableEntities();
			if (dataGridViewTicketDetail.RowCount <= 0)
			{
				MessageBox.Show("你沒有選擇新增項目!!");
				return;
			}
			int orderId = (int)dataGridViewTicketDetail.CurrentRow.Cells[1].Value;
			int money = inseparableE.Orders.First(o => o.OrderID == orderId).TotalMoney;
			int item = (int)dataGridViewTicketDetail.CurrentRow.Cells[0].Value;
			var frm = new FormEditTicketOrderDetails(orderId, money, item);

			frm.Owner = this;
			frm.ShowDialog();
		}

		private void buttonTicketDelete_Click(object sender, EventArgs e)
		{
			InseparableEntities inseparableD = new InseparableEntities();
			int subtotal = 0;
			DateTime dt = DateTime.Now;
			if (dataGridViewTicketDetail.RowCount <= 0)
			{
				MessageBox.Show("你沒有選擇新增項目!!");
				return;
			}
			int itemno = (int)dataGridViewTicketDetail.CurrentRow.Cells[0].Value;
			int Id = (int)dataGridViewTicketDetail.CurrentRow.Cells[1].Value;
			
			var subprice = inseparableD.TicketOrderDetails.Where(t => t.TicketItem_no == itemno);
			foreach (var item in subprice) { subtotal = item.TicketSubtotal; }

			var order = inseparableD.Orders.Where(o => o.OrderID == Id);
			foreach (var item in order)
			{
				item.TotalMoney -= subtotal;
				item.ModifiedTime = dt;
			}
			try
			{
				ticketRepo.Delete(Id, itemno);
				inseparableD.SaveChanges();
			}
			catch(Exception ex) { MessageBox.Show("刪除失敗!!"+ex.Message); }
			Display();
			//todo itemno重新排序  目前解決方法取Max加1 排序問題用假資料代替
			//The property 'Id' is part of the object's key information and cannot be modified
		}
	}
}
