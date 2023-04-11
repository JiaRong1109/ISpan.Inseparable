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
	public partial class FormEditArticle : Form
	{
		private readonly int articleID;
		private ArticleService articleService;
		private KeywordDetailService detailService;

		private KeywordService keywordService;
		private List<KeywordSearchDto> _keywordsLeave = new List<KeywordSearchDto>();
		private List<KeywordSearchDto> _keywordsUpdate = new List<KeywordSearchDto>();
		private List<KeywordSearchDto> _keywordsChosen = new List<KeywordSearchDto>();

		public FormEditArticle(int articleID)
		{
			IArticleRepository articleRepo = new ArticleRepository();
			articleService = new ArticleService(articleRepo);
			IKeywordDetailRepository detailRepo = new KeywordDetailRepository();
			detailService = new KeywordDetailService(detailRepo);
			IKeywordRepository keywordRepo = new KeywordRepository();
			keywordService = new KeywordService(keywordRepo);
			_keywordsUpdate = keywordService.GetByArticleID(articleID).ToList();
			_keywordsChosen = keywordService.GetByArticleID(articleID).ToList();
			_keywordsLeave = keywordService.GetKeywordsLeave(articleID).ToList();

			InitializeComponent();


			this.articleID = articleID;
			this.Load += FormEditArticle_Load;
		}

		private void FormEditArticle_Load(object sender, EventArgs e)
		{
			ArticleUpdateDto article = articleService.GetByArticleID(articleID);

			BindForm(article);
			ShowKeywords();
		}

		private void BindForm(ArticleUpdateDto dto)
		{
			labelArticleID.Text += articleID.ToString();
			labelMemberID.Text += dto.MemberID.ToString();
			labelLikes.Text += dto.Likes.ToString();
			labelClicks.Text += dto.Clicks.ToString();
			labelPostingDate.Text += dto.PostingDate.ToString();
			textBoxTitle.Text += dto.Title;
			textBoxContent.Text = dto.Content;
		}

		private ArticleUpdateVm GetModel()
		=> new ArticleUpdateVm
		{
			ArticleID = this.articleID,
			Title = textBoxTitle.Text,
			Content = textBoxContent.Text,
		};
		private (bool isValid, List<ValidationResult> errors) Validate(ArticleUpdateVm vm)
		{
			// 得知要驗證規則
			ValidationContext context = new ValidationContext(vm, null, null);

			// 用來存放錯誤的集合,因為可能有零到多個錯誤
			List<ValidationResult> errors = new List<ValidationResult>();

			// 驗證 model
			bool validateAllProperties = true; // 是否驗證所有規則,而非只驗證Required規則
			bool isValid = Validator.TryValidateObject(vm, context, errors, validateAllProperties);

			return (isValid, errors);
		}

		private void DisplayErrors(List<ValidationResult> errors)
		{
			// 大小寫不同仍視為相同的key
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Title", textBoxTitle},
				{"Content", textBoxContent},
			};

			this.errorProvider1.Clear();

			foreach (ValidationResult error in errors)
			{
				string propName = error.MemberNames.FirstOrDefault();
				if (map.TryGetValue(propName, out Control ctrl))
				{
					this.errorProvider1.SetError(ctrl, error.ErrorMessage);
				}
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			// 繫結表單控制項到 ArticleUpdateVm
			var vm = GetModel();

			// 針對view model 進行欄位驗證, 如果有錯誤就顯示錯誤訊息
			(bool isValid, List<ValidationResult> errors) validationResult = Validate(vm);

			if (validationResult.isValid == false)
			{
				this.errorProvider1.Clear();
				DisplayErrors(validationResult.errors);
				return;
			}

			// 如果通過驗證,轉型為ArticleUpdateDto
			var dto = vm.UpdateVmToDto();

			// 傳給 ArticleService
			IArticleRepository repo = new ArticleRepository();
			ArticleService service = new ArticleService(repo);

			try
			{
				service.Update(dto);
			}
			catch (Exception ex)
			{
				MessageBox.Show("更新失敗\r\n" + ex.Message);
			}
			
			foreach (var keyword in _keywordsChosen.Except(_keywordsUpdate))
			{
				new KeywordDetailRepository().Delete(articleID, keyword.KeywordID);
			}

			foreach (var keyword in _keywordsUpdate.Except(_keywordsChosen))
			{
				KeywordDetailCreateDto detailCreateDto = new KeywordDetailCreateDto()
				{
					ArticleID = articleID,
					KeywordID = keyword.KeywordID
				};
				detailService.Create(detailCreateDto);
			}

			NotifyOwner();
		}
		private void NotifyOwner()
		{
			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();

			this.DialogResult = DialogResult.OK;
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			new ArticleRepository().Delete(GetModel().ArticleID);

			NotifyOwner();
		}

		private void buttonCheckComment_Click(object sender, EventArgs e)
		{
			FormComments formComments = new FormComments();
			formComments.Owner = this;
			formComments.ShowDialog();
		}
		private void ShowKeywords()
		{
			_keywordsUpdate = _keywordsUpdate.OrderBy(c => c.KeywordID).ToList();
			_keywordsLeave = _keywordsLeave.OrderBy(c => c.KeywordID).ToList();

			dataGridViewUpdate.DataSource = _keywordsUpdate.SearchDtosToVms();
			dataGridViewLeave.DataSource = _keywordsLeave.SearchDtosToVms();
		}

		private void dataGridViewLeave_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			_keywordsUpdate.Add(_keywordsLeave[e.RowIndex]);
			_keywordsLeave.Remove(_keywordsLeave[e.RowIndex]);
			ShowKeywords();
		}

		private void dataGridViewUpdate_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			_keywordsLeave.Add(_keywordsUpdate[e.RowIndex]);
			_keywordsUpdate.Remove(_keywordsUpdate[e.RowIndex]);

			ShowKeywords();
		}
	}
}
