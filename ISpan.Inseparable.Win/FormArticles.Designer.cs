namespace ISpan.Inseparable.Win
{
	partial class FormArticles
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
			this.buttonSearch = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.textBoxArticleID = new System.Windows.Forms.TextBox();
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.textBoxMemberID = new System.Windows.Forms.TextBox();
			this.buttonAddNew = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxKeyword = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.buttonCharts = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonSearch
			// 
			this.buttonSearch.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonSearch.Location = new System.Drawing.Point(627, 105);
			this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(102, 46);
			this.buttonSearch.TabIndex = 0;
			this.buttonSearch.Text = "搜尋";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(89, 187);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 27;
			this.dataGridView1.Size = new System.Drawing.Size(822, 324);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
			// 
			// textBoxArticleID
			// 
			this.textBoxArticleID.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxArticleID.Location = new System.Drawing.Point(182, 74);
			this.textBoxArticleID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxArticleID.Name = "textBoxArticleID";
			this.textBoxArticleID.Size = new System.Drawing.Size(127, 30);
			this.textBoxArticleID.TabIndex = 2;
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxTitle.Location = new System.Drawing.Point(182, 129);
			this.textBoxTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(127, 30);
			this.textBoxTitle.TabIndex = 3;
			// 
			// textBoxMemberID
			// 
			this.textBoxMemberID.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxMemberID.Location = new System.Drawing.Point(424, 75);
			this.textBoxMemberID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxMemberID.Name = "textBoxMemberID";
			this.textBoxMemberID.Size = new System.Drawing.Size(127, 30);
			this.textBoxMemberID.TabIndex = 4;
			// 
			// buttonAddNew
			// 
			this.buttonAddNew.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonAddNew.Location = new System.Drawing.Point(789, 105);
			this.buttonAddNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonAddNew.Name = "buttonAddNew";
			this.buttonAddNew.Size = new System.Drawing.Size(102, 46);
			this.buttonAddNew.TabIndex = 5;
			this.buttonAddNew.Text = "發文";
			this.buttonAddNew.UseVisualStyleBackColor = true;
			this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(115, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 22);
			this.label1.TabIndex = 6;
			this.label1.Text = "文章ID :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(130, 137);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 22);
			this.label2.TabIndex = 7;
			this.label2.Text = "標題 :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(357, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 22);
			this.label3.TabIndex = 8;
			this.label3.Text = "會員ID :";
			// 
			// comboBoxKeyword
			// 
			this.comboBoxKeyword.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxKeyword.FormattingEnabled = true;
			this.comboBoxKeyword.Location = new System.Drawing.Point(416, 129);
			this.comboBoxKeyword.Name = "comboBoxKeyword";
			this.comboBoxKeyword.Size = new System.Drawing.Size(135, 30);
			this.comboBoxKeyword.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(364, 132);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 22);
			this.label4.TabIndex = 9;
			this.label4.Text = "類別 :";
			// 
			// buttonCharts
			// 
			this.buttonCharts.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonCharts.Location = new System.Drawing.Point(789, 41);
			this.buttonCharts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonCharts.Name = "buttonCharts";
			this.buttonCharts.Size = new System.Drawing.Size(102, 46);
			this.buttonCharts.TabIndex = 11;
			this.buttonCharts.Text = "報表";
			this.buttonCharts.UseVisualStyleBackColor = true;
			this.buttonCharts.Click += new System.EventHandler(this.buttonCharts_Click);
			// 
			// FormArticles
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.ClientSize = new System.Drawing.Size(990, 561);
			this.Controls.Add(this.buttonCharts);
			this.Controls.Add(this.comboBoxKeyword);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonAddNew);
			this.Controls.Add(this.textBoxMemberID);
			this.Controls.Add(this.textBoxTitle);
			this.Controls.Add(this.textBoxArticleID);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.buttonSearch);
			this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FormArticles";
			this.Text = "文章搜尋";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox textBoxArticleID;
		private System.Windows.Forms.TextBox textBoxTitle;
		private System.Windows.Forms.TextBox textBoxMemberID;
		private System.Windows.Forms.Button buttonAddNew;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBoxKeyword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonCharts;
	}
}