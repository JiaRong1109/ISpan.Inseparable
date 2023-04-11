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
	public class CinemaUpdateVm
	{
		public int CinemaID { get; set; }

		[Display(Name = "影城名稱")]
		[Required(ErrorMessage = "{0}必填")]
		[StringLength(50, ErrorMessage = "{0}長度不能超過{1}")]
		public string CinemaName { get; set; }

		[Display(Name = "地區")]
		[Required(ErrorMessage = "{0}必填")]
		[StringLength(50, ErrorMessage = "{0}長度不能超過{1}")]
		public string CinemaRegion { get; set; }

		[Display(Name = "地址")]
		[Required(ErrorMessage = "{0}必填")]
		[StringLength(200, ErrorMessage = "{0}長度不能超過{1}")]
		public string CinemaAddress { get; set; }

		[Display(Name = "電話")]
		[Required(ErrorMessage = "{0}必填")]
		[StringLength(50, ErrorMessage = "{0}長度不能超過{1}")]
		public string CinemaTel { get; set; }
	}

	public static class CinemaUpdateVmExtension
	{
		public static CinemaUpdateDto ToUpdateDto(this CinemaUpdateVm vm)
		{
			return new CinemaUpdateDto
			{
				CinemaID = vm.CinemaID,
				CinemaName = vm.CinemaName,
				CinemaRegion = vm.CinemaRegion,
				CinemaAddress = vm.CinemaAddress,
				CinemaTel = vm.CinemaTel,
			};
		}
	}
}
