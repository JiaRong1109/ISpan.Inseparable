using ISpan.Inseparable.BLL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Inseparable.Win.ViewModels
{
	public class SeatCreateVm
	{
		public int SeatID { get; set; }
		public int RoomID { get; set; }
		public string SeatRow { get; set; }
		public int SeatColumn { get; set; }
	}

	public static class SeatCreateVmExtension
	{
		public static SeatCreateDto ToCreateDto(this SeatCreateVm vm)
		{
			return new SeatCreateDto()
			{
				SeatID = vm.SeatID,
				RoomID = vm.RoomID,
				SeatRow = vm.SeatRow,
				SeatColumn = vm.SeatColumn,
			};
		}
	}
}
