using ISpan.Inseparable.BLL.Dtos;
using ISpan.Inseparable.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Inseparable.Win.ViewModels
{
	public class OrderCreateVm
	{
		public int OrderID { get; set; }
		[Display (Name ="客戶")]
		[Required (ErrorMessage ="{0}必填")]
		public int MemberID { get; set; }

		[Display(Name = "影城")]
		[Required(ErrorMessage = "{0}必填")]
		public int CinemaID { get; set; }

		
		public System.DateTime OrderDate { get; set; }

		public System.DateTime ModifiedTime { get; set; }

		public int TotalMoney { get; set; }
	}
	public static class OrderCreateVmExtension
	{
		public static OrderCreateDto ToCreateDto(this OrderCreateVm vm)
		{
			return new OrderCreateDto()
			{
				OrderID = vm.OrderID,
				MemberID = vm.MemberID,
				CinemaID = vm.CinemaID,
				OrderDate = vm.OrderDate,
				ModifiedTime = vm.ModifiedTime,
				TotalMoney = vm.TotalMoney,
			};
		}
	}
}
