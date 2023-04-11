using ISpan.Inseparable.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Inseparable.Win
{
	public class MovieCategoryDetailSearchVm
	{
		public int 電影ID { get; set; }
		public int 電影類別ID { get; set; }
	}
	public static class MovieCategoryDetailSearchVmExtension
	{
		public static MovieCategoryDetailSearchVm SearchDtoToVm(this MovieCategoryDetailSearchDto dto)
		{
			return new MovieCategoryDetailSearchVm()
			{
				電影ID = dto.MovieID,
				電影類別ID = dto.MovieCategoryID,
			};
		}
		public static IEnumerable<MovieCategoryDetailSearchVm> SearchDtosToVms(this IEnumerable<MovieCategoryDetailSearchDto> dtos)
		{
			List<MovieCategoryDetailSearchVm> Vms = new List<MovieCategoryDetailSearchVm>();

			foreach (var dto in dtos)
			{
				Vms.Add(dto.SearchDtoToVm());
			}
			return Vms;
		}
	}

}
