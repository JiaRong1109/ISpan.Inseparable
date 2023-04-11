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
	public partial class FormCreateArticle : Form
	{
		private KeywordService keywordService;
		private List<KeywordSearchDto> _keywordsLeave = new List<KeywordSearchDto>();
		private List<KeywordSearchDto> _keywordsChosen = new List<KeywordSearchDto>();

		private KeywordDetailService detailService;
		public int? MemberID => int.TryParse(textBoxMemberID.Text, out int memberID)
								? memberID
								: (int?)null;

		public FormCreateArticle()
		{
			IKeywordRepository keywordRepo = new KeywordRepository();
			keywordService = new KeywordService(keywordRepo);

			IKeywordDetailRepository detailRepo = new KeywordDetailRepository();
			detailService = new KeywordDetailService(detailRepo);

			InitializeComponent();
			this.Load += FormCreateArticle_Load;
		}

		private void FormCreateArticle_Load(object sender, EventArgs e)
		{
			_keywordsLeave = keywordService.Search((int?)null, string.Empty).ToList();

			ShowKeywords();
		}

		private void ShowKeywords()
		{
			//在此重製排序,使其排序與dataGridView相同
			_keywordsLeave = _keywordsLeave.OrderBy(c => c.KeywordID).ToList();
			_keywordsChosen = _keywordsChosen.OrderBy(c => c.KeywordID).ToList();

			dataGridViewLeave.DataSource = _keywordsLeave.SearchDtosToVms();
			dataGridViewChosen.DataSource = _keywordsChosen.SearchDtosToVms();
		}
		private ArticleCreateVm GetModel()
		=> new ArticleCreateVm
		{
			Title = textBoxTitle.Text,
			PostingDate = DateTime.Now,
			Likes = 0,
			Clicks = 0,
			Content= textBoxContent.Text,
			MemberID = MemberID,
		};

		private (bool isValid, List<ValidationResult> errors) Validate(ArticleCreateVm vm)
		{
			// 得知要驗證規則
			ValidationContext context = new ValidationContext(vm, null, null);

			// 用來存放錯誤的集合,因為可能有零到多個錯誤
			List<ValidationResult> errors = new List<ValidationResult>();

			// 驗證 model
			bool validateAllProperties = true; // 是否驗證所有規則,而非只驗證Required規則
			bool isValid = Validator.TryValidateObject(vm, context, errors, validateAllProperties);

			isValid = errors.Count == 0;

			return (isValid, errors);
		}

		private void DisplayErrors(List<ValidationResult> errors)
		{
			// 大小寫不同仍視為相同的key
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"MemberID", textBoxMemberID},
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

		private void buttonCreate_Click(object sender, EventArgs e)
		{
			// 繫結表單控制項到 ArticleCreateVm
			var vm = GetModel();

			// 針對view model 進行欄位驗證, 如果有錯誤就顯示錯誤訊息
			(bool isValid, List<ValidationResult> errors) validationResult = Validate(vm);

			if (validationResult.isValid == false)
			{
				this.errorProvider1.Clear();
				DisplayErrors(validationResult.errors);
				return;
			}

			// 如果通過驗證,轉型為ArticleCreateDto
			var dto = vm.CreateVmToDto();

			// 傳給 ArticleService
			IArticleRepository articleRepo = new ArticleRepository();
			ArticleService articleService = new ArticleService(articleRepo);

			try
			{
				articleService.Create(dto);
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗\r\n" + ex.Message);
			}

			//取得新建之ArticleID以新增文章類別
			int articleID = articleService.GetByTitle(dto.Title).ArticleID;
			foreach (var keyword in _keywordsChosen)
			{
				KeywordDetailCreateDto detailCreateDto = new KeywordDetailCreateDto()
				{
					ArticleID = articleID,
					KeywordID = keyword.KeywordID
				};
				detailService.Create(detailCreateDto);
			}

			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();

			this.DialogResult = DialogResult.OK;
		}

		private void dataGridViewLeave_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			_keywordsChosen.Add(_keywordsLeave[e.RowIndex]);
			_keywordsLeave.Remove(_keywordsLeave[e.RowIndex]);
			ShowKeywords();
		}

		private void dataGridViewChosen_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			_keywordsLeave.Add(_keywordsChosen[e.RowIndex]);
			_keywordsChosen.Remove(_keywordsChosen[e.RowIndex]);

			ShowKeywords();
		}
	}
}
