using ISpan.Inseparable.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Inseparable.Win
{
	public class KeywordDetailSearchVm
	{
		public int 文章ID { get; set; }
		public int 文章類別ID { get; set; }
	}
	public static class KeywordDetailSearchVmExtension
	{
		public static KeywordDetailSearchVm SearchDtoToVm(this KeywordDetailSearchDto dto)
		{
			return new KeywordDetailSearchVm()
			{
				文章ID = dto.ArticleID,
				文章類別ID = dto.KeywordID,
			};
		}
		public static IEnumerable<KeywordDetailSearchVm> SearchDtosToVms(this IEnumerable<KeywordDetailSearchDto> dtos)
		{
			List<KeywordDetailSearchVm> Vms = new List<KeywordDetailSearchVm>();

			foreach (var dto in dtos)
			{
				Vms.Add(dto.SearchDtoToVm());
			}
			return Vms;
		}
	}

}
