using ISpan.Inseparable.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Inseparable.Win
{
	public class MovieCategoryUpdateVm
	{
		public int MovieCategoryID { get; set; }

		[Required(ErrorMessage = "必填")]
		public string Name { get; set; }

	}
	public static class MovieCategoryUpdateVmExtension
	{
		public static MovieCategoryUpdateDto UpdateVmToDto(this MovieCategoryUpdateVm vm)
		{
			return new MovieCategoryUpdateDto()
			{
				MovieCategoryID = vm.MovieCategoryID,
				Name = vm.Name,
			};
		}
	}

}
