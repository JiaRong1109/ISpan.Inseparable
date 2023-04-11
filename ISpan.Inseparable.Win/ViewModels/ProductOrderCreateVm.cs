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
	public class ProductOrderCreateVm
	{
		public int ProductItem_no { get; set; }
		public int OrderID { get; set; }
		[Display(Name = "產品")]
		[Required(ErrorMessage = "{0}必填")]
		public int ProductID { get; set; }

		[Display(Name = "產品")]
		[Required(ErrorMessage = "{0}必填")]
		public string ProductName { get; set; }
		public int ProductUnitprice { get; set; }

		[Display(Name = "數量")]
		[Required(ErrorMessage = "{0}必填")]
		public int ProductQty { get; set; }
		public decimal ProductDiscount { get; set; }
		public int ProductSubtotal { get; set; }
	}
	public static class ProductOrderCreateVmExtension {
		public static ProductOrderCreateDto ToCreateDto(this ProductOrderCreateVm vm)
		{
			return new ProductOrderCreateDto()
			{
				ProductItem_no = vm.ProductItem_no,
				OrderID = vm.OrderID,
				ProductID = vm.ProductID,
				ProductName = vm.ProductName,
				ProductUnitprice = vm.ProductUnitprice,
				ProductQty = vm.ProductQty,
				ProductDiscount = vm.ProductDiscount,
				ProductSubtotal = vm.ProductSubtotal,

			};
		}
	}

}
