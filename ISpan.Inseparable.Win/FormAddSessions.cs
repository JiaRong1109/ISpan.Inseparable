using ISpan.Inseparable.BLL;
using ISpan.Inseparable.BLL.Interface;
using ISpan.Inseparable.SqlDataLayer;
using ISpan.Inseparable.Win.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.Inseparable.Win
{
	public partial class FormAddSessions : Form
	{
		InseparableEntities InseparableDb = new InseparableEntities();
		Sessions sessions= new Sessions();
		SessionRepository repo;

		private int? movieId =>comboBoxMovie.SelectedIndex>0? InseparableDb.Movies.First(m=>m.MovieName==comboBoxMovie.Text).MovieID:(int?)null;
		private int? cinemaId => comboBoxCinema.SelectedIndex > 0 ? InseparableDb.Cinemas.First(c => c.CinemaName == comboBoxCinema.Text).CinemaID : (int?)null; 
		private int? roomId => comboBoxRoom.SelectedIndex>0? InseparableDb.Rooms.Where(r=>r.CinemaID==cinemaId).First(r=>r.RoomName==comboBoxRoom.Text).RoomID:(int?)null;
		private int? price => int.TryParse(textBoxPrice.Text, out int price) ? price : (int?)null;

		public FormAddSessions()
		{
			InitializeComponent();
			repo = new SessionRepository();
			this.Load += FormAddSessions_Load;
		}

		private void FormAddSessions_Load(object sender, EventArgs e)
		{
			foreach(var item in InseparableDb.Movies) { comboBoxMovie.Items.Add(item.MovieName); }
			comboBoxMovie.SelectedIndex=0;
			foreach (var item in InseparableDb.Cinemas) { comboBoxCinema.Items.Add(item.CinemaName); }
			comboBoxCinema.SelectedIndex=0;
		}
		private void comboBoxCinema_SelectedIndexChanged(object sender, EventArgs e)
		{
			var room = InseparableDb.Rooms.Where(r => r.CinemaID == cinemaId);
			comboBoxRoom.Items.Clear();
			comboBoxRoom.Items.Add("--請選擇--");
			foreach (var item in room)
			{
				comboBoxRoom.Items.Add(item.RoomName);
			}
			comboBoxRoom.SelectedIndex = 0;
		}
		public SessionCreateVm GetModel()
			=> new SessionCreateVm
			{
				MovieId = this.movieId,
				RoomId = this.roomId,
				CinemaID = this.cinemaId,
				SessionDate = DateTime.Parse(dateTimePickerDate.Value.ToShortDateString()),
				SessionTime = dateTimePickerTime.Value.TimeOfDay,
				TicketPrice = price
			};
		private (bool isValid, List<ValidationResult> errors) Validate(SessionCreateVm vm)
		{
			// 得知要驗證規則
			ValidationContext context = new ValidationContext(vm, null, null);

			// 用來存放錯誤的集合,因為可能有零到多個錯誤
			List<ValidationResult> errors = new List<ValidationResult>();

			// 驗證 model
			bool validateAllProperties = true; // 是否驗證所有規則,而非只驗證Required規則
			bool isValid = Validator.TryValidateObject(vm, context, errors, validateAllProperties);

			return (isValid, errors);
		}
		private void DisplayErrors(List<ValidationResult> errors)
		{
			// 大小寫不同仍視為相同的key
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"MovieId", comboBoxMovie},
				{"RoomId", comboBoxRoom},
				{"CinemaID", comboBoxCinema},
				{"SessionDate", dateTimePickerDate},
				{"SessionTime", dateTimePickerTime},
				{"TicketPrice",textBoxPrice},

			};

			this.errorProvider1.Clear();

			foreach (ValidationResult error in errors)
			{
				string propName = error.MemberNames.FirstOrDefault();
				if (propName != null && map.TryGetValue(propName, out Control ctrl))
				{
					this.errorProvider1.SetError(ctrl, error.ErrorMessage);
				}
			}
		}
		private void buttonAdd_Click(object sender, EventArgs e)
		{
			var vm = GetModel();

			// 針對view model 進行欄位驗證, 如果有錯誤就顯示錯誤訊息
			(bool isValid, List<ValidationResult> errors) validationResult = Validate(vm);

			if (validationResult.isValid == false)
			{
				this.errorProvider1.Clear();
				DisplayErrors(validationResult.errors);
				return;
			}

			// 如果通過驗證,轉型為CreateDto
			var dto = vm.ToCreateDto();

			//傳給Service
			ISessionRepository repo =new SessionRepository();
			SessionService service = new SessionService(repo);

			try
			{
				service.Create(dto);
			}
			catch(Exception ex) { MessageBox.Show("新增失敗~~"+ex.Message); }

			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();
			this.DialogResult = DialogResult.OK;
		}
	}
}
