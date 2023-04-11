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
	public partial class FormEditRooms : Form
	{
		InseparableEntities InseparableDb = new InseparableEntities();
		RoomRepository repo;

		private readonly int roomId;
		private int? cinemaid => string.IsNullOrEmpty(labelCinema.Text) ? (int?)null : InseparableDb.Cinemas.Single(c => c.CinemaName == labelCinema.Text).CinemaID;
		public FormEditRooms(int roomId)
		{
			InitializeComponent();
			repo = new RoomRepository();

			this.roomId = roomId;
			this.Load += FormEditRooms_Load;
		}

		public RoomUpdateVm GetModel()
			=> new RoomUpdateVm
			{
				RoomID=roomId,
				CinemaID =(int)cinemaid,
				RoomName=textBoxRoom.Text
			};
		private void FormEditRooms_Load(object sender, EventArgs e)
		{
			var get = repo.GetRoom(roomId);

			BindForm(get);
		}

		private void BindForm(Rooms get)
		{
			labelRoomID.Text = get.RoomID.ToString();
			labelCinema.Text = get.Cinemas.CinemaName;
			textBoxRoom.Text = get.RoomName;
		}
		private (bool isValid, List<ValidationResult> errors) Validate(RoomUpdateVm vm)
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
				{"RoomName", textBoxRoom},

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
			IRoomRepository repo = new RoomRepository();
			RoomService service = new RoomService(repo);
			try
			{
				service.Update(dto);
			}catch(Exception ex) { MessageBox.Show("更新失敗!!"+ex.Message); }


			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();

			this.DialogResult= DialogResult.OK;
		}
	}
}
