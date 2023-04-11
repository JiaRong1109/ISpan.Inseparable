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
	public partial class FormCinemas : Form, IGridContainer
	{
		InseparableEntities InseparableDb = new InseparableEntities();
		CinemasRepository repo;

		string country => comboBoxCountry.SelectedIndex > 0 ? comboBoxCountry.Text : null; 
		string SName=>string.IsNullOrEmpty(textBoxName.Text)? null:textBoxName.Text;
		public FormCinemas()
		{
			InitializeComponent();
			repo= new CinemasRepository();

			this.Load += FormCinemas_Load;
		}

		public void Display()
		{
			var search = repo.Search(SName, country).Select(c => new
			{
				ID=c.CinemaID,
				影城=c.CinemaName,
				地區=c.CinemaRegion,
				地址=c.CinemaAddress,
				電話=c.CinemaTel,
			});

			dataGridViewCinema.DataSource = search.ToList();
		}
		private void FormCinemas_Load(object sender, EventArgs e)
		{
			Display();
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			Display();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			var frm =new FormAddCinemas();
			frm.Owner=this;
			frm.ShowDialog();
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			if (dataGridViewCinema.RowCount <= 0)
			{
				MessageBox.Show("你沒有選擇資料~~");
				return;
			}
			int ID = (int)dataGridViewCinema.CurrentRow.Cells[0].Value;
			var frm =new FormEditCinemas(ID);

			frm.Owner=this;
			frm.ShowDialog();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (dataGridViewCinema.RowCount <= 0)
			{
				MessageBox.Show("你沒有選擇資料~~");
				return;
			}
			int ID = (int)dataGridViewCinema.CurrentRow.Cells[0].Value;

			try
			{
				repo.Delete(ID);
			}catch(Exception ex) { MessageBox.Show("刪除失敗!!"+ex.Message); }

			Display();
		}
	}
}
