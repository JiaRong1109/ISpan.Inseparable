using ISpan.Inseparable.BLL;
using ISpan.Inseparable.BLL.Interface;
using ISpan.Inseparable.SqlDataLayer;
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
	public partial class FormKeywords : Form, IGridContainer
	{
		private KeywordRepository repo;
		private KeywordService service;
		private List<KeywordSearchDto> _articleKeywords;

		public int? KeywordID => int.TryParse(textBoxKeywordID.Text, out int articleKeywordID)
								? articleKeywordID
								: (int?)null;
		public string KeywordName => textBoxName.Text;
		public int EditID { get; private set; }
		public FormKeywords()
		{
			InitializeComponent();

			repo = new KeywordRepository();
			service = new KeywordService(repo);

			this.Load += FormKeywords_Load;
		}

		private void FormKeywords_Load(object sender, EventArgs e)
		{
			Display();
		}
		public void Display()
		{
			_articleKeywords = service.Search(KeywordID, KeywordName).ToList();
			dataGridView1.DataSource = _articleKeywords.SearchDtosToVms();
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			Display();
		}

		private void buttonAddNew_Click(object sender, EventArgs e)
		{
			FormCreateKeyword formCreateKeyword = new FormCreateKeyword();
			formCreateKeyword.Owner = this;
			formCreateKeyword.ShowDialog();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			//if (e.RowIndex < 0) return;
			//int articleKeywordID = _articleKeywords[e.RowIndex].文章類別ID;

			//FormEditKeyword formEditKeyword = new FormEditKeyword(articleKeywordID);
			//formEditKeyword.Owner = this;
			//formEditKeyword.ShowDialog();

			EditID = _articleKeywords[e.RowIndex].KeywordID;
		}
		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			if (EditID <= 0)
			{
				MessageBox.Show("請選擇編輯目標");
				return;
			}

			FormEditKeyword formEditKeyword = new FormEditKeyword(EditID);
			formEditKeyword.Owner = this;
			formEditKeyword.ShowDialog();
		}
		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (EditID <= 0)
			{
				MessageBox.Show("請選擇刪除目標");
				return;
			}

			new KeywordRepository().Delete(EditID);
			Display();
		}
	}
}
