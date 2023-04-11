using ISpan.Inseparable.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Inseparable.Win
{
	public class KeywordUpdateVm
	{
		public int KeywordID { get; set; }

		[Required(ErrorMessage = "必填")]
		public string Name { get; set; }

	}
	public static class KeywordUpdateVmExtension
	{
		public static KeywordUpdateDto UpdateVmToDto(this KeywordUpdateVm vm)
		{
			return new KeywordUpdateDto()
			{
				KeywordID = vm.KeywordID,
				Name = vm.Name,
			};
		}
	}

}
