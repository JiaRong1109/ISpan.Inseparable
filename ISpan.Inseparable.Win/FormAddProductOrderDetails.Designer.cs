namespace ISpan.Inseparable.Win
{
	partial class FormAddProductOrderDetails
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
			this.buttonAdd = new System.Windows.Forms.Button();
			this.labelOrderID = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.labelMember = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.comboBoxProduct = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.labelCinema = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.labelModifiedTime = new System.Windows.Forms.Label();
			this.labelPrice = new System.Windows.Forms.Label();
			this.textBoxQty = new System.Windows.Forms.TextBox();
			this.textBoxDiscount = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonAdd
			// 
			this.buttonAdd.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonAdd.Location = new System.Drawing.Point(286, 260);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(72, 45);
			this.buttonAdd.TabIndex = 3;
			this.buttonAdd.Text = "新增";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// labelOrderID
			// 
			this.labelOrderID.AutoSize = true;
			this.labelOrderID.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelOrderID.Location = new System.Drawing.Point(110, 39);
			this.labelOrderID.Name = "labelOrderID";
			this.labelOrderID.Size = new System.Drawing.Size(0, 19);
			this.labelOrderID.TabIndex = 27;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.Location = new System.Drawing.Point(26, 39);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 19);
			this.label5.TabIndex = 26;
			this.label5.Text = "訂單ID：";
			// 
			// labelMember
			// 
			this.labelMember.AutoSize = true;
			this.labelMember.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelMember.Location = new System.Drawing.Point(110, 68);
			this.labelMember.Name = "labelMember";
			this.labelMember.Size = new System.Drawing.Size(0, 19);
			this.labelMember.TabIndex = 25;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(367, 290);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(0, 15);
			this.label6.TabIndex = 24;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label8.Location = new System.Drawing.Point(26, 310);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(84, 19);
			this.label8.TabIndex = 21;
			this.label8.Text = "修改日期：";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label10.Location = new System.Drawing.Point(26, 97);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(54, 19);
			this.label10.TabIndex = 18;
			this.label10.Text = "影城：";
			// 
			// comboBoxProduct
			// 
			this.comboBoxProduct.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxProduct.FormattingEnabled = true;
			this.comboBoxProduct.Items.AddRange(new object[] {
            "--請選擇--"});
			this.comboBoxProduct.Location = new System.Drawing.Point(110, 123);
			this.comboBoxProduct.Name = "comboBoxProduct";
			this.comboBoxProduct.Size = new System.Drawing.Size(248, 27);
			this.comboBoxProduct.TabIndex = 0;
			this.comboBoxProduct.SelectedIndexChanged += new System.EventHandler(this.comboBoxProduct_SelectedIndexChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label11.Location = new System.Drawing.Point(26, 68);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(54, 19);
			this.label11.TabIndex = 19;
			this.label11.Text = "客戶：";
			// 
			// labelCinema
			// 
			this.labelCinema.AutoSize = true;
			this.labelCinema.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelCinema.Location = new System.Drawing.Point(110, 97);
			this.labelCinema.Name = "labelCinema";
			this.labelCinema.Size = new System.Drawing.Size(0, 19);
			this.labelCinema.TabIndex = 28;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(26, 126);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 19);
			this.label2.TabIndex = 29;
			this.label2.Text = "產品：";
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label.Location = new System.Drawing.Point(26, 160);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(54, 19);
			this.label.TabIndex = 19;
			this.label.Text = "單價：";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(26, 194);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 19);
			this.label4.TabIndex = 18;
			this.label4.Text = "數量：";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label9.Location = new System.Drawing.Point(26, 230);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(54, 19);
			this.label9.TabIndex = 29;
			this.label9.Text = "折扣：";
			// 
			// labelModifiedTime
			// 
			this.labelModifiedTime.AutoSize = true;
			this.labelModifiedTime.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelModifiedTime.Location = new System.Drawing.Point(115, 310);
			this.labelModifiedTime.Name = "labelModifiedTime";
			this.labelModifiedTime.Size = new System.Drawing.Size(0, 19);
			this.labelModifiedTime.TabIndex = 33;
			// 
			// labelPrice
			// 
			this.labelPrice.AutoSize = true;
			this.labelPrice.Cursor = System.Windows.Forms.Cursors.Default;
			this.labelPrice.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelPrice.Location = new System.Drawing.Point(110, 160);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(0, 19);
			this.labelPrice.TabIndex = 30;
			// 
			// textBoxQty
			// 
			this.textBoxQty.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxQty.Location = new System.Drawing.Point(110, 191);
			this.textBoxQty.Name = "textBoxQty";
			this.textBoxQty.Size = new System.Drawing.Size(248, 27);
			this.textBoxQty.TabIndex = 1;
			// 
			// textBoxDiscount
			// 
			this.textBoxDiscount.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxDiscount.Location = new System.Drawing.Point(110, 227);
			this.textBoxDiscount.Name = "textBoxDiscount";
			this.textBoxDiscount.Size = new System.Drawing.Size(248, 27);
			this.textBoxDiscount.TabIndex = 2;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FormAddProductOrderDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(370, 351);
			this.Controls.Add(this.textBoxDiscount);
			this.Controls.Add(this.textBoxQty);
			this.Controls.Add(this.labelModifiedTime);
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelCinema);
			this.Controls.Add(this.labelOrderID);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.labelMember);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.comboBoxProduct);
			this.Controls.Add(this.label);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.buttonAdd);
			this.Name = "FormAddProductOrderDetails";
			this.Text = "產品訂單明細新增";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Label labelOrderID;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label labelMember;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox comboBoxProduct;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label labelCinema;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label labelModifiedTime;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.TextBox textBoxQty;
		private System.Windows.Forms.TextBox textBoxDiscount;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}