using ISpan.Inseparable.BLL.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Inseparable.Win.ViewModels
{
	public class RoomCreateVm
	{
		public int RoomID { get; set; }

		[Display(Name ="影城")]
		[Required (ErrorMessage ="{0}必填")]
		public int CinemaID { get; set; }

		[Display(Name = "影廳名稱")]
		[Required(ErrorMessage = "{0}必填")]
		public string RoomName { get; set; }
	}

	public static class RoomCreateVmExtension
	{
		public static RoomCreateDto ToCreateDto(this RoomCreateVm vm)
		{
			return new RoomCreateDto()
			{
				RoomID = vm.RoomID,
				CinemaID = vm.CinemaID,
				RoomName = vm.RoomName,
			};
		}
	}
}
