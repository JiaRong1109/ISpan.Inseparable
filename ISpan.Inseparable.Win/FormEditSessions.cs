using ISpan.Inseparable.BLL;
using ISpan.Inseparable.BLL.Interface;
using ISpan.Inseparable.SqlDataLayer;
using ISpan.Inseparable.Win.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.Inseparable.Win
{
	public partial class FormEditSessions : Form
	{
		InseparableEntities InseparableDb = new InseparableEntities();
		SessionRepository repo;

		private readonly int sessionId;
		
		private int? price => int.TryParse(textBoxPrice.Text, out int price) ? price : (int?)null;
		private int? cinemaId => string.IsNullOrEmpty(labelCinema.Text) ? (int?)null : InseparableDb.Cinemas.First(c => c.CinemaName == labelCinema.Text).CinemaID;
		private int? movieId => string.IsNullOrEmpty(labelMovie.Text) ? (int?)null : InseparableDb.Movies.First(m => m.MovieName ==labelMovie.Text).MovieID;
			private int? roomId => comboBoxRoom.SelectedIndex >= 0 ? InseparableDb.Rooms.Where(r=>r.CinemaID==cinemaId).First(r => r.RoomName == comboBoxRoom.Text).RoomID : (int?)null;
		public FormEditSessions(int sessionId)
		{
			InitializeComponent();
			repo = new SessionRepository();

			this.sessionId = sessionId;
			this.Load += FormEditSessions_Load;
		}

		private void FormEditSessions_Load(object sender, EventArgs e)
		{
			
			int cinemaId = InseparableDb.Sessions.First(s => s.SessionId == sessionId).CinemaID;
			var room = InseparableDb.Rooms.Where(r => r.CinemaID == cinemaId);
			foreach (var item in room) { comboBoxRoom.Items.Add(item.RoomName); }

			var get = repo.GetSession(sessionId);

			BindForm(get);
		}

		private void BindForm(Sessions get)
		{
			DateTime dt = DateTime.Parse("2022-12-12");
			labelID.Text = get.SessionId.ToString();
			labelMovie.Text = get.Movies.MovieName;
			labelCinema.Text = get.Cinemas.CinemaName;
			dateTimePickerDate.Value = get.SessionDate;
			dateTimePickerTime.Value = dt.Add(get.SessionTime);
			textBoxPrice.Text = get.TicketPrice.ToString();

			int index = comboBoxRoom.Items.IndexOf(get.Rooms.RoomName);
			comboBoxRoom.SelectedIndex = index;
		}
		public SessionUpdateVm GetModel()
			=> new SessionUpdateVm
			{
				SessionId =this.sessionId,
				SessionDate = DateTime.Parse(dateTimePickerDate.Value.ToShortDateString()),
				SessionTime = dateTimePickerTime.Value.TimeOfDay,
				RoomId = this.roomId,
				TicketPrice =price,
				MovieId=this.movieId,
				CinemaID=cinemaId
			};

		private (bool isValid, List<ValidationResult> errors) Validate(SessionUpdateVm vm)
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
				{"RoomId", comboBoxRoom},
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
		private void buttonEdit_Click(object sender, EventArgs e)
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
			var dto = vm.ToUpdateDto();

			//傳給Service
			ISessionRepository repo = new SessionRepository();
			SessionService service = new SessionService(repo);

			try
			{
				service.Update(dto);
			}
			catch(Exception ex) { MessageBox.Show("更新失敗ㄟ~~"+ex.Message); }

			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();
			this.DialogResult= DialogResult.OK;
		}
	}
}
