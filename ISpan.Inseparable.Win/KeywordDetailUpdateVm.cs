using ISpan.Inseparable.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Inseparable.Win
{
	public class KeywordDetailUpdateVm
	{
		public int ArticleID { get; set; }
		public int KeywordID { get; set; }
	}
	public static class KeywordDetailUpdateVmExtension
	{
		public static KeywordDetailUpdateDto UpdateVmToDto(this KeywordDetailUpdateVm vm)
		{
			return new KeywordDetailUpdateDto()
			{
				ArticleID = vm.ArticleID,
				KeywordID = vm.KeywordID,
			};
		}
	}

}
