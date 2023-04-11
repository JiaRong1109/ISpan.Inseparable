using ISpan.Inseparable.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Inseparable.Win
{
	public class CommentCreateVm
	{
		[Required(ErrorMessage = "必填")]
		public int? ArticleID { get; set; }
		public int ItemNumber { get; set; }

		[Required(ErrorMessage = "必填")]
		public int? MemberID { get; set; }
		public DateTime PostingDate { get; set; }
		public int Likes { get; set; }

		[Required(ErrorMessage = "必填")]
		public string Content { get; set; }
	}
	public static class CommentCreateVmExtension
	{
		public static CommentCreateDto CreateVmToDto(this CommentCreateVm vm)
		{
			return new CommentCreateDto()
			{
				ArticleID = (int)vm.ArticleID,
				ItemNumber = vm.ItemNumber,
				MemberID = (int)vm.MemberID,
				PostingDate = vm.PostingDate,
				Likes = vm.Likes,
				Content = vm.Content
			};
		}
	}

}
