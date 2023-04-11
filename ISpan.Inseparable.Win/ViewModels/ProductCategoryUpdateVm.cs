using ISpan.Inseparable.BLL.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ISpan.Inseparable.Win.ViewModels
{
	public class ProductCategoryUpdateVm
	{
		public int ProductCategoryID { get; set; }

		[Display(Name = "類別名稱")]
		[Required(ErrorMessage = "{0}必填")]
		[StringLength(50, ErrorMessage = "{0}長度不得超過{1}")]
		public string ProductCategoryName { get; set; }
	}

	public static class ProductCategoryUpdateVmExtenion
	{
		public static ProductCategoryUpdateDto ToUpdateDto(this ProductCategoryUpdateVm vm)
		{
			return new ProductCategoryUpdateDto()
			{
				ProductCategoryID = vm.ProductCategoryID,
				ProductCategoryName = vm.ProductCategoryName,
			};
		}
	}
}
