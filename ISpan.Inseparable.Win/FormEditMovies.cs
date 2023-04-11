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
	public partial class FormEditMovies : Form
	{
		InseparableEntities InseparableDb =new InseparableEntities();
		MovieRepository repo;

		private readonly int MovieID;
		string str = string.Empty;
		int? LevelID => comboBoxLevel.SelectedIndex > 0 ? InseparableDb.MovieLevels.First(l => l.LevelName == comboBoxLevel.Text).LevelID : (int?)null;
		int? Length => int.TryParse(textBoxLength.Text, out int Length) ? Length : (int?)null;
		public FormEditMovies(int MovieID)
		{
			InitializeComponent();
			repo = new MovieRepository();

			this.MovieID= MovieID;
			this.Load += FormEditMovies_Load;
		}

		private void FormEditMovies_Load(object sender, EventArgs e)
		{
			var leverl = InseparableDb.MovieLevels.Select(l => l.LevelName);
			foreach (var item in leverl)
			{
				comboBoxLevel.Items.Add(item);
			}

			var get = repo.GetMovie(MovieID);

			foreach(var item in get)
			{
				labeID.Text=item.MovieID.ToString();
				textBoxName.Text = item.MovieName;
				textBoxLength.Text = item.MovieLength.ToString();
				textBoxInto.Text = item.MovieIntroduction;
				comboBoxLevel.Text = item.MovieLevels.LevelName;
				dateTimePickerOn.Value = item.MovieOnDate;
				dateTimePickerOff.Value= item.MovieOffDate;
				if (item.MoviePicture != null)
				{
					MemoryStream myStream = new MemoryStream(item.MoviePicture);
					pictureBoxPic.Image = Image.FromStream(myStream);
				}
			}
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxName.Text) || Length == null || LevelID == null || string.IsNullOrEmpty(textBoxInto.Text))
			{
				MessageBox.Show("資料有誤!!");
				return;
			}
			InseparableEntities InseparableE =new InseparableEntities();
			var Edit = InseparableE.Movies.Where(m => m.MovieID == MovieID);

			foreach(var item in Edit)
			{
				item.MovieName = textBoxName.Text;
				item.MovieLength = (int)Length;
				item.MovieLevelID = (int)LevelID;
				if (string.IsNullOrEmpty(str)==false)
				{
					item.MoviePicture = ImageTranse();
				}
				item.MovieOnDate= dateTimePickerOn.Value;
				item.MovieOffDate= dateTimePickerOff.Value;
				item.MovieIntroduction =textBoxInto.Text;
			}
			try { InseparableE.SaveChanges(); } catch (Exception ex) { MessageBox.Show("更新失敗!!" + ex.Message); }

			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();
			this.DialogResult = DialogResult.OK;
		}

		private void buttonSelectImage_Click(object sender, EventArgs e)
		{
			if (openFileDialogImage.ShowDialog() == DialogResult.OK)
			{
				str = openFileDialogImage.FileName;
				pictureBoxPic.Image = Image.FromFile(str);
			}
		}

		private byte[] ImageTranse()
		{
			FileStream fs = new FileStream(str, FileMode.Open, FileAccess.Read);
			BinaryReader br = new BinaryReader(fs);
			byte[] imgBytesIn = br.ReadBytes(Convert.ToInt32(fs.Length));
			return imgBytesIn;
		}
	}
}
