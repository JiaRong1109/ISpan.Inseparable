using ISpan.Inseparable.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Inseparable.Win
{
	public class KeywordDetailCreateVm
	{
		public int ArticleID { get; set; }
		public int KeywordID { get; set; }
	}
	public static class KeywordDetailCreateVmExtension
	{
		public static KeywordDetailCreateDto CreateVmToDto(this KeywordDetailCreateVm vm)
		{
			return new KeywordDetailCreateDto()
			{
				ArticleID = vm.ArticleID,
				KeywordID = vm.KeywordID,
			};
		}
	}

}
