namespace ISpan.Inseparable.Win
{
	partial class FormEditSessions
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.labelTime = new System.Windows.Forms.Label();
			this.labelDate = new System.Windows.Forms.Label();
			this.comboBoxRoom = new System.Windows.Forms.ComboBox();
			this.labelRoom = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label = new System.Windows.Forms.Label();
			this.labelID = new System.Windows.Forms.Label();
			this.labelSessionID = new System.Windows.Forms.Label();
			this.labelMovie = new System.Windows.Forms.Label();
			this.labelCinema = new System.Windows.Forms.Label();
			this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonEdit
			// 
			this.buttonEdit.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonEdit.Location = new System.Drawing.Point(165, 220);
			this.buttonEdit.Margin = new System.Windows.Forms.Padding(2);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(54, 34);
			this.buttonEdit.TabIndex = 3;
			this.buttonEdit.Text = "更新";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// labelTime
			// 
			this.labelTime.AutoSize = true;
			this.labelTime.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelTime.Location = new System.Drawing.Point(22, 158);
			this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(54, 19);
			this.labelTime.TabIndex = 5;
			this.labelTime.Text = "時間：";
			// 
			// labelDate
			// 
			this.labelDate.AutoSize = true;
			this.labelDate.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelDate.Location = new System.Drawing.Point(22, 129);
			this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelDate.Name = "labelDate";
			this.labelDate.Size = new System.Drawing.Size(54, 19);
			this.labelDate.TabIndex = 6;
			this.labelDate.Text = "日期：";
			// 
			// comboBoxRoom
			// 
			this.comboBoxRoom.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxRoom.FormattingEnabled = true;
			this.comboBoxRoom.Location = new System.Drawing.Point(91, 100);
			this.comboBoxRoom.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxRoom.Name = "comboBoxRoom";
			this.comboBoxRoom.Size = new System.Drawing.Size(128, 27);
			this.comboBoxRoom.TabIndex = 0;
			// 
			// labelRoom
			// 
			this.labelRoom.AutoSize = true;
			this.labelRoom.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelRoom.Location = new System.Drawing.Point(22, 100);
			this.labelRoom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelRoom.Name = "labelRoom";
			this.labelRoom.Size = new System.Drawing.Size(54, 19);
			this.labelRoom.TabIndex = 7;
			this.labelRoom.Text = "影廳：";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(22, 74);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 19);
			this.label4.TabIndex = 8;
			this.label4.Text = "影城：";
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label.Location = new System.Drawing.Point(22, 48);
			this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(54, 19);
			this.label.TabIndex = 9;
			this.label.Text = "電影：";
			// 
			// labelID
			// 
			this.labelID.AutoSize = true;
			this.labelID.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelID.Location = new System.Drawing.Point(22, 25);
			this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(69, 19);
			this.labelID.TabIndex = 16;
			this.labelID.Text = "場次ID：";
			// 
			// labelSessionID
			// 
			this.labelSessionID.AutoSize = true;
			this.labelSessionID.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelSessionID.Location = new System.Drawing.Point(91, 25);
			this.labelSessionID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelSessionID.Name = "labelSessionID";
			this.labelSessionID.Size = new System.Drawing.Size(0, 19);
			this.labelSessionID.TabIndex = 17;
			// 
			// labelMovie
			// 
			this.labelMovie.AutoSize = true;
			this.labelMovie.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelMovie.Location = new System.Drawing.Point(91, 48);
			this.labelMovie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelMovie.Name = "labelMovie";
			this.labelMovie.Size = new System.Drawing.Size(0, 19);
			this.labelMovie.TabIndex = 18;
			// 
			// labelCinema
			// 
			this.labelCinema.AutoSize = true;
			this.labelCinema.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelCinema.Location = new System.Drawing.Point(91, 74);
			this.labelCinema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelCinema.Name = "labelCinema";
			this.labelCinema.Size = new System.Drawing.Size(0, 19);
			this.labelCinema.TabIndex = 19;
			// 
			// dateTimePickerTime
			// 
			this.dateTimePickerTime.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dateTimePickerTime.Location = new System.Drawing.Point(91, 158);
			this.dateTimePickerTime.Margin = new System.Windows.Forms.Padding(2);
			this.dateTimePickerTime.Name = "dateTimePickerTime";
			this.dateTimePickerTime.ShowUpDown = true;
			this.dateTimePickerTime.Size = new System.Drawing.Size(128, 27);
			this.dateTimePickerTime.TabIndex = 2;
			this.dateTimePickerTime.Value = new System.DateTime(2023, 1, 20, 0, 0, 0, 0);
			// 
			// dateTimePickerDate
			// 
			this.dateTimePickerDate.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dateTimePickerDate.Location = new System.Drawing.Point(91, 129);
			this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(2);
			this.dateTimePickerDate.Name = "dateTimePickerDate";
			this.dateTimePickerDate.Size = new System.Drawing.Size(128, 27);
			this.dateTimePickerDate.TabIndex = 1;
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Location = new System.Drawing.Point(91, 190);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.Size = new System.Drawing.Size(128, 25);
			this.textBoxPrice.TabIndex = 21;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(21, 188);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 19);
			this.label1.TabIndex = 20;
			this.label1.Text = "票價：";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FormEditSessions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(279, 283);
			this.Controls.Add(this.textBoxPrice);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateTimePickerTime);
			this.Controls.Add(this.dateTimePickerDate);
			this.Controls.Add(this.labelCinema);
			this.Controls.Add(this.labelMovie);
			this.Controls.Add(this.labelSessionID);
			this.Controls.Add(this.labelID);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.labelTime);
			this.Controls.Add(this.labelDate);
			this.Controls.Add(this.comboBoxRoom);
			this.Controls.Add(this.labelRoom);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormEditSessions";
			this.Text = "場次修改";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Label labelTime;
		private System.Windows.Forms.Label labelDate;
		private System.Windows.Forms.ComboBox comboBoxRoom;
		private System.Windows.Forms.Label labelRoom;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Label labelID;
		private System.Windows.Forms.Label labelSessionID;
		private System.Windows.Forms.Label labelMovie;
		private System.Windows.Forms.Label labelCinema;
		private System.Windows.Forms.DateTimePicker dateTimePickerTime;
		private System.Windows.Forms.DateTimePicker dateTimePickerDate;
		private System.Windows.Forms.TextBox textBoxPrice;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}