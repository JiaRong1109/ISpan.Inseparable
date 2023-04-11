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
	public class SessionUpdateVm
	{
		public int SessionId { get; set; }

		[Display(Name = "電影")]
		[Required(ErrorMessage = "{0}必填")]
		public int? MovieId { get; set; }

		[Display(Name = "影廳")]
		[Required(ErrorMessage = "{0}必填")]
		public int? RoomId { get; set; }

		[Display(Name = "影城")]
		[Required(ErrorMessage = "{0}必填")]
		public int? CinemaID { get; set; }

		[Display(Name = "日期")]
		[Required(ErrorMessage = "{0}必填")]
		[DataType(DataType.Date, ErrorMessage = "{0}必須是合法格式")]
		public System.DateTime SessionDate { get; set; }

		[Display(Name = "時間")]
		[Required(ErrorMessage = "{0}必填")]
		[DataType(DataType.Time, ErrorMessage = "{0}必須是合法格式")]
		public System.TimeSpan SessionTime { get; set; }

		[Display(Name = "票價")]
		[Required(ErrorMessage = "{0}必填")]
		[Range(1, int.MaxValue, ErrorMessage = "{0}必須大於零")]
		public int? TicketPrice { get; set; }
	}

	public static class SessionUpdateVmExtension
	{
		public static SessionUpdateDto ToUpdateDto(this SessionUpdateVm vm)
		{
			return new SessionUpdateDto
			{
				SessionId = vm.SessionId,
				RoomId = vm.RoomId,
				CinemaID = vm.CinemaID,
				SessionDate = vm.SessionDate,
				SessionTime = vm.SessionTime,
				TicketPrice = vm.TicketPrice,
				MovieId = vm.MovieId,
			};
		}
	}
}
