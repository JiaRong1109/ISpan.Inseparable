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

namespace ISpan.Inseparable.Win
{
	public partial class FormComments : Form, IGridContainer
	{
		private CommentRepository repo;
		private CommentService service;
		private List<CommentSearchDto> _comments;
		//private readonly int memberID;

		public int? ArticleID => int.TryParse(textBoxArticleID.Text, out int articleID)
								? articleID
								: (int?)null;
		public int? ItemNumber => int.TryParse(textBoxItemNumber.Text, out int itemNumber)
								? itemNumber
								: (int?)null;
		public int? MemberID => int.TryParse(textBoxMemberID.Text, out int memberID)
								? memberID
								: (int?)null;
		public FormComments()
		{
			InitializeComponent();

			repo = new CommentRepository();
			IArticleRepository articleRepos = new ArticleRepository();

			service = new CommentService(repo, articleRepos);

			this.Load += FormComments_Load;
		}
		//public FormComments(int memberID)
		//{
		//	InitializeComponent();

		//	repo = new CommentRepository();
		//	articleService = new CommentService(repo);

		//	this.Load += FormComments_Load;
		//	this.memberID = memberID;
		//}

		private void FormComments_Load(object sender, EventArgs e)
		{
			Display();
		}
		public void Display()
		{
			_comments = service.Search(ArticleID, ItemNumber, MemberID).ToList();
			dataGridView1.DataSource = _comments.SearchDtosToVms();
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			Display();
		}

		private void buttonAddNew_Click(object sender, EventArgs e)
		{
			FormCreateComment formCreateComment = new FormCreateComment();
			formCreateComment.Owner = this;
			formCreateComment.ShowDialog();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			int articleID = _comments[e.RowIndex].ArticleID;
			int itemNumber = _comments[e.RowIndex].ItemNumber;
			FormEditComment formEditComment = new FormEditComment(articleID, itemNumber);
			formEditComment.Owner = this;
			formEditComment.ShowDialog();
		}
	}
}
