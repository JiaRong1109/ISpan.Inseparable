﻿namespace ISpan.Inseparable.Win
{
	partial class FormAddMovies
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
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonSelectImage = new System.Windows.Forms.Button();
			this.pictureBoxPic = new System.Windows.Forms.PictureBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.comboBoxLevel = new System.Windows.Forms.ComboBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxInto = new System.Windows.Forms.TextBox();
			this.textBoxLength = new System.Windows.Forms.TextBox();
			this.dateTimePickerOn = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerOff = new System.Windows.Forms.DateTimePicker();
			this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonAdd
			// 
			this.buttonAdd.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonAdd.Location = new System.Drawing.Point(303, 494);
			this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(71, 36);
			this.buttonAdd.TabIndex = 7;
			this.buttonAdd.Text = "新增";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonSelectImage
			// 
			this.buttonSelectImage.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonSelectImage.Location = new System.Drawing.Point(210, 494);
			this.buttonSelectImage.Margin = new System.Windows.Forms.Padding(2);
			this.buttonSelectImage.Name = "buttonSelectImage";
			this.buttonSelectImage.Size = new System.Drawing.Size(88, 36);
			this.buttonSelectImage.TabIndex = 6;
			this.buttonSelectImage.Text = "選擇圖片";
			this.buttonSelectImage.UseVisualStyleBackColor = true;
			this.buttonSelectImage.Click += new System.EventHandler(this.buttonSelectImage_Click);
			// 
			// pictureBoxPic
			// 
			this.pictureBoxPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBoxPic.Location = new System.Drawing.Point(130, 323);
			this.pictureBoxPic.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBoxPic.Name = "pictureBoxPic";
			this.pictureBoxPic.Size = new System.Drawing.Size(243, 160);
			this.pictureBoxPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxPic.TabIndex = 61;
			this.pictureBoxPic.TabStop = false;
			// 
			// textBoxName
			// 
			this.textBoxName.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxName.Location = new System.Drawing.Point(130, 20);
			this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(242, 31);
			this.textBoxName.TabIndex = 0;
			// 
			// comboBoxLevel
			// 
			this.comboBoxLevel.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxLevel.FormattingEnabled = true;
			this.comboBoxLevel.Items.AddRange(new object[] {
            "--請選擇--"});
			this.comboBoxLevel.Location = new System.Drawing.Point(130, 58);
			this.comboBoxLevel.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxLevel.Name = "comboBoxLevel";
			this.comboBoxLevel.Size = new System.Drawing.Size(242, 31);
			this.comboBoxLevel.TabIndex = 1;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label16.Location = new System.Drawing.Point(18, 323);
			this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(64, 23);
			this.label16.TabIndex = 60;
			this.label16.Text = "圖片：";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label14.Location = new System.Drawing.Point(27, 172);
			this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(64, 23);
			this.label14.TabIndex = 59;
			this.label14.Text = "時長：";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label12.Location = new System.Drawing.Point(27, 133);
			this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(82, 23);
			this.label12.TabIndex = 58;
			this.label12.Text = "下架日：";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label10.Location = new System.Drawing.Point(27, 96);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(82, 23);
			this.label10.TabIndex = 57;
			this.label10.Text = "上架日：";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label8.Location = new System.Drawing.Point(27, 58);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 56;
			this.label8.Text = "電影級別：";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.Location = new System.Drawing.Point(27, 20);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 55;
			this.label6.Text = "電影名稱：";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(27, 209);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 62;
			this.label1.Text = "簡介：";
			// 
			// textBoxInto
			// 
			this.textBoxInto.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxInto.Location = new System.Drawing.Point(130, 206);
			this.textBoxInto.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxInto.Multiline = true;
			this.textBoxInto.Name = "textBoxInto";
			this.textBoxInto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxInto.Size = new System.Drawing.Size(242, 89);
			this.textBoxInto.TabIndex = 5;
			// 
			// textBoxLength
			// 
			this.textBoxLength.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxLength.Location = new System.Drawing.Point(130, 169);
			this.textBoxLength.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxLength.Name = "textBoxLength";
			this.textBoxLength.Size = new System.Drawing.Size(242, 31);
			this.textBoxLength.TabIndex = 4;
			// 
			// dateTimePickerOn
			// 
			this.dateTimePickerOn.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dateTimePickerOn.Location = new System.Drawing.Point(130, 92);
			this.dateTimePickerOn.Margin = new System.Windows.Forms.Padding(2);
			this.dateTimePickerOn.Name = "dateTimePickerOn";
			this.dateTimePickerOn.Size = new System.Drawing.Size(242, 31);
			this.dateTimePickerOn.TabIndex = 2;
			// 
			// dateTimePickerOff
			// 
			this.dateTimePickerOff.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dateTimePickerOff.Location = new System.Drawing.Point(132, 131);
			this.dateTimePickerOff.Margin = new System.Windows.Forms.Padding(2);
			this.dateTimePickerOff.Name = "dateTimePickerOff";
			this.dateTimePickerOff.Size = new System.Drawing.Size(242, 31);
			this.dateTimePickerOff.TabIndex = 3;
			// 
			// openFileDialogImage
			// 
			this.openFileDialogImage.FileName = "openFileDialogImage";
			// 
			// FormAddMovies
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(403, 544);
			this.Controls.Add(this.dateTimePickerOff);
			this.Controls.Add(this.dateTimePickerOn);
			this.Controls.Add(this.textBoxLength);
			this.Controls.Add(this.textBoxInto);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.buttonSelectImage);
			this.Controls.Add(this.pictureBoxPic);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.comboBoxLevel);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label6);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormAddMovies";
			this.Text = "新增電影";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonSelectImage;
		private System.Windows.Forms.PictureBox pictureBoxPic;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.ComboBox comboBoxLevel;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxInto;
		private System.Windows.Forms.TextBox textBoxLength;
		private System.Windows.Forms.DateTimePicker dateTimePickerOn;
		private System.Windows.Forms.DateTimePicker dateTimePickerOff;
		private System.Windows.Forms.OpenFileDialog openFileDialogImage;
	}
}