using ISpan.Inseparable.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Inseparable.Win
{
	public class KeywordCreateVm
	{
		[Required(ErrorMessage = "必填")]
		public string Name { get; set; }

	}
	public static class KeywordCreateVmExtension
	{
		public static KeywordCreateDto CreateVmToDto(this KeywordCreateVm vm)
		{
			return new KeywordCreateDto()
			{
				Name = vm.Name,
			};
		}
	}

}
