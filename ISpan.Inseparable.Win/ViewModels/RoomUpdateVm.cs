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
	public class RoomUpdateVm
	{
		public int RoomID { get; set; }

		[Display(Name = "影城")]
		[Required(ErrorMessage = "{0}必填")]
		public int CinemaID { get; set; }

		[Display(Name = "影廳名稱")]
		[Required(ErrorMessage = "{0}必填")]
		public string RoomName { get; set; }
	}

	public static class RoomUpdateVmExtension
	{
		public static RoomUpdateDto ToUpdateDto(this RoomUpdateVm vm)
		{
			return new RoomUpdateDto
			{
				RoomID=vm.RoomID,
				CinemaID=vm.CinemaID,
				RoomName=vm.RoomName,
			};
		}
	}
}
