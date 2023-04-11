using ISpan.Inseparable.BLL.Interface;
using ISpan.Inseparable.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.Inseparable.Win
{
	public partial class FormSessions : Form,IGridContainer
	{
		InseparableEntities InseparableDb = new InseparableEntities();
		SessionRepository repo;

		private int? movieId => comboBoxMovie.SelectedIndex>0? ComboUtilities.GetItem(comboBoxMovie).Value :(int?)null;
		//InseparableDb.Movies.First(m=>m.MovieName==comboBoxMovie.Text).MovieID
		private int? cinemaId => comboBoxCinema.SelectedIndex>0? ComboUtilities.GetItem(comboBoxCinema).Value:(int?)null;
		//InseparableDb.Cinemas.First(c=>c.CinemaName==comboBoxCinema.Text).CinemaID
		private int? roomId=>comboBoxRoom.SelectedIndex>0? ComboUtilities.GetItem(comboBoxRoom).Value:(int?)null;
		//InseparableDb.Rooms.Where(r=>r.CinemaID==cinemaId).First(r=>r.RoomName==comboBoxRoom.Text).RoomID
		public FormSessions()
		{
			InitializeComponent();

			repo =new SessionRepository();
			this.Load += FormSessions_Load;
		}
		public void Display()
		{
			dateTimePickerEnd.Value = DateTime.Today.AddMonths(1);
			var search = repo.Search(movieId, cinemaId, roomId, dateTimePickerBegin.Value, dateTimePickerEnd.Value).Select(s => new
			{
				場次ID= s.SessionId,
				電影=s.Movies.MovieName,
				影廳=s.Rooms.RoomName,
				影城=s.Cinemas.CinemaName,
				日期 =s.SessionDate,
				時間=s.SessionTime, 
				票價=s.TicketPrice,
			});

			dataGridViewSession.DataSource = search.ToList();
		}
		private void FormSessions_Load(object sender, EventArgs e)
		{
			Display();
			
			foreach(var item in InseparableDb.Cinemas)
			{
				comboBoxCinema.Items.Add(new ComboBoxItem(item.CinemaID, item.CinemaName));
			}
			comboBoxCinema.SelectedIndex= 0;

			foreach (var item in InseparableDb.Movies)
			{
				comboBoxMovie.Items.Add(new ComboBoxItem(item.MovieID, item.MovieName));
			}
			comboBoxMovie.SelectedIndex = 0;

		}
		private void comboBoxCinema_SelectedIndexChanged(object sender, EventArgs e)
		{
			var room = InseparableDb.Rooms.Where(r => r.CinemaID == cinemaId);
			comboBoxRoom.Items.Clear();
			comboBoxRoom.Items.Add("--請選擇--");
			foreach (var item in room)
			{
				comboBoxRoom.Items.Add(new ComboBoxItem(item.RoomID, item.RoomName));
			}
			comboBoxRoom.SelectedIndex= 0;
		}
		private void buttonSearch_Click(object sender, EventArgs e)
		{
			Display();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			var frm =new FormAddSessions();

			frm.Owner= this;
			frm.ShowDialog();
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			if (dataGridViewSession.RowCount > 0)
			{
				int sessionId = (int)dataGridViewSession.CurrentRow.Cells[0].Value;

				var frm = new FormEditSessions(sessionId);
				frm.Owner= this;
				frm.ShowDialog();
			}
			else { MessageBox.Show("你沒有選擇需要修改項目~~"); }
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (dataGridViewSession.RowCount <= 0)
			{
				MessageBox.Show("你沒有選擇需要刪除項目~~"); 
				return;
			}

			int sessionId = (int)dataGridViewSession.CurrentRow.Cells[0].Value;
			

			try
			{
				repo.Delete(sessionId);
			}catch(Exception ex) { MessageBox.Show("刪除失敗!!"+ex.Message); }

			Display();
		}
	}
}
