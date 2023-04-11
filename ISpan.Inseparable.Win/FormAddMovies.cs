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
	public partial class FormAddMovies : Form
	{
		InseparableEntities InseparableDb = new InseparableEntities();
		Movies movies= new Movies();

		string str = string.Empty;
		int? LevelID => comboBoxLevel.SelectedIndex > 0 ? InseparableDb.MovieLevels.First(l => l.LevelName == comboBoxLevel.Text).LevelID : (int?)null;
		int? Length=>int.TryParse(textBoxLength.Text,out int Length)? Length:(int?)null;

		public FormAddMovies()
		{
			InitializeComponent();

			this.Load += FormAddMovies_Load;
		}

		private void FormAddMovies_Load(object sender, EventArgs e)
		{
			var leverl = InseparableDb.MovieLevels.Select(l => l.LevelName);
			foreach (var item in leverl)
			{
				comboBoxLevel.Items.Add(item);
			}
			comboBoxLevel.SelectedIndex = 0;
		}
		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (textBoxName.Text == string.Empty || LevelID == null || Length == null || dateTimePickerOn.Value > dateTimePickerOff.Value || textBoxInto == null )
			{
				MessageBox.Show("輸入資料有誤!!");
				return;
			}
			movies.MovieName=textBoxName.Text;
			movies.MovieLevelID = (int)LevelID;
			movies.MovieLength=(int)Length;
			movies.MovieOnDate = dateTimePickerOn.Value;
			movies.MovieOffDate= dateTimePickerOff.Value;
			if (string.IsNullOrEmpty(str) == false)
			{
				movies.MoviePicture = ImageTranse();
			}
			movies.MovieIntroduction=textBoxInto.Text;
			
			try
			{
				InseparableDb.Movies.Add(movies);
				InseparableDb.SaveChanges();
			}
			catch (Exception ex) { MessageBox.Show("新增失敗了~" + ex); }

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
