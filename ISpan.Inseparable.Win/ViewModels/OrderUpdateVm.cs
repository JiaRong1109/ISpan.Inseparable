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
	public class OrderUpdateVm
	{
		public int OrderID { get; set; }

		public int MemberID { get; set; }

		[Display(Name = "影城")]
		[Required(ErrorMessage = "{0}必填")]
		public int CinemaID { get; set; }
		public System.DateTime OrderDate { get; set; }
		public System.DateTime ModifiedTime { get; set; }
		public int TotalMoney { get; set; }
	}
	public static class OrderUpdateVmExtension
	{
		public static OrderUpdateDto ToUpdateDto(this OrderUpdateVm vm)
		{
			return new OrderUpdateDto()
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
