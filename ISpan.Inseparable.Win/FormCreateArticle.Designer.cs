namespace ISpan.Inseparable.Win
{
	partial class FormCreateArticle
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
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.textBoxContent = new System.Windows.Forms.TextBox();
			this.buttonCreate = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.dataGridViewLeave = new System.Windows.Forms.DataGridView();
			this.dataGridViewChosen = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxMemberID = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeave)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewChosen)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Font = new System.Drawing.Font("微軟正黑體", 10F);
			this.textBoxTitle.Location = new System.Drawing.Point(349, 100);
			this.textBoxTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(232, 30);
			this.textBoxTitle.TabIndex = 0;
			// 
			// textBoxContent
			// 
			this.textBoxContent.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxContent.Location = new System.Drawing.Point(50, 169);
			this.textBoxContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxContent.Multiline = true;
			this.textBoxContent.Name = "textBoxContent";
			this.textBoxContent.Size = new System.Drawing.Size(668, 326);
			this.textBoxContent.TabIndex = 1;
			// 
			// buttonCreate
			// 
			this.buttonCreate.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonCreate.Location = new System.Drawing.Point(611, 90);
			this.buttonCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonCreate.Name = "buttonCreate";
			this.buttonCreate.Size = new System.Drawing.Size(108, 44);
			this.buttonCreate.TabIndex = 2;
			this.buttonCreate.Text = "發文";
			this.buttonCreate.UseVisualStyleBackColor = true;
			this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(292, 104);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 19);
			this.label1.TabIndex = 3;
			this.label1.Text = "標題 :";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// dataGridViewLeave
			// 
			this.dataGridViewLeave.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridViewLeave.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewLeave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewLeave.Location = new System.Drawing.Point(778, 169);
			this.dataGridViewLeave.Name = "dataGridViewLeave";
			this.dataGridViewLeave.RowHeadersWidth = 51;
			this.dataGridViewLeave.RowTemplate.Height = 27;
			this.dataGridViewLeave.Size = new System.Drawing.Size(280, 325);
			this.dataGridViewLeave.TabIndex = 4;
			this.dataGridViewLeave.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLeave_CellClick);
			// 
			// dataGridViewChosen
			// 
			this.dataGridViewChosen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridViewChosen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewChosen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewChosen.Location = new System.Drawing.Point(1109, 170);
			this.dataGridViewChosen.Name = "dataGridViewChosen";
			this.dataGridViewChosen.RowHeadersWidth = 51;
			this.dataGridViewChosen.Size = new System.Drawing.Size(280, 325);
			this.dataGridViewChosen.TabIndex = 4;
			this.dataGridViewChosen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChosen_CellClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(774, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 19);
			this.label2.TabIndex = 5;
			this.label2.Text = "新增類別";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(1105, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 19);
			this.label3.TabIndex = 6;
			this.label3.Text = "已選擇類別";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(78, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 19);
			this.label4.TabIndex = 3;
			this.label4.Text = "會員ID :";
			// 
			// textBoxMemberID
			// 
			this.textBoxMemberID.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxMemberID.Location = new System.Drawing.Point(145, 97);
			this.textBoxMemberID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxMemberID.Name = "textBoxMemberID";
			this.textBoxMemberID.Size = new System.Drawing.Size(127, 30);
			this.textBoxMemberID.TabIndex = 7;
			// 
			// FormCreateArticle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1429, 570);
			this.Controls.Add(this.textBoxMemberID);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridViewChosen);
			this.Controls.Add(this.dataGridViewLeave);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonCreate);
			this.Controls.Add(this.textBoxContent);
			this.Controls.Add(this.textBoxTitle);
			this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FormCreateArticle";
			this.Text = "文章新增";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeave)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewChosen)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxTitle;
		private System.Windows.Forms.TextBox textBoxContent;
		private System.Windows.Forms.Button buttonCreate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridViewChosen;
		private System.Windows.Forms.DataGridView dataGridViewLeave;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxMemberID;
	}
}