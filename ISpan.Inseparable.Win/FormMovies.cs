using ISpan.Inseparable.BLL.Interface;
using ISpan.Inseparable.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.Inseparable.Win
{
	public partial class FormMovies : Form,IGridContainer
	{
		InseparableEntities InseparableDb = new InseparableEntities();
		MovieRepository repo;

		int? levelID => comboBoxLevel.SelectedIndex>0? InseparableDb.MovieLevels.First(l=>l.LevelName==comboBoxLevel.Text).LevelID:(int?)null;
		string SName =>string.IsNullOrEmpty(textBoxName.Text) ? null : textBoxName.Text;

		DateTime? dt=null;
		public FormMovies()
		{
			InitializeComponent();
			repo=new MovieRepository();

			this.Load += FormMovies_Load;
		}
		public void Display()
		{
			dt = null;
			if (checkBoxDate.Checked) { dt = DateTime.Now; }
			var Search = repo.Search(null, SName, dt, levelID).Select(m => new
			{
				電影ID = m.MovieID,
				名稱 = m.MovieName,
				簡介 = m.MovieIntroduction,
				級別 = m.MovieLevelID,
				上映日 = m.MovieOnDate,
				下架日 = m.MovieOffDate,
				時長 = m.MovieLength,
				//照片 = m.MoviePicture,

			});
			dataGridViewMovie.DataSource = Search.ToList();
		}
		private void FormMovies_Load(object sender, EventArgs e)
		{
			var leverl = InseparableDb.MovieLevels.Select(l=>l.LevelName);

			foreach(var item in leverl)
			{
				comboBoxLevel.Items.Add(item);
			}
			comboBoxLevel.SelectedIndex = 0;
			Display();
		}

		private void dataGridViewMovie_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			repo = new MovieRepository();
			if (e.RowIndex < 0) return;
			int ID = (int)dataGridViewMovie.CurrentRow.Cells[0].Value;

			var search = repo.Search(ID, null, null, null);
			foreach(var item in search)
			{
				labelID.Text=item.MovieID.ToString();
				labelName.Text=item.MovieName;
				labelOnDate.Text=item.MovieOnDate.ToString();
				labelOffDate.Text=item.MovieOffDate.ToString();
				labellevel.Text=item.MovieLevelID.ToString();
				labelLength.Text=item.MovieLength.ToString();
				textBoxInto.Text = item.MovieIntroduction;
				pictureBoxPic.Image = null;
				if (item.MoviePicture != null)
				{
					MemoryStream myStream = new MemoryStream(item.MoviePicture);
					pictureBoxPic.Image = Image.FromStream(myStream);
				}
			}
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			Display();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			var frm = new FormAddMovies();

			frm.Owner= this;
			frm.ShowDialog();
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			if (dataGridViewMovie.RowCount <= 0)
			{
				MessageBox.Show("你沒有選擇項目~");
				return;
			}
			int MovieID = (int)dataGridViewMovie.CurrentRow.Cells[0].Value;
			var frm = new FormEditMovies(MovieID);
			frm.Owner= this;
			frm.ShowDialog();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (dataGridViewMovie.RowCount <= 0)
			{
				MessageBox.Show("你沒有選擇項目~");
				return;
			}
			int ID = (int)dataGridViewMovie.CurrentRow.Cells[0].Value;

			var delete = InseparableDb.Movies.First(m => m.MovieID == ID);
			try
			{
				InseparableDb.Movies.Remove(delete);
				InseparableDb.SaveChanges();
			}catch(Exception ex) { MessageBox.Show("刪除失敗!!"+ex.Message);}

			Display();
		}
	}
}
