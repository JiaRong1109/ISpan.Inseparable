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
	public class TicketOrderUpdateVm
	{
		public int TicketItem_no { get; set; }
		public int OrderID { get; set; }

		[Display(Name = "電影")]
		[Required(ErrorMessage = "{0}必填")]
		public int MovieID { get; set; }

		[Display(Name = "場次")]
		[Required(ErrorMessage = "{0}必填")]
		public int SessionID { get; set; }

		[Display(Name = "座位")]
		[Required(ErrorMessage = "{0}必填")]
		public int SeatID { get; set; }

		[Display(Name = "影廳")]
		[Required(ErrorMessage = "{0}必填")]
		public int RoomID { get; set; }
		public int TicketUnitprice { get; set; }
		public decimal TicketDiscount { get; set; }
		public int TicketSubtotal { get; set; }
	}

	public static class TicketOrderUpdateVmExtension
	{
		public static TicketOrderUpdateDto ToUpdateDto(this TicketOrderUpdateVm vm)
		{
			return new TicketOrderUpdateDto()
			{
				TicketItem_no=vm.TicketItem_no,
				OrderID=vm.OrderID,
				MovieID=vm.MovieID,
				SessionID=vm.SessionID,
				SeatID=vm.SeatID,
				RoomID = vm.RoomID,
				TicketDiscount =vm.TicketDiscount,
				TicketUnitprice=vm.TicketUnitprice,
				TicketSubtotal=vm.TicketSubtotal,
			};
		}
	}
}
