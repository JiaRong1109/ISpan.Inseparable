using ISpan.Inseparable.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Inseparable.Win
{
	public class MovieCategoryDetailCreateVm
	{
		public int MovieID { get; set; }
		public int MovieCategoryID { get; set; }
	}
	public static class MovieCategoryDetailCreateVmExtension
	{
		public static MovieCategoryDetailCreateDto CreateVmToDto(this MovieCategoryDetailCreateVm vm)
		{
			return new MovieCategoryDetailCreateDto()
			{
				MovieID = vm.MovieID,
				MovieCategoryID = vm.MovieCategoryID,
			};
		}
	}

}
