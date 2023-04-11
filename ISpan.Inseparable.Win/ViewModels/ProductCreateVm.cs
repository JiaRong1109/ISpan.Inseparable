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
	public class ProductCreateVm
	{
		//簡單驗證
		public int ProductId { get; set; }

		[Display(Name = "產品名稱")]
		[Required(ErrorMessage = "{0}必填")]
		[StringLength(50, ErrorMessage = "{0}長度不可超過{1}")]
		public string ProductName { get; set; }

		[Display(Name = "產品類別")]
		[Required(ErrorMessage = "{0}必填")]
		public int? ProductCategoryId { get; set; }

		[Display(Name = "單價")]
		[Required(ErrorMessage = "{0}必填")]
		[Range(1, int.MaxValue, ErrorMessage = "{0}必須大於0")]
		public int? ProductUnitprice { get; set; }

		[Display(Name = "庫存")]
		[Required(ErrorMessage = "{0}必填")]
		[Range(1, int.MaxValue, ErrorMessage ="{0}必須大於0")]
		public int? ProductStock { get; set; }

		[Display(Name = "圖片")]
		public byte[] ProductPicture { get; set; }

		[Display(Name = "影院")]
		[Required(ErrorMessage = "{0}必填")]
		public int? CinemaID { get; set; }
	}

	public static class ProductCreateVmEXtension
	{
		public static ProductCreateDto ToCreateDto(this ProductCreateVm source)
		{
			return new ProductCreateDto
			{
				ProductId = source.ProductId,
				ProductName = source.ProductName,
				ProductCategoryId = source.ProductCategoryId,
				ProductUnitprice = source.ProductUnitprice,
				ProductStock = source.ProductStock,
				ProductPicture = source.ProductPicture,
				CinemaID = source.CinemaID,
			};
		}
	}
}
