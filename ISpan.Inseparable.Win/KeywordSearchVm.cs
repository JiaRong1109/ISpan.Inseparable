using ISpan.Inseparable.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Inseparable.Win
{
	public class KeywordSearchVm
	{
		public int 文章類別ID { get; set; }
		public string 文章類別名稱 { get; set; }
	}
	public static class KeywordSearchVmExtension
	{
		public static KeywordSearchVm SearchDtoToVm(this KeywordSearchDto dto)
		{
			return new KeywordSearchVm()
			{
				文章類別ID = dto.KeywordID,
				文章類別名稱 = dto.Name,
			};
		}
		public static IEnumerable<KeywordSearchVm> SearchDtosToVms(this IEnumerable<KeywordSearchDto> dtos)
		{
			List<KeywordSearchVm> Vms = new List<KeywordSearchVm>();

			foreach (var dto in dtos)
			{
				Vms.Add(dto.SearchDtoToVm());
			}
			return Vms;
		}
	}
}
