namespace ISpan.Inseparable.Win
{
	partial class FormRooms
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
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxRoom = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBoxRoom = new System.Windows.Forms.GroupBox();
			this.buttonRoomAdd = new System.Windows.Forms.Button();
			this.buttonRoomEdit = new System.Windows.Forms.Button();
			this.buttonRoomDelete = new System.Windows.Forms.Button();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
			this.comboBoxCinema = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBoxSeat = new System.Windows.Forms.GroupBox();
			this.buttonSeatAdd = new System.Windows.Forms.Button();
			this.buttonSeatDelete = new System.Windows.Forms.Button();
			this.buttonSeatEdit = new System.Windows.Forms.Button();
			this.dataGridViewSeat = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			this.groupBoxRoom.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
			this.groupBoxSeat.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeat)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(281, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "影廳：";
			// 
			// comboBoxRoom
			// 
			this.comboBoxRoom.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxRoom.FormattingEnabled = true;
			this.comboBoxRoom.Items.AddRange(new object[] {
            "--請選擇--"});
			this.comboBoxRoom.Location = new System.Drawing.Point(352, 34);
			this.comboBoxRoom.Name = "comboBoxRoom";
			this.comboBoxRoom.Size = new System.Drawing.Size(148, 30);
			this.comboBoxRoom.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.groupBox1.Location = new System.Drawing.Point(61, 81);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(194, 175);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "影廳";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(83, 43);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(83, 34);
			this.button1.TabIndex = 0;
			this.button1.Text = "新增";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.buttonRoomAdd_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(83, 83);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(83, 34);
			this.button2.TabIndex = 1;
			this.button2.Text = "修改";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.buttonRoomEdit_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(83, 123);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(83, 34);
			this.button3.TabIndex = 2;
			this.button3.Text = "刪除";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.buttonRoomDelete_Click);
			// 
			// groupBoxRoom
			// 
			this.groupBoxRoom.Controls.Add(this.buttonRoomAdd);
			this.groupBoxRoom.Controls.Add(this.buttonRoomEdit);
			this.groupBoxRoom.Controls.Add(this.buttonRoomDelete);
			this.groupBoxRoom.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.groupBoxRoom.Location = new System.Drawing.Point(61, 81);
			this.groupBoxRoom.Name = "groupBoxRoom";
			this.groupBoxRoom.Size = new System.Drawing.Size(194, 175);
			this.groupBoxRoom.TabIndex = 10;
			this.groupBoxRoom.TabStop = false;
			this.groupBoxRoom.Text = "影廳";
			// 
			// buttonRoomAdd
			// 
			this.buttonRoomAdd.Location = new System.Drawing.Point(83, 43);
			this.buttonRoomAdd.Name = "buttonRoomAdd";
			this.buttonRoomAdd.Size = new System.Drawing.Size(83, 34);
			this.buttonRoomAdd.TabIndex = 5;
			this.buttonRoomAdd.Text = "新增";
			this.buttonRoomAdd.UseVisualStyleBackColor = true;
			// 
			// buttonRoomEdit
			// 
			this.buttonRoomEdit.Location = new System.Drawing.Point(83, 83);
			this.buttonRoomEdit.Name = "buttonRoomEdit";
			this.buttonRoomEdit.Size = new System.Drawing.Size(83, 34);
			this.buttonRoomEdit.TabIndex = 6;
			this.buttonRoomEdit.Text = "修改";
			this.buttonRoomEdit.UseVisualStyleBackColor = true;
			// 
			// buttonRoomDelete
			// 
			this.buttonRoomDelete.Location = new System.Drawing.Point(83, 123);
			this.buttonRoomDelete.Name = "buttonRoomDelete";
			this.buttonRoomDelete.Size = new System.Drawing.Size(83, 34);
			this.buttonRoomDelete.TabIndex = 7;
			this.buttonRoomDelete.Text = "刪除";
			this.buttonRoomDelete.UseVisualStyleBackColor = true;
			// 
			// buttonSearch
			// 
			this.buttonSearch.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonSearch.Location = new System.Drawing.Point(670, 34);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(83, 34);
			this.buttonSearch.TabIndex = 2;
			this.buttonSearch.Text = "查詢";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// dataGridViewRoom
			// 
			this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewRoom.Location = new System.Drawing.Point(274, 86);
			this.dataGridViewRoom.Name = "dataGridViewRoom";
			this.dataGridViewRoom.RowHeadersWidth = 51;
			this.dataGridViewRoom.RowTemplate.Height = 27;
			this.dataGridViewRoom.Size = new System.Drawing.Size(499, 207);
			this.dataGridViewRoom.TabIndex = 12;
			this.dataGridViewRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoom_CellClick);
			// 
			// comboBoxCinema
			// 
			this.comboBoxCinema.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxCinema.FormattingEnabled = true;
			this.comboBoxCinema.Items.AddRange(new object[] {
            "--請選擇--"});
			this.comboBoxCinema.Location = new System.Drawing.Point(80, 34);
			this.comboBoxCinema.Name = "comboBoxCinema";
			this.comboBoxCinema.Size = new System.Drawing.Size(148, 30);
			this.comboBoxCinema.TabIndex = 0;
			this.comboBoxCinema.SelectedIndexChanged += new System.EventHandler(this.comboBoxCinema_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(10, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 22);
			this.label2.TabIndex = 6;
			this.label2.Text = "影城：";
			// 
			// groupBoxSeat
			// 
			this.groupBoxSeat.Controls.Add(this.buttonSeatAdd);
			this.groupBoxSeat.Controls.Add(this.buttonSeatDelete);
			this.groupBoxSeat.Controls.Add(this.buttonSeatEdit);
			this.groupBoxSeat.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.groupBoxSeat.Location = new System.Drawing.Point(61, 324);
			this.groupBoxSeat.Name = "groupBoxSeat";
			this.groupBoxSeat.Size = new System.Drawing.Size(194, 175);
			this.groupBoxSeat.TabIndex = 13;
			this.groupBoxSeat.TabStop = false;
			this.groupBoxSeat.Text = "座位";
			// 
			// buttonSeatAdd
			// 
			this.buttonSeatAdd.Location = new System.Drawing.Point(83, 37);
			this.buttonSeatAdd.Name = "buttonSeatAdd";
			this.buttonSeatAdd.Size = new System.Drawing.Size(83, 34);
			this.buttonSeatAdd.TabIndex = 0;
			this.buttonSeatAdd.Text = "新增";
			this.buttonSeatAdd.UseVisualStyleBackColor = true;
			this.buttonSeatAdd.Click += new System.EventHandler(this.buttonSeatAdd_Click);
			// 
			// buttonSeatDelete
			// 
			this.buttonSeatDelete.Location = new System.Drawing.Point(83, 117);
			this.buttonSeatDelete.Name = "buttonSeatDelete";
			this.buttonSeatDelete.Size = new System.Drawing.Size(83, 34);
			this.buttonSeatDelete.TabIndex = 2;
			this.buttonSeatDelete.Text = "刪除";
			this.buttonSeatDelete.UseVisualStyleBackColor = true;
			this.buttonSeatDelete.Click += new System.EventHandler(this.buttonSeatDelete_Click);
			// 
			// buttonSeatEdit
			// 
			this.buttonSeatEdit.Location = new System.Drawing.Point(83, 77);
			this.buttonSeatEdit.Name = "buttonSeatEdit";
			this.buttonSeatEdit.Size = new System.Drawing.Size(83, 34);
			this.buttonSeatEdit.TabIndex = 1;
			this.buttonSeatEdit.Text = "修改";
			this.buttonSeatEdit.UseVisualStyleBackColor = true;
			this.buttonSeatEdit.Click += new System.EventHandler(this.buttonSeatEdit_Click);
			// 
			// dataGridViewSeat
			// 
			this.dataGridViewSeat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewSeat.Location = new System.Drawing.Point(274, 327);
			this.dataGridViewSeat.Name = "dataGridViewSeat";
			this.dataGridViewSeat.RowHeadersWidth = 51;
			this.dataGridViewSeat.RowTemplate.Height = 27;
			this.dataGridViewSeat.Size = new System.Drawing.Size(715, 207);
			this.dataGridViewSeat.TabIndex = 14;
			// 
			// FormRooms
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.ClientSize = new System.Drawing.Size(1044, 564);
			this.Controls.Add(this.groupBoxSeat);
			this.Controls.Add(this.dataGridViewSeat);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.comboBoxRoom);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBoxRoom);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.dataGridViewRoom);
			this.Controls.Add(this.comboBoxCinema);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormRooms";
			this.Text = "影廳維護";
			this.groupBox1.ResumeLayout(false);
			this.groupBoxRoom.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
			this.groupBoxSeat.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeat)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxRoom;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.GroupBox groupBoxRoom;
		private System.Windows.Forms.Button buttonRoomAdd;
		private System.Windows.Forms.Button buttonRoomEdit;
		private System.Windows.Forms.Button buttonRoomDelete;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.DataGridView dataGridViewRoom;
		private System.Windows.Forms.ComboBox comboBoxCinema;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBoxSeat;
		private System.Windows.Forms.Button buttonSeatAdd;
		private System.Windows.Forms.Button buttonSeatDelete;
		private System.Windows.Forms.Button buttonSeatEdit;
		private System.Windows.Forms.DataGridView dataGridViewSeat;
	}
}