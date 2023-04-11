using ISpan.Inseparable.BLL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ISpan.Inseparable.Win
{
	public partial class FormArticles : Form, IGridContainer
	{
		private ArticleRepository articleRepo;
		private KeywordRepository keywordRepo;
		private ArticleService articleService;
		private KeywordService keywordService;
		private List<ArticleSearchDto> _articles;
		private List<KeywordSearchDto> _keywords;
		public int? ArticleID => int.TryParse(textBoxArticleID.Text, out int articleID)
								? articleID
								: (int?)null;
		public string Title => textBoxTitle.Text;
		public int? MemberID => int.TryParse(textBoxMemberID.Text, out int memberID)
								? memberID
								: (int?)null;
		public int? KeywordID => comboBoxKeyword.GetItem().Value;
		public FormArticles()
		{
			InitializeComponent();

			articleRepo = new ArticleRepository();
			articleService = new ArticleService(articleRepo);

			keywordRepo = new KeywordRepository();
			keywordService = new KeywordService(keywordRepo);

			this.Load += FormArticles_Load;
		}

		private void FormArticles_Load(object sender, EventArgs e)
		{
			_keywords = keywordService.Search((int?)null, string.Empty).ToList();
			foreach (var keyword in _keywords)
			{
				comboBoxKeyword.Items.Add(new ComboBoxItem(keyword.KeywordID, keyword.Name));
			}

			Display();
		}
		public void Display()
		{
			_articles = articleService.Search(ArticleID, Title, MemberID, KeywordID).ToList();
			
			dataGridView1.DataSource = _articles.SearchDtosToVms();
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			Display();
		}

		private void buttonAddNew_Click(object sender, EventArgs e)
		{
			FormCreateArticle formCreateArticle = new FormCreateArticle();
			formCreateArticle.Owner = this;
			formCreateArticle.ShowDialog();
		}

		private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			int articleID = _articles[e.RowIndex].ArticleID;
			FormEditArticle formEditArticle = new FormEditArticle(articleID);
			formEditArticle.Owner = this;
			formEditArticle.ShowDialog();
		}

		private void buttonCharts_Click(object sender, EventArgs e)
		{
			FormCharts formCharts = new FormCharts();
			formCharts.ShowDialog();
		}
	}
}
