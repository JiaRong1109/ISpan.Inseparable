namespace ISpan.Inseparable.Win
{
	partial class FormAddSessions
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
			this.labelMovie = new System.Windows.Forms.Label();
			this.comboBoxMovie = new System.Windows.Forms.ComboBox();
			this.labelCinema = new System.Windows.Forms.Label();
			this.comboBoxCinema = new System.Windows.Forms.ComboBox();
			this.labelRoom = new System.Windows.Forms.Label();
			this.comboBoxRoom = new System.Windows.Forms.ComboBox();
			this.labelDate = new System.Windows.Forms.Label();
			this.labelTime = new System.Windows.Forms.Label();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// labelMovie
			// 
			this.labelMovie.AutoSize = true;
			this.labelMovie.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelMovie.Location = new System.Drawing.Point(18, 32);
			this.labelMovie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelMovie.Name = "labelMovie";
			this.labelMovie.Size = new System.Drawing.Size(54, 19);
			this.labelMovie.TabIndex = 0;
			this.labelMovie.Text = "電影：";
			// 
			// comboBoxMovie
			// 
			this.comboBoxMovie.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxMovie.FormattingEnabled = true;
			this.comboBoxMovie.Items.AddRange(new object[] {
            "--請選擇--"});
			this.comboBoxMovie.Location = new System.Drawing.Point(88, 32);
			this.comboBoxMovie.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxMovie.Name = "comboBoxMovie";
			this.comboBoxMovie.Size = new System.Drawing.Size(231, 27);
			this.comboBoxMovie.TabIndex = 0;
			// 
			// labelCinema
			// 
			this.labelCinema.AutoSize = true;
			this.labelCinema.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelCinema.Location = new System.Drawing.Point(19, 62);
			this.labelCinema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelCinema.Name = "labelCinema";
			this.labelCinema.Size = new System.Drawing.Size(54, 19);
			this.labelCinema.TabIndex = 0;
			this.labelCinema.Text = "影城：";
			// 
			// comboBoxCinema
			// 
			this.comboBoxCinema.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxCinema.FormattingEnabled = true;
			this.comboBoxCinema.Items.AddRange(new object[] {
            "--請選擇--"});
			this.comboBoxCinema.Location = new System.Drawing.Point(88, 62);
			this.comboBoxCinema.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxCinema.Name = "comboBoxCinema";
			this.comboBoxCinema.Size = new System.Drawing.Size(231, 27);
			this.comboBoxCinema.TabIndex = 1;
			this.comboBoxCinema.SelectedIndexChanged += new System.EventHandler(this.comboBoxCinema_SelectedIndexChanged);
			// 
			// labelRoom
			// 
			this.labelRoom.AutoSize = true;
			this.labelRoom.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelRoom.Location = new System.Drawing.Point(18, 92);
			this.labelRoom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelRoom.Name = "labelRoom";
			this.labelRoom.Size = new System.Drawing.Size(54, 19);
			this.labelRoom.TabIndex = 0;
			this.labelRoom.Text = "影廳：";
			// 
			// comboBoxRoom
			// 
			this.comboBoxRoom.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxRoom.FormattingEnabled = true;
			this.comboBoxRoom.Location = new System.Drawing.Point(88, 93);
			this.comboBoxRoom.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxRoom.Name = "comboBoxRoom";
			this.comboBoxRoom.Size = new System.Drawing.Size(231, 27);
			this.comboBoxRoom.TabIndex = 2;
			// 
			// labelDate
			// 
			this.labelDate.AutoSize = true;
			this.labelDate.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelDate.Location = new System.Drawing.Point(18, 122);
			this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelDate.Name = "labelDate";
			this.labelDate.Size = new System.Drawing.Size(54, 19);
			this.labelDate.TabIndex = 0;
			this.labelDate.Text = "日期：";
			// 
			// labelTime
			// 
			this.labelTime.AutoSize = true;
			this.labelTime.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelTime.Location = new System.Drawing.Point(18, 152);
			this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(54, 19);
			this.labelTime.TabIndex = 0;
			this.labelTime.Text = "時間：";
			// 
			// buttonAdd
			// 
			this.buttonAdd.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonAdd.Location = new System.Drawing.Point(245, 217);
			this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(74, 34);
			this.buttonAdd.TabIndex = 5;
			this.buttonAdd.Text = "新增";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// dateTimePickerDate
			// 
			this.dateTimePickerDate.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dateTimePickerDate.Location = new System.Drawing.Point(88, 124);
			this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(2);
			this.dateTimePickerDate.Name = "dateTimePickerDate";
			this.dateTimePickerDate.Size = new System.Drawing.Size(231, 27);
			this.dateTimePickerDate.TabIndex = 3;
			// 
			// dateTimePickerTime
			// 
			this.dateTimePickerTime.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dateTimePickerTime.Location = new System.Drawing.Point(88, 155);
			this.dateTimePickerTime.Margin = new System.Windows.Forms.Padding(2);
			this.dateTimePickerTime.Name = "dateTimePickerTime";
			this.dateTimePickerTime.ShowUpDown = true;
			this.dateTimePickerTime.Size = new System.Drawing.Size(231, 27);
			this.dateTimePickerTime.TabIndex = 4;
			this.dateTimePickerTime.Value = new System.DateTime(2023, 1, 20, 0, 0, 0, 0);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(18, 182);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 19);
			this.label1.TabIndex = 6;
			this.label1.Text = "票價：";
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Location = new System.Drawing.Point(88, 186);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.Size = new System.Drawing.Size(231, 25);
			this.textBoxPrice.TabIndex = 7;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FormAddSessions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(351, 262);
			this.Controls.Add(this.textBoxPrice);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateTimePickerTime);
			this.Controls.Add(this.dateTimePickerDate);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.labelTime);
			this.Controls.Add(this.labelDate);
			this.Controls.Add(this.comboBoxRoom);
			this.Controls.Add(this.labelRoom);
			this.Controls.Add(this.comboBoxCinema);
			this.Controls.Add(this.labelCinema);
			this.Controls.Add(this.comboBoxMovie);
			this.Controls.Add(this.labelMovie);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormAddSessions";
			this.Text = "場次新增";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelMovie;
		private System.Windows.Forms.ComboBox comboBoxMovie;
		private System.Windows.Forms.Label labelCinema;
		private System.Windows.Forms.ComboBox comboBoxCinema;
		private System.Windows.Forms.Label labelRoom;
		private System.Windows.Forms.ComboBox comboBoxRoom;
		private System.Windows.Forms.Label labelDate;
		private System.Windows.Forms.Label labelTime;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.DateTimePicker dateTimePickerDate;
		private System.Windows.Forms.DateTimePicker dateTimePickerTime;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxPrice;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}