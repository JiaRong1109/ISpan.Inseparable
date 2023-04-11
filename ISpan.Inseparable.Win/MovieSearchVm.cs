using ISpan.Inseparable.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Inseparable.Win
{
	public class MovieSearchVm
	{
		public int 電影ID { get; set; }
		public string 電影名稱 { get; set; }
		public string 電影介紹 { get; set; }
		public int 電影分級 { get; set; }
		public DateTime 上映時間 { get; set; }
		public DateTime 下映時間 { get; set; }
		public int 電影時長 { get; set; }
		public byte[] 宣傳照片 { get; set; }
	}
	public static class MovieSearchVmExtension
	{
		public static MovieSearchVm SearchDtoToVm(this MovieSearchDto dto)
		{
			return new MovieSearchVm()
			{
				電影ID = dto.MovieID,
				電影名稱 = dto.Name,
				電影介紹 = dto.Introduction,
				電影分級 = dto.LevelID,
				上映時間 = dto.OnDate,
				下映時間 = dto.OffDate,
				電影時長 = dto.Length,
				宣傳照片 = dto.Picture,
			};
		}
		public static IEnumerable<MovieSearchVm> SearchDtosToVms(this IEnumerable<MovieSearchDto> dtos)
		{
			List<MovieSearchVm> Vms = new List<MovieSearchVm>();

			foreach (var dto in dtos)
			{
				Vms.Add(dto.SearchDtoToVm());
			}
			return Vms;
		}
	}
}
