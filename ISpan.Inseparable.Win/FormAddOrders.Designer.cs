namespace ISpan.Inseparable.Win
{
	partial class FormAddOrders
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
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxMember = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.labelOrderDate = new System.Windows.Forms.Label();
			this.labelModifiedDate = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.comboBoxCinema = new System.Windows.Forms.ComboBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(12, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "客戶：";
			// 
			// comboBoxMember
			// 
			this.comboBoxMember.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxMember.FormattingEnabled = true;
			this.comboBoxMember.Items.AddRange(new object[] {
            "--請選擇--"});
			this.comboBoxMember.Location = new System.Drawing.Point(92, 41);
			this.comboBoxMember.Name = "comboBoxMember";
			this.comboBoxMember.Size = new System.Drawing.Size(222, 27);
			this.comboBoxMember.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(12, 115);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "訂購日期：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(12, 158);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "修改日期：";
			// 
			// labelOrderDate
			// 
			this.labelOrderDate.AutoSize = true;
			this.labelOrderDate.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelOrderDate.Location = new System.Drawing.Point(102, 115);
			this.labelOrderDate.Name = "labelOrderDate";
			this.labelOrderDate.Size = new System.Drawing.Size(0, 19);
			this.labelOrderDate.TabIndex = 3;
			// 
			// labelModifiedDate
			// 
			this.labelModifiedDate.AutoSize = true;
			this.labelModifiedDate.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelModifiedDate.Location = new System.Drawing.Point(102, 158);
			this.labelModifiedDate.Name = "labelModifiedDate";
			this.labelModifiedDate.Size = new System.Drawing.Size(0, 19);
			this.labelModifiedDate.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(12, 77);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 19);
			this.label4.TabIndex = 0;
			this.label4.Text = "影城：";
			// 
			// buttonAdd
			// 
			this.buttonAdd.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonAdd.Location = new System.Drawing.Point(211, 184);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(72, 45);
			this.buttonAdd.TabIndex = 2;
			this.buttonAdd.Text = "新增";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// comboBoxCinema
			// 
			this.comboBoxCinema.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxCinema.FormattingEnabled = true;
			this.comboBoxCinema.Items.AddRange(new object[] {
            "--請選擇--"});
			this.comboBoxCinema.Location = new System.Drawing.Point(92, 74);
			this.comboBoxCinema.Name = "comboBoxCinema";
			this.comboBoxCinema.Size = new System.Drawing.Size(222, 27);
			this.comboBoxCinema.TabIndex = 1;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FormAddOrders
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(348, 254);
			this.Controls.Add(this.comboBoxCinema);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.labelModifiedDate);
			this.Controls.Add(this.labelOrderDate);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboBoxMember);
			this.Controls.Add(this.label1);
			this.Name = "FormAddOrders";
			this.Text = "訂單新增";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxMember;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label labelOrderDate;
		private System.Windows.Forms.Label labelModifiedDate;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.ComboBox comboBoxCinema;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}