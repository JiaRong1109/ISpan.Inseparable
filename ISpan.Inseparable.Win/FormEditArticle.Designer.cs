using System;

namespace ISpan.Inseparable.Win
{
	partial class FormEditArticle
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
			this.labelTitle = new System.Windows.Forms.Label();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.textBoxContent = new System.Windows.Forms.TextBox();
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.labelArticleID = new System.Windows.Forms.Label();
			this.labelLikes = new System.Windows.Forms.Label();
			this.labelClicks = new System.Windows.Forms.Label();
			this.labelMemberID = new System.Windows.Forms.Label();
			this.labelPostingDate = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridViewLeave = new System.Windows.Forms.DataGridView();
			this.dataGridViewUpdate = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeave)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdate)).BeginInit();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Location = new System.Drawing.Point(257, 126);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(46, 19);
			this.labelTitle.TabIndex = 7;
			this.labelTitle.Text = "標題 :";
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(714, 117);
			this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(90, 44);
			this.buttonUpdate.TabIndex = 6;
			this.buttonUpdate.Text = "修改";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// textBoxContent
			// 
			this.textBoxContent.Location = new System.Drawing.Point(37, 189);
			this.textBoxContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxContent.Multiline = true;
			this.textBoxContent.Name = "textBoxContent";
			this.textBoxContent.Size = new System.Drawing.Size(869, 318);
			this.textBoxContent.TabIndex = 5;
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Location = new System.Drawing.Point(329, 122);
			this.textBoxTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(275, 27);
			this.textBoxTitle.TabIndex = 4;
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(811, 117);
			this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(96, 44);
			this.buttonDelete.TabIndex = 8;
			this.buttonDelete.Text = "刪除";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// labelArticleID
			// 
			this.labelArticleID.AutoSize = true;
			this.labelArticleID.Location = new System.Drawing.Point(48, 126);
			this.labelArticleID.Name = "labelArticleID";
			this.labelArticleID.Size = new System.Drawing.Size(61, 19);
			this.labelArticleID.TabIndex = 9;
			this.labelArticleID.Text = "文章ID :";
			// 
			// labelLikes
			// 
			this.labelLikes.AutoSize = true;
			this.labelLikes.Location = new System.Drawing.Point(261, 69);
			this.labelLikes.Name = "labelLikes";
			this.labelLikes.Size = new System.Drawing.Size(61, 19);
			this.labelLikes.TabIndex = 10;
			this.labelLikes.Text = "點讚數 :";
			// 
			// labelClicks
			// 
			this.labelClicks.AutoSize = true;
			this.labelClicks.Location = new System.Drawing.Point(413, 69);
			this.labelClicks.Name = "labelClicks";
			this.labelClicks.Size = new System.Drawing.Size(61, 19);
			this.labelClicks.TabIndex = 11;
			this.labelClicks.Text = "點擊數 :";
			// 
			// labelMemberID
			// 
			this.labelMemberID.AutoSize = true;
			this.labelMemberID.Location = new System.Drawing.Point(48, 69);
			this.labelMemberID.Name = "labelMemberID";
			this.labelMemberID.Size = new System.Drawing.Size(61, 19);
			this.labelMemberID.TabIndex = 12;
			this.labelMemberID.Text = "會員ID :";
			// 
			// labelPostingDate
			// 
			this.labelPostingDate.AutoSize = true;
			this.labelPostingDate.Location = new System.Drawing.Point(571, 69);
			this.labelPostingDate.Name = "labelPostingDate";
			this.labelPostingDate.Size = new System.Drawing.Size(76, 19);
			this.labelPostingDate.TabIndex = 13;
			this.labelPostingDate.Text = "發文時間 :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(1233, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 19);
			this.label3.TabIndex = 17;
			this.label3.Text = "已選擇類別";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(986, 141);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 19);
			this.label2.TabIndex = 16;
			this.label2.Text = "新增類別";
			// 
			// dataGridViewLeave
			// 
			this.dataGridViewLeave.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridViewLeave.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewLeave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewLeave.Location = new System.Drawing.Point(947, 182);
			this.dataGridViewLeave.Name = "dataGridViewLeave";
			this.dataGridViewLeave.RowHeadersWidth = 51;
			this.dataGridViewLeave.Size = new System.Drawing.Size(239, 325);
			this.dataGridViewLeave.TabIndex = 14;
			this.dataGridViewLeave.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLeave_CellClick);
			// 
			// dataGridViewUpdate
			// 
			this.dataGridViewUpdate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridViewUpdate.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewUpdate.Location = new System.Drawing.Point(1222, 182);
			this.dataGridViewUpdate.Name = "dataGridViewUpdate";
			this.dataGridViewUpdate.RowHeadersWidth = 51;
			this.dataGridViewUpdate.RowTemplate.Height = 27;
			this.dataGridViewUpdate.Size = new System.Drawing.Size(239, 325);
			this.dataGridViewUpdate.TabIndex = 15;
			this.dataGridViewUpdate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUpdate_CellClick);
			// 
			// FormEditArticle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1496, 566);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridViewLeave);
			this.Controls.Add(this.dataGridViewUpdate);
			this.Controls.Add(this.labelPostingDate);
			this.Controls.Add(this.labelMemberID);
			this.Controls.Add(this.labelClicks);
			this.Controls.Add(this.labelLikes);
			this.Controls.Add(this.labelArticleID);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.textBoxContent);
			this.Controls.Add(this.textBoxTitle);
			this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FormEditArticle";
			this.Text = "編輯文章";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeave)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdate)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}


		#endregion

		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.TextBox textBoxContent;
		private System.Windows.Forms.TextBox textBoxTitle;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label labelClicks;
		private System.Windows.Forms.Label labelLikes;
		private System.Windows.Forms.Label labelArticleID;
		private System.Windows.Forms.Label labelMemberID;
		private System.Windows.Forms.Label labelPostingDate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridViewLeave;
		private System.Windows.Forms.DataGridView dataGridViewUpdate;
	}
}