namespace ISpan.Inseparable.Win
{
	partial class FormMovies
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
			this.dataGridViewMovie = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.checkBoxDate = new System.Windows.Forms.CheckBox();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.groupBoxMovie = new System.Windows.Forms.GroupBox();
			this.textBoxInto = new System.Windows.Forms.TextBox();
			this.pictureBoxPic = new System.Windows.Forms.PictureBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.labelOffDate = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.labelLength = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.labelOnDate = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.labellevel = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.labelID = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.comboBoxLevel = new System.Windows.Forms.ComboBox();
			this.label = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovie)).BeginInit();
			this.groupBoxMovie.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewMovie
			// 
			this.dataGridViewMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewMovie.Location = new System.Drawing.Point(30, 137);
			this.dataGridViewMovie.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridViewMovie.Name = "dataGridViewMovie";
			this.dataGridViewMovie.RowHeadersWidth = 66;
			this.dataGridViewMovie.RowTemplate.Height = 32;
			this.dataGridViewMovie.Size = new System.Drawing.Size(669, 487);
			this.dataGridViewMovie.TabIndex = 0;
			this.dataGridViewMovie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMovie_CellClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(9, 30);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 22);
			this.label1.TabIndex = 1;
			this.label1.Text = "電影名稱:";
			// 
			// textBoxName
			// 
			this.textBoxName.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxName.Location = new System.Drawing.Point(103, 30);
			this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(111, 30);
			this.textBoxName.TabIndex = 0;
			// 
			// checkBoxDate
			// 
			this.checkBoxDate.AutoSize = true;
			this.checkBoxDate.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.checkBoxDate.Location = new System.Drawing.Point(466, 30);
			this.checkBoxDate.Margin = new System.Windows.Forms.Padding(2);
			this.checkBoxDate.Name = "checkBoxDate";
			this.checkBoxDate.Size = new System.Drawing.Size(134, 26);
			this.checkBoxDate.TabIndex = 3;
			this.checkBoxDate.Text = "過濾是否下架";
			this.checkBoxDate.UseVisualStyleBackColor = true;
			// 
			// buttonSearch
			// 
			this.buttonSearch.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonSearch.Location = new System.Drawing.Point(582, 71);
			this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(73, 39);
			this.buttonSearch.TabIndex = 2;
			this.buttonSearch.Text = "查詢";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// groupBoxMovie
			// 
			this.groupBoxMovie.Controls.Add(this.textBoxInto);
			this.groupBoxMovie.Controls.Add(this.pictureBoxPic);
			this.groupBoxMovie.Controls.Add(this.label15);
			this.groupBoxMovie.Controls.Add(this.label14);
			this.groupBoxMovie.Controls.Add(this.labelOffDate);
			this.groupBoxMovie.Controls.Add(this.label12);
			this.groupBoxMovie.Controls.Add(this.labelLength);
			this.groupBoxMovie.Controls.Add(this.label10);
			this.groupBoxMovie.Controls.Add(this.labelOnDate);
			this.groupBoxMovie.Controls.Add(this.label8);
			this.groupBoxMovie.Controls.Add(this.labellevel);
			this.groupBoxMovie.Controls.Add(this.label6);
			this.groupBoxMovie.Controls.Add(this.labelName);
			this.groupBoxMovie.Controls.Add(this.label4);
			this.groupBoxMovie.Controls.Add(this.labelID);
			this.groupBoxMovie.Controls.Add(this.label2);
			this.groupBoxMovie.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.groupBoxMovie.Location = new System.Drawing.Point(729, 32);
			this.groupBoxMovie.Margin = new System.Windows.Forms.Padding(2);
			this.groupBoxMovie.Name = "groupBoxMovie";
			this.groupBoxMovie.Padding = new System.Windows.Forms.Padding(2);
			this.groupBoxMovie.Size = new System.Drawing.Size(397, 633);
			this.groupBoxMovie.TabIndex = 5;
			this.groupBoxMovie.TabStop = false;
			this.groupBoxMovie.Text = "電影資訊";
			// 
			// textBoxInto
			// 
			this.textBoxInto.Location = new System.Drawing.Point(133, 456);
			this.textBoxInto.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxInto.Multiline = true;
			this.textBoxInto.Name = "textBoxInto";
			this.textBoxInto.ReadOnly = true;
			this.textBoxInto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxInto.Size = new System.Drawing.Size(211, 142);
			this.textBoxInto.TabIndex = 15;
			// 
			// pictureBoxPic
			// 
			this.pictureBoxPic.Location = new System.Drawing.Point(134, 252);
			this.pictureBoxPic.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBoxPic.Name = "pictureBoxPic";
			this.pictureBoxPic.Size = new System.Drawing.Size(154, 189);
			this.pictureBoxPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxPic.TabIndex = 14;
			this.pictureBoxPic.TabStop = false;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(32, 456);
			this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(61, 22);
			this.label15.TabIndex = 13;
			this.label15.Text = "簡介：";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(32, 252);
			this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(78, 22);
			this.label14.TabIndex = 12;
			this.label14.Text = "宣傳照：";
			// 
			// labelOffDate
			// 
			this.labelOffDate.AutoSize = true;
			this.labelOffDate.Location = new System.Drawing.Point(130, 171);
			this.labelOffDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelOffDate.Name = "labelOffDate";
			this.labelOffDate.Size = new System.Drawing.Size(0, 22);
			this.labelOffDate.TabIndex = 11;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(32, 204);
			this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(61, 22);
			this.label12.TabIndex = 10;
			this.label12.Text = "時長：";
			// 
			// labelLength
			// 
			this.labelLength.AutoSize = true;
			this.labelLength.Location = new System.Drawing.Point(130, 204);
			this.labelLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelLength.Name = "labelLength";
			this.labelLength.Size = new System.Drawing.Size(0, 22);
			this.labelLength.TabIndex = 9;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(32, 171);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(78, 22);
			this.label10.TabIndex = 8;
			this.label10.Text = "下架日：";
			// 
			// labelOnDate
			// 
			this.labelOnDate.AutoSize = true;
			this.labelOnDate.Location = new System.Drawing.Point(130, 138);
			this.labelOnDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelOnDate.Name = "labelOnDate";
			this.labelOnDate.Size = new System.Drawing.Size(0, 22);
			this.labelOnDate.TabIndex = 7;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(32, 138);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(78, 22);
			this.label8.TabIndex = 6;
			this.label8.Text = "上架日：";
			// 
			// labellevel
			// 
			this.labellevel.AutoSize = true;
			this.labellevel.Location = new System.Drawing.Point(130, 105);
			this.labellevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labellevel.Name = "labellevel";
			this.labellevel.Size = new System.Drawing.Size(0, 22);
			this.labellevel.TabIndex = 5;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(32, 105);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 22);
			this.label6.TabIndex = 4;
			this.label6.Text = "分級：";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(130, 72);
			this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(0, 22);
			this.labelName.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(32, 72);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 22);
			this.label4.TabIndex = 2;
			this.label4.Text = "電影名稱：";
			// 
			// labelID
			// 
			this.labelID.AutoSize = true;
			this.labelID.Location = new System.Drawing.Point(130, 39);
			this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(0, 22);
			this.labelID.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 39);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 22);
			this.label2.TabIndex = 0;
			this.label2.Text = "ID：";
			// 
			// buttonAdd
			// 
			this.buttonAdd.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonAdd.Location = new System.Drawing.Point(418, 630);
			this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(63, 35);
			this.buttonAdd.TabIndex = 3;
			this.buttonAdd.Text = "新增";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonEdit
			// 
			this.buttonEdit.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonEdit.Location = new System.Drawing.Point(527, 630);
			this.buttonEdit.Margin = new System.Windows.Forms.Padding(2);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(63, 35);
			this.buttonEdit.TabIndex = 4;
			this.buttonEdit.Text = "修改";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonDelete.Location = new System.Drawing.Point(636, 630);
			this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(63, 35);
			this.buttonDelete.TabIndex = 5;
			this.buttonDelete.Text = "刪除";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// comboBoxLevel
			// 
			this.comboBoxLevel.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxLevel.FormattingEnabled = true;
			this.comboBoxLevel.Items.AddRange(new object[] {
            "--請選擇--"});
			this.comboBoxLevel.Location = new System.Drawing.Point(321, 30);
			this.comboBoxLevel.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxLevel.Name = "comboBoxLevel";
			this.comboBoxLevel.Size = new System.Drawing.Size(102, 30);
			this.comboBoxLevel.TabIndex = 1;
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label.Location = new System.Drawing.Point(247, 30);
			this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(61, 22);
			this.label.TabIndex = 10;
			this.label.Text = "分級：";
			// 
			// FormMovies
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.ClientSize = new System.Drawing.Size(1181, 692);
			this.Controls.Add(this.label);
			this.Controls.Add(this.comboBoxLevel);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.groupBoxMovie);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.checkBoxDate);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridViewMovie);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormMovies";
			this.Text = "電影維護";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovie)).EndInit();
			this.groupBoxMovie.ResumeLayout(false);
			this.groupBoxMovie.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewMovie;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.CheckBox checkBoxDate;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.GroupBox groupBoxMovie;
		private System.Windows.Forms.TextBox textBoxInto;
		private System.Windows.Forms.PictureBox pictureBoxPic;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label labelOffDate;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label labelLength;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label labelOnDate;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label labellevel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label labelID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.ComboBox comboBoxLevel;
		private System.Windows.Forms.Label label;
	}
}