using ISpan.Inseparable.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Inseparable.Win
{
	public class MovieCategoryDetailUpdateVm
	{
		public int MovieID { get; set; }
		public int MovieCategoryID { get; set; }
	}
	public static class MovieCategoryDetailUpdateVmExtension
	{
		public static MovieCategoryDetailUpdateDto UpdateVmToDto(this MovieCategoryDetailUpdateVm vm)
		{
			return new MovieCategoryDetailUpdateDto()
			{
				MovieID = vm.MovieID,
				MovieCategoryID = vm.MovieCategoryID,
			};
		}
	}

}
