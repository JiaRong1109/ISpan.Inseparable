namespace ISpan.Inseparable.Win
{
	partial class FormSessions
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
			this.comboBoxMovie = new System.Windows.Forms.ComboBox();
			this.comboBoxCinema = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxRoom = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dateTimePickerBegin = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.dataGridViewSession = new System.Windows.Forms.DataGridView();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSession)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(4, 19);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "電影名稱：";
			// 
			// comboBoxMovie
			// 
			this.comboBoxMovie.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxMovie.FormattingEnabled = true;
			this.comboBoxMovie.Items.AddRange(new object[] {
            "--請選擇--"});
			this.comboBoxMovie.Location = new System.Drawing.Point(106, 19);
			this.comboBoxMovie.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxMovie.Name = "comboBoxMovie";
			this.comboBoxMovie.Size = new System.Drawing.Size(139, 30);
			this.comboBoxMovie.TabIndex = 0;
			// 
			// comboBoxCinema
			// 
			this.comboBoxCinema.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxCinema.FormattingEnabled = true;
			this.comboBoxCinema.Items.AddRange(new object[] {
            "--請選擇--"});
			this.comboBoxCinema.Location = new System.Drawing.Point(354, 19);
			this.comboBoxCinema.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxCinema.Name = "comboBoxCinema";
			this.comboBoxCinema.Size = new System.Drawing.Size(139, 30);
			this.comboBoxCinema.TabIndex = 1;
			this.comboBoxCinema.SelectedIndexChanged += new System.EventHandler(this.comboBoxCinema_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(252, 19);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 22);
			this.label2.TabIndex = 2;
			this.label2.Text = "影城名稱：";
			// 
			// comboBoxRoom
			// 
			this.comboBoxRoom.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxRoom.FormattingEnabled = true;
			this.comboBoxRoom.Location = new System.Drawing.Point(602, 19);
			this.comboBoxRoom.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxRoom.Name = "comboBoxRoom";
			this.comboBoxRoom.Size = new System.Drawing.Size(139, 30);
			this.comboBoxRoom.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(500, 19);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 22);
			this.label3.TabIndex = 4;
			this.label3.Text = "影廳名稱：";
			// 
			// dateTimePickerBegin
			// 
			this.dateTimePickerBegin.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dateTimePickerBegin.Location = new System.Drawing.Point(74, 64);
			this.dateTimePickerBegin.Margin = new System.Windows.Forms.Padding(2);
			this.dateTimePickerBegin.Name = "dateTimePickerBegin";
			this.dateTimePickerBegin.Size = new System.Drawing.Size(139, 30);
			this.dateTimePickerBegin.TabIndex = 3;
			this.dateTimePickerBegin.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(4, 64);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 22);
			this.label4.TabIndex = 7;
			this.label4.Text = "時間：";
			// 
			// buttonSearch
			// 
			this.buttonSearch.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonSearch.Location = new System.Drawing.Point(729, 53);
			this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(85, 44);
			this.buttonSearch.TabIndex = 5;
			this.buttonSearch.Text = "查詢";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// dateTimePickerEnd
			// 
			this.dateTimePickerEnd.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dateTimePickerEnd.Location = new System.Drawing.Point(271, 64);
			this.dateTimePickerEnd.Margin = new System.Windows.Forms.Padding(2);
			this.dateTimePickerEnd.Name = "dateTimePickerEnd";
			this.dateTimePickerEnd.Size = new System.Drawing.Size(139, 30);
			this.dateTimePickerEnd.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.Location = new System.Drawing.Point(231, 64);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(27, 22);
			this.label5.TabIndex = 10;
			this.label5.Text = "到";
			// 
			// dataGridViewSession
			// 
			this.dataGridViewSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewSession.Location = new System.Drawing.Point(22, 103);
			this.dataGridViewSession.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridViewSession.Name = "dataGridViewSession";
			this.dataGridViewSession.RowHeadersWidth = 66;
			this.dataGridViewSession.RowTemplate.Height = 32;
			this.dataGridViewSession.Size = new System.Drawing.Size(788, 416);
			this.dataGridViewSession.TabIndex = 11;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonAdd.Location = new System.Drawing.Point(549, 523);
			this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(80, 47);
			this.buttonAdd.TabIndex = 6;
			this.buttonAdd.Text = "新增";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonEdit
			// 
			this.buttonEdit.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonEdit.Location = new System.Drawing.Point(639, 523);
			this.buttonEdit.Margin = new System.Windows.Forms.Padding(2);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(80, 47);
			this.buttonEdit.TabIndex = 7;
			this.buttonEdit.Text = "修改";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonDelete.Location = new System.Drawing.Point(729, 523);
			this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(80, 47);
			this.buttonDelete.TabIndex = 8;
			this.buttonDelete.Text = "刪除";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// FormSessions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.ClientSize = new System.Drawing.Size(846, 581);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.dataGridViewSession);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dateTimePickerEnd);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dateTimePickerBegin);
			this.Controls.Add(this.comboBoxRoom);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBoxCinema);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBoxMovie);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormSessions";
			this.Text = "電影場次維護";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSession)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxMovie;
		private System.Windows.Forms.ComboBox comboBoxCinema;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxRoom;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dateTimePickerBegin;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView dataGridViewSession;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonDelete;
	}
}