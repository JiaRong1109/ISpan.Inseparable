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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using System.Windows.Forms.ComponentModel.Com2Interop;
using static System.Windows.Forms.AxHost;
using System.Security.Cryptography;
using ISpan.Inseparable.BLL.Interface;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace ISpan.Inseparable.Win
{
	public partial class FormProducts : Form, IGridContainer
	{

		InseparableEntities InseparableDb = new InseparableEntities();
		private ProductRepository repo;

		private int? categoryID => comboBoxCategory.SelectedIndex > 0 ?  ComboUtilities.GetItem(comboBoxCategory).Value: (int?)null;
		//InseparableDb.ProductCategories.First(c => c.ProductCategoryName == comboBoxCategory.Text).ProductCategoryID
		private int? cinemaID => comboBoxCinema.SelectedIndex > 0 ? ComboUtilities.GetItem(comboBoxCinema).Value : (int?)null;
		//InseparableDb.Cinemas.First(ci => ci.CinemaName == comboBoxCinema.Text).CinemaID
		public FormProducts()
		{
			InitializeComponent();
			this.Load += FormProducts_Load;
			repo = new ProductRepository();
		}
		public void Display()
		{
			var product = repo.Search(categoryID, cinemaID, textBoxName.Text).Select(pro => new
			{
				產品ID = pro.ProductId,
				產品名稱 = pro.ProductName,
				類別ID = pro.ProductCategories.ProductCategoryName,
				單價 = pro.ProductUnitprice,
				庫存 = pro.ProductStock,
				影院ID = pro.Cinemas.CinemaName
			});
			dataGridViewProduct.DataSource = product.ToList();
		}
		private void FormProducts_Load(object sender, EventArgs e)
		{
			Display();

			foreach(var item in InseparableDb.ProductCategories)
			{
				comboBoxCategory.Items.Add(new ComboBoxItem(item.ProductCategoryID, item.ProductCategoryName));
			}
			comboBoxCategory.SelectedIndex = 0;

			foreach(var item in InseparableDb.Cinemas)
			{
				comboBoxCinema.Items.Add(new ComboBoxItem (item.CinemaID,item.CinemaName));
			}
			comboBoxCinema.SelectedIndex = 0;
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			Display();
		}

		
		private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			repo = new ProductRepository();
			if (e.RowIndex < 0) return;

			int ProductID = (int)dataGridViewProduct.CurrentRow.Cells[0].Value;

			var get = repo.GrtProduct(ProductID);
			BindForm(get);
		}
		private void BindForm(Products get)
		{
			labelID.Text = get.ProductId.ToString();
			labelName.Text = get.ProductName;
			labelPrice.Text = get.ProductUnitprice.ToString();
			labelQty.Text = get.ProductStock.ToString();
			labelCategory.Text = get.ProductCategories.ProductCategoryName;
			labelCinema.Text = get.Cinemas.CinemaName;
			pictureBoxProduct.Image = null;
			if (get.ProductPicture != null)
			{
				MemoryStream myStream = new MemoryStream(get.ProductPicture);
				pictureBoxProduct.Image = Image.FromStream(myStream);
			}
		}
		private void buttonAdd_Click(object sender, EventArgs e)
		{
			var frm = new FormAddProducts();

			frm.Owner=this; 
			frm.ShowDialog();
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			if (dataGridViewProduct.RowCount <= 0)
			{
				MessageBox.Show("你沒有選擇商品ㄟ!!");
				return;
			}
			int ProductID = (int)dataGridViewProduct.CurrentRow.Cells[0].Value;

			var from = new FormEditProducts(ProductID);
			from.Owner = this;
			from.ShowDialog();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (dataGridViewProduct.RowCount <= 0)
			{
				MessageBox.Show("你沒有選擇商品ㄟ!!");
				return;
			}

			int ProductID = (int)dataGridViewProduct.CurrentRow.Cells[0].Value;
			try
			{
				repo.Delete(ProductID);
			}
			catch (Exception ex) { MessageBox.Show("刪除失敗!!" + ex.Message); }
			Display();
		}

		private void buttonCategory_Click(object sender, EventArgs e)
		{
			var frm =new FormProductCategories();
			frm.ShowDialog();
		}

	}

	
}
