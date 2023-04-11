using ISpan.Inseparable.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Inseparable.Win
{
	public class CommentUpdateVm
	{
		public int ArticleID { get; set; }
		public int ItemNumber { get; set; }
		public int MemberID { get; set; }
		public DateTime PostingDate { get; set; }
		public int Likes { get; set; }

		[Required(ErrorMessage = "必填")]
		public string Content { get; set; }
		}
	public static class CommentUpdateVmExtension
	{
		public static CommentUpdateDto UpdateVmToDto(this CommentUpdateVm vm)
		{
			return new CommentUpdateDto()
			{
				ArticleID = vm.ArticleID,
				ItemNumber = vm.ItemNumber,
				Content = vm.Content,
			};
		}
	}

}
