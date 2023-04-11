using ISpan.Inseparable.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Inseparable.Win
{
	public class MovieCategoryCreateVm
	{
		[Required(ErrorMessage = "必填")]
		public string Name { get; set; }

	}
	public static class MovieCategoryCreateVmExtension
	{
		public static MovieCategoryCreateDto CreateVmToDto(this MovieCategoryCreateVm vm)
		{
			return new MovieCategoryCreateDto()
			{
				Name = vm.Name,
			};
		}
	}

}
