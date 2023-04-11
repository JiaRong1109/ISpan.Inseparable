using ISpan.Inseparable.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Inseparable.Win
{
	public class MovieCategorySearchVm
	{
		public int 電影類別ID { get; set; }
		public string 電影類別名稱 { get; set; }
	}
	public static class MovieCategorySearchVmExtension
	{
		public static MovieCategorySearchVm SearchDtoToVm(this MovieCategorySearchDto dto)
		{
			return new MovieCategorySearchVm()
			{
				電影類別ID = dto.MovieCategoryID,
				電影類別名稱 = dto.Name,
			};
		}
		public static IEnumerable<MovieCategorySearchVm> SearchDtosToVms(this IEnumerable<MovieCategorySearchDto> dtos)
		{
			List<MovieCategorySearchVm> Vms = new List<MovieCategorySearchVm>();

			foreach (var dto in dtos)
			{
				Vms.Add(dto.SearchDtoToVm());
			}
			return Vms;
		}
	}
}
