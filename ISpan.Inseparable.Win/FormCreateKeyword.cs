﻿using ISpan.Inseparable.BLL;
using ISpan.Inseparable.BLL.Interface;
using ISpan.Inseparable.SqlDataLayer;
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
	public partial class FormCreateKeyword : Form
	{
		public FormCreateKeyword()
		{
			InitializeComponent();
		}

		private KeywordCreateVm GetModel()
		=> new KeywordCreateVm
		{
			Name = textBoxKeywordName.Text,
		};

		private (bool isValid, List<ValidationResult> errors) Validate(KeywordCreateVm vm)
		{
			// 得知要驗證規則
			ValidationContext context = new ValidationContext(vm, null, null);

			// 用來存放錯誤的集合,因為可能有零到多個錯誤
			List<ValidationResult> errors = new List<ValidationResult>();

			// 驗證 model
			bool validateAllProperties = true; // 是否驗證所有規則,而非只驗證Required規則
			bool isValid = Validator.TryValidateObject(vm, context, errors, validateAllProperties);

			isValid = errors.Count == 0;

			return (isValid, errors);
		}

		private void DisplayErrors(List<ValidationResult> errors)
		{
			// 大小寫不同仍視為相同的key
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Name", textBoxKeywordName},
			};

			this.errorProvider1.Clear();

			foreach (ValidationResult error in errors)
			{
				string propName = error.MemberNames.FirstOrDefault();
				if (map.TryGetValue(propName, out Control ctrl))
				{
					this.errorProvider1.SetError(ctrl, error.ErrorMessage);
				}
			}
		}

		private void buttonCreate_Click(object sender, EventArgs e)
		{
			// 繫結表單控制項到 KeywordCreateVm
			var vm = GetModel();

			// 針對view model 進行欄位驗證, 如果有錯誤就顯示錯誤訊息
			(bool isValid, List<ValidationResult> errors) validationResult = Validate(vm);

			if (validationResult.isValid == false)
			{
				this.errorProvider1.Clear();
				DisplayErrors(validationResult.errors);
				return;
			}

			// 如果通過驗證,轉型為KeywordCreateDto
			var dto = vm.CreateVmToDto();

			// 傳給 KeywordService
			IKeywordRepository repo = new KeywordRepository();
			KeywordService service = new KeywordService(repo);

			try
			{
				service.Create(dto);
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗\r\n" + ex.Message);
			}

			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();

			this.DialogResult = DialogResult.OK;
		}
	}
}
