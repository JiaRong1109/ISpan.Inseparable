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
	public partial class FormRooms : Form,IGridContainer
	{
		InseparableEntities InseparableDb = new InseparableEntities();
		RoomRepository roomRepo;
		SeatRepository seatRepo;


		private int? cinemaID => comboBoxCinema.SelectedIndex > 0 ? InseparableDb.Cinemas.First(c => c.CinemaName == comboBoxCinema.Text).CinemaID : (int?)null;
		private int? roomID => comboBoxRoom.SelectedIndex > 0 ? InseparableDb.Rooms.Where(r=>r.CinemaID==cinemaID).First(r => r.RoomName == comboBoxRoom.Text).RoomID : (int?)null;

		public FormRooms()
		{
			InitializeComponent();

			roomRepo = new RoomRepository();
			seatRepo = new SeatRepository();

			this.Load += FormRooms_Load;
		}
		public void Display()
		{
			var roomsearch = roomRepo.Search(cinemaID).Select(r => new
			{
				影廳ID =r.RoomID,
				影城名稱=r.Cinemas.CinemaName,
				影廳名稱=r.RoomName,
			});

			var seatsearch = seatRepo.Search(roomID,cinemaID).Select(s => new
			{
				座位ID = s.SeatID,
				影院名稱=s.Rooms.Cinemas.CinemaName,
				影廳名稱 = s.Rooms.RoomName,
				幾排 = s.SeatRow,
				幾號 = s.SeatColumn,
			});

			dataGridViewRoom.DataSource = roomsearch.ToList();
			dataGridViewSeat.DataSource = seatsearch.ToList();
		}

		private void FormRooms_Load(object sender, EventArgs e)
		{
			Display();

			foreach(var item in InseparableDb.Cinemas)
			{
				comboBoxCinema.Items.Add(item.CinemaName);
			}
			comboBoxCinema.SelectedIndex = 0;
		}
		private void comboBoxCinema_SelectedIndexChanged(object sender, EventArgs e)
		{
			var room = InseparableDb.Rooms.Where(r => r.CinemaID == cinemaID);
			comboBoxRoom.Items.Clear();
			comboBoxRoom.Items.Add("--請選擇--");
			foreach (var item in room)
			{
				comboBoxRoom.Items.Add(item.RoomName);
			}
			comboBoxRoom.SelectedIndex = 0;
		}
		private void buttonSearch_Click(object sender, EventArgs e)
		{
			Display();
		}

		private void buttonRoomAdd_Click(object sender, EventArgs e)
		{
			var frm = new FormAddRooms();

			frm.Owner = this;
			frm.ShowDialog();
		}

		private void buttonRoomEdit_Click(object sender, EventArgs e)
		{
			if (dataGridViewRoom.RowCount <= 0)
			{
				MessageBox.Show("你沒有選擇ㄟ!!");
				return;

			}
			int RoomId = (int)dataGridViewRoom.CurrentRow.Cells[0].Value;

			var frm = new FormEditRooms(RoomId);

			frm.Owner = this;
			frm.ShowDialog();		
		}

		private void buttonRoomDelete_Click(object sender, EventArgs e)
		{
			if (dataGridViewRoom.RowCount <=0)
			{
				MessageBox.Show("你沒有選擇ㄟ!!");
				return;
			}

			int roomID = (int)dataGridViewRoom.CurrentRow.Cells[0].Value;
			try
			{
				roomRepo.Delete(roomID);
			}
			catch (Exception ex) { MessageBox.Show("刪除失敗!!" + ex.Message); }
			Display();
		}
			private void buttonSeatAdd_Click(object sender, EventArgs e)
		{
			var frm = new FormAddSeat();

			frm.Owner = this;
			frm.ShowDialog();
		}

		private void buttonSeatEdit_Click(object sender, EventArgs e)
		{
			if (dataGridViewSeat.RowCount <= 0)
			{
				MessageBox.Show("你沒有選擇ㄟ!!");
				return;
			}
			int seatId = (int)dataGridViewSeat.CurrentRow.Cells[0].Value;

			var frm = new FormEditSeats(seatId);

			frm.Owner = this;
			frm.ShowDialog();
		}

		private void buttonSeatDelete_Click(object sender, EventArgs e)
		{
			if (dataGridViewSeat.RowCount <= 0)
			{
				MessageBox.Show("你沒有選擇刪除資料!!"); 
				return;
			}

			int seatId = (int)dataGridViewSeat.CurrentRow.Cells[0].Value;
			try { seatRepo.Delete(seatId); } catch (Exception ex) { MessageBox.Show("刪除失敗!!" + ex.Message); }
			Display();
		}

		private void dataGridViewRoom_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int roomId= (int)dataGridViewRoom.CurrentRow.Cells[0].Value;

			var seat = seatRepo.Search(roomId,null).Select(s => new
			{
				座位ID = s.SeatID,
				影院名稱 = s.Rooms.Cinemas.CinemaName,
				影廳名稱 = s.Rooms.RoomName,
				幾排 = s.SeatRow,
				幾號 = s.SeatColumn,
			});

			dataGridViewSeat.DataSource= seat.ToList();
		}
	}
}
