namespace ISpan.Inseparable.Win
{
	partial class FormEditComment
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
			this.labelPostingDate = new System.Windows.Forms.Label();
			this.labelMemberID = new System.Windows.Forms.Label();
			this.labelLikes = new System.Windows.Forms.Label();
			this.labelArticleID = new System.Windows.Forms.Label();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.textBoxContent = new System.Windows.Forms.TextBox();
			this.labelItemNumber = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// labelPostingDate
			// 
			this.labelPostingDate.AutoSize = true;
			this.labelPostingDate.Location = new System.Drawing.Point(138, 139);
			this.labelPostingDate.Name = "labelPostingDate";
			this.labelPostingDate.Size = new System.Drawing.Size(76, 19);
			this.labelPostingDate.TabIndex = 23;
			this.labelPostingDate.Text = "留言時間 :";
			// 
			// labelMemberID
			// 
			this.labelMemberID.AutoSize = true;
			this.labelMemberID.Location = new System.Drawing.Point(344, 96);
			this.labelMemberID.Name = "labelMemberID";
			this.labelMemberID.Size = new System.Drawing.Size(61, 19);
			this.labelMemberID.TabIndex = 22;
			this.labelMemberID.Text = "會員ID :";
			// 
			// labelLikes
			// 
			this.labelLikes.AutoSize = true;
			this.labelLikes.Location = new System.Drawing.Point(500, 96);
			this.labelLikes.Name = "labelLikes";
			this.labelLikes.Size = new System.Drawing.Size(61, 19);
			this.labelLikes.TabIndex = 20;
			this.labelLikes.Text = "點讚數 :";
			// 
			// labelArticleID
			// 
			this.labelArticleID.AutoSize = true;
			this.labelArticleID.Location = new System.Drawing.Point(138, 96);
			this.labelArticleID.Name = "labelArticleID";
			this.labelArticleID.Size = new System.Drawing.Size(61, 19);
			this.labelArticleID.TabIndex = 19;
			this.labelArticleID.Text = "文章ID :";
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(700, 96);
			this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(96, 44);
			this.buttonDelete.TabIndex = 18;
			this.buttonDelete.Text = "刪除";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(603, 96);
			this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(90, 44);
			this.buttonUpdate.TabIndex = 16;
			this.buttonUpdate.Text = "修改";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// textBoxContent
			// 
			this.textBoxContent.Location = new System.Drawing.Point(127, 189);
			this.textBoxContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxContent.Multiline = true;
			this.textBoxContent.Name = "textBoxContent";
			this.textBoxContent.Size = new System.Drawing.Size(668, 326);
			this.textBoxContent.TabIndex = 15;
			// 
			// labelItemNumber
			// 
			this.labelItemNumber.AutoSize = true;
			this.labelItemNumber.Location = new System.Drawing.Point(251, 96);
			this.labelItemNumber.Name = "labelItemNumber";
			this.labelItemNumber.Size = new System.Drawing.Size(46, 19);
			this.labelItemNumber.TabIndex = 24;
			this.labelItemNumber.Text = "項次 :";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FormEditComment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(900, 570);
			this.Controls.Add(this.labelItemNumber);
			this.Controls.Add(this.labelPostingDate);
			this.Controls.Add(this.labelMemberID);
			this.Controls.Add(this.labelLikes);
			this.Controls.Add(this.labelArticleID);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.textBoxContent);
			this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FormEditComment";
			this.Text = "編輯留言";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelPostingDate;
		private System.Windows.Forms.Label labelMemberID;
		private System.Windows.Forms.Label labelLikes;
		private System.Windows.Forms.Label labelArticleID;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.TextBox textBoxContent;
		private System.Windows.Forms.Label labelItemNumber;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}