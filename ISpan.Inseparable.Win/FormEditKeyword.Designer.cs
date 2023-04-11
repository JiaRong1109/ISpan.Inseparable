namespace ISpan.Inseparable.Win
{
	partial class FormEditKeyword
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
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.textBoxKeywordName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(314, 103);
			this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(99, 46);
			this.buttonUpdate.TabIndex = 8;
			this.buttonUpdate.Text = "修改";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// textBoxKeywordName
			// 
			this.textBoxKeywordName.Location = new System.Drawing.Point(169, 114);
			this.textBoxKeywordName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxKeywordName.Name = "textBoxKeywordName";
			this.textBoxKeywordName.Size = new System.Drawing.Size(112, 27);
			this.textBoxKeywordName.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(87, 117);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 19);
			this.label1.TabIndex = 6;
			this.label1.Text = "類別名稱 :";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FormEditKeyword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 254);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.textBoxKeywordName);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FormEditKeyword";
			this.Text = "FormUpdateArticleCategory";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.TextBox textBoxKeywordName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}