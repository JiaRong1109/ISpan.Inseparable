namespace ISpan.Inseparable.Win
{
	partial class FormComments
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
			this.textBoxItemNumber = new System.Windows.Forms.TextBox();
			this.textBoxMemberID = new System.Windows.Forms.TextBox();
			this.buttonAddNew = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonSearch
			// 
			this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonSearch.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonSearch.Location = new System.Drawing.Point(624, 46);
			this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(116, 63);
			this.buttonSearch.TabIndex = 6;
			this.buttonSearch.Text = "搜尋";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.GridColor = System.Drawing.Color.Chocolate;
			this.dataGridView1.Location = new System.Drawing.Point(78, 157);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 27;
			this.dataGridView1.Size = new System.Drawing.Size(817, 327);
			this.dataGridView1.TabIndex = 7;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// textBoxArticleID
			// 
			this.textBoxArticleID.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBoxArticleID.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxArticleID.Location = new System.Drawing.Point(142, 65);
			this.textBoxArticleID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxArticleID.Name = "textBoxArticleID";
			this.textBoxArticleID.Size = new System.Drawing.Size(91, 30);
			this.textBoxArticleID.TabIndex = 8;
			// 
			// textBoxItemNumber
			// 
			this.textBoxItemNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBoxItemNumber.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxItemNumber.Location = new System.Drawing.Point(309, 65);
			this.textBoxItemNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxItemNumber.Name = "textBoxItemNumber";
			this.textBoxItemNumber.Size = new System.Drawing.Size(91, 30);
			this.textBoxItemNumber.TabIndex = 9;
			// 
			// textBoxMemberID
			// 
			this.textBoxMemberID.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBoxMemberID.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxMemberID.Location = new System.Drawing.Point(493, 65);
			this.textBoxMemberID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxMemberID.Name = "textBoxMemberID";
			this.textBoxMemberID.Size = new System.Drawing.Size(91, 30);
			this.textBoxMemberID.TabIndex = 10;
			// 
			// buttonAddNew
			// 
			this.buttonAddNew.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonAddNew.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonAddNew.Location = new System.Drawing.Point(779, 46);
			this.buttonAddNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonAddNew.Name = "buttonAddNew";
			this.buttonAddNew.Size = new System.Drawing.Size(116, 63);
			this.buttonAddNew.TabIndex = 11;
			this.buttonAddNew.Text = "留言";
			this.buttonAddNew.UseVisualStyleBackColor = true;
			this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(75, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 22);
			this.label1.TabIndex = 12;
			this.label1.Text = "文章ID :";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(258, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 22);
			this.label2.TabIndex = 13;
			this.label2.Text = "項次 :";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(425, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 22);
			this.label3.TabIndex = 14;
			this.label3.Text = "會員ID :";
			// 
			// FormComments
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.ClientSize = new System.Drawing.Size(992, 541);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonAddNew);
			this.Controls.Add(this.textBoxMemberID);
			this.Controls.Add(this.textBoxItemNumber);
			this.Controls.Add(this.textBoxArticleID);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.buttonSearch);
			this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FormComments";
			this.Text = "留言搜尋";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox textBoxArticleID;
		private System.Windows.Forms.TextBox textBoxItemNumber;
		private System.Windows.Forms.TextBox textBoxMemberID;
		private System.Windows.Forms.Button buttonAddNew;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}