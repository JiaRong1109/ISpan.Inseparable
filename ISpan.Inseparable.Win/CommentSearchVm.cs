using ISpan.Inseparable.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Inseparable.Win
{
	public class CommentSearchVm
	{
		public int 文章ID { get; set; }
		public int 項次 { get; set; }
		public int 會員ID { get; set; }
		public DateTime 留言時間 { get; set; }
		public int 點讚數 { get; set; }
		public string 留言內容 { get; set; }
	}
	public static class CommentSearchVmExtension
	{
		public static CommentSearchVm SearchDtoToVm(this CommentSearchDto dto)
		{
			return new CommentSearchVm()
			{
				文章ID = dto.ArticleID,
				項次 = dto.ItemNumber,
				會員ID = dto.MemberID,
				留言時間 = dto.PostingDate,
				點讚數 = dto.Likes,
				留言內容 = dto.Content
			};
		}
		public static IEnumerable<CommentSearchVm> SearchDtosToVms(this IEnumerable<CommentSearchDto> dtos)
		{
			List<CommentSearchVm> Vms = new List<CommentSearchVm>();

			foreach (var dto in dtos)
			{
				Vms.Add(dto.SearchDtoToVm());
			}
			return Vms;
		}
	}
}
