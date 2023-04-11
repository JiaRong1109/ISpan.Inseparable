namespace ISpan.Inseparable.Win
{
	partial class FormCreateComment
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
			this.buttonCreate = new System.Windows.Forms.Button();
			this.textBoxContent = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxMemberID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxArticleID = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonCreate
			// 
			this.buttonCreate.Location = new System.Drawing.Point(640, 28);
			this.buttonCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonCreate.Name = "buttonCreate";
			this.buttonCreate.Size = new System.Drawing.Size(144, 44);
			this.buttonCreate.TabIndex = 6;
			this.buttonCreate.Text = "留言";
			this.buttonCreate.UseVisualStyleBackColor = true;
			this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
			// 
			// textBoxContent
			// 
			this.textBoxContent.Location = new System.Drawing.Point(116, 101);
			this.textBoxContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxContent.Multiline = true;
			this.textBoxContent.Name = "textBoxContent";
			this.textBoxContent.Size = new System.Drawing.Size(668, 416);
			this.textBoxContent.TabIndex = 5;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(130, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 19);
			this.label1.TabIndex = 7;
			this.label1.Text = "會員ID :";
			// 
			// textBoxMemberID
			// 
			this.textBoxMemberID.Location = new System.Drawing.Point(197, 38);
			this.textBoxMemberID.Name = "textBoxMemberID";
			this.textBoxMemberID.Size = new System.Drawing.Size(166, 27);
			this.textBoxMemberID.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(373, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 19);
			this.label2.TabIndex = 7;
			this.label2.Text = "文章ID :";
			// 
			// textBoxArticleID
			// 
			this.textBoxArticleID.Location = new System.Drawing.Point(440, 38);
			this.textBoxArticleID.Name = "textBoxArticleID";
			this.textBoxArticleID.Size = new System.Drawing.Size(166, 27);
			this.textBoxArticleID.TabIndex = 8;
			// 
			// FormCreateComment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(900, 570);
			this.Controls.Add(this.textBoxArticleID);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxMemberID);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonCreate);
			this.Controls.Add(this.textBoxContent);
			this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FormCreateComment";
			this.Text = "新增留言";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonCreate;
		private System.Windows.Forms.TextBox textBoxContent;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.TextBox textBoxMemberID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxArticleID;
		private System.Windows.Forms.Label label2;
	}
}