using ISpan.Inseparable.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Inseparable.Win
{
	public class MovieUpdateVm
	{
		public int MovieID { get; set; }

		[Required(ErrorMessage = "必填")]
		public string Name { get; set; }
		public string Introduction { get; set; }
		public int LevelID { get; set; }
		public DateTime OnDate { get; set; }
		public DateTime OffDate { get; set; }
		public int Length { get; set; }
		public byte[] Picture { get; set; }
	}
	public static class MovieUpdateVmExtension
	{
		public static MovieUpdateDto UpdateVmToDto(this MovieUpdateVm vm)
		{
			return new MovieUpdateDto()
			{
				MovieID = vm.MovieID,
				Name = vm.Name,
				Introduction = vm.Introduction,
				LevelID = vm.LevelID,
				OnDate = vm.OnDate,
				OffDate = vm.OffDate,
				Length = vm.Length,
				Picture = vm.Picture,
			};
		}
	}

}
