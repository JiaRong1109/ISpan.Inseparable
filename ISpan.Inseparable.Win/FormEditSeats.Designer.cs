namespace ISpan.Inseparable.Win
{
	partial class FormEditSeats
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
			this.comboBoxColumn = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxRow = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.labelID = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.labelCinema = new System.Windows.Forms.Label();
			this.labelRoom = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonEdit
			// 
			this.buttonEdit.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonEdit.Location = new System.Drawing.Point(257, 169);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(69, 42);
			this.buttonEdit.TabIndex = 2;
			this.buttonEdit.Text = "更新";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// comboBoxColumn
			// 
			this.comboBoxColumn.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxColumn.FormattingEnabled = true;
			this.comboBoxColumn.Items.AddRange(new object[] {
            "--請選擇--",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17"});
			this.comboBoxColumn.Location = new System.Drawing.Point(108, 134);
			this.comboBoxColumn.Name = "comboBoxColumn";
			this.comboBoxColumn.Size = new System.Drawing.Size(143, 27);
			this.comboBoxColumn.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(26, 134);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 19);
			this.label3.TabIndex = 3;
			this.label3.Text = "幾號：";
			// 
			// comboBoxRow
			// 
			this.comboBoxRow.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxRow.FormattingEnabled = true;
			this.comboBoxRow.Items.AddRange(new object[] {
            "--請選擇--",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N"});
			this.comboBoxRow.Location = new System.Drawing.Point(108, 105);
			this.comboBoxRow.Name = "comboBoxRow";
			this.comboBoxRow.Size = new System.Drawing.Size(143, 27);
			this.comboBoxRow.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(26, 105);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 19);
			this.label2.TabIndex = 4;
			this.label2.Text = "幾排：";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(26, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 19);
			this.label1.TabIndex = 5;
			this.label1.Text = "影廳：";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(26, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 19);
			this.label4.TabIndex = 10;
			this.label4.Text = "座位ID：";
			// 
			// labelID
			// 
			this.labelID.AutoSize = true;
			this.labelID.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelID.Location = new System.Drawing.Point(105, 26);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(0, 19);
			this.labelID.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.Location = new System.Drawing.Point(26, 56);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 19);
			this.label5.TabIndex = 5;
			this.label5.Text = "影城：";
			// 
			// labelCinema
			// 
			this.labelCinema.AutoSize = true;
			this.labelCinema.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelCinema.Location = new System.Drawing.Point(105, 56);
			this.labelCinema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelCinema.Name = "labelCinema";
			this.labelCinema.Size = new System.Drawing.Size(0, 19);
			this.labelCinema.TabIndex = 11;
			// 
			// labelRoom
			// 
			this.labelRoom.AutoSize = true;
			this.labelRoom.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelRoom.Location = new System.Drawing.Point(105, 81);
			this.labelRoom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelRoom.Name = "labelRoom";
			this.labelRoom.Size = new System.Drawing.Size(0, 19);
			this.labelRoom.TabIndex = 12;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FormEditSeats
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(358, 237);
			this.Controls.Add(this.labelRoom);
			this.Controls.Add(this.labelCinema);
			this.Controls.Add(this.labelID);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.comboBoxColumn);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBoxRow);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Name = "FormEditSeats";
			this.Text = "座位修改";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.ComboBox comboBoxColumn;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBoxRow;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label labelID;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label labelCinema;
		private System.Windows.Forms.Label labelRoom;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}