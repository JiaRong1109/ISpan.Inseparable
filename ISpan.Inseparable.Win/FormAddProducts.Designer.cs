namespace ISpan.Inseparable.Win
{
	partial class FormAddProducts
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
			this.buttonSelectImage = new System.Windows.Forms.Button();
			this.pictureBoxProduct = new System.Windows.Forms.PictureBox();
			this.textBoxQty = new System.Windows.Forms.TextBox();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.comboBoxCinema = new System.Windows.Forms.ComboBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.comboBoxCategory = new System.Windows.Forms.ComboBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonAdd
			// 
			this.buttonAdd.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonAdd.Location = new System.Drawing.Point(282, 323);
			this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(63, 30);
			this.buttonAdd.TabIndex = 6;
			this.buttonAdd.Text = "新增";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonSelectImage
			// 
			this.buttonSelectImage.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonSelectImage.Location = new System.Drawing.Point(199, 323);
			this.buttonSelectImage.Margin = new System.Windows.Forms.Padding(2);
			this.buttonSelectImage.Name = "buttonSelectImage";
			this.buttonSelectImage.Size = new System.Drawing.Size(78, 30);
			this.buttonSelectImage.TabIndex = 5;
			this.buttonSelectImage.Text = "選擇圖片";
			this.buttonSelectImage.UseVisualStyleBackColor = true;
			this.buttonSelectImage.Click += new System.EventHandler(this.buttonSelectImage_Click);
			// 
			// pictureBoxProduct
			// 
			this.pictureBoxProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBoxProduct.Location = new System.Drawing.Point(115, 182);
			this.pictureBoxProduct.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBoxProduct.Name = "pictureBoxProduct";
			this.pictureBoxProduct.Size = new System.Drawing.Size(230, 133);
			this.pictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxProduct.TabIndex = 47;
			this.pictureBoxProduct.TabStop = false;
			// 
			// textBoxQty
			// 
			this.textBoxQty.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxQty.Location = new System.Drawing.Point(115, 111);
			this.textBoxQty.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxQty.Name = "textBoxQty";
			this.textBoxQty.Size = new System.Drawing.Size(230, 27);
			this.textBoxQty.TabIndex = 3;
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxPrice.Location = new System.Drawing.Point(115, 78);
			this.textBoxPrice.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.Size = new System.Drawing.Size(230, 27);
			this.textBoxPrice.TabIndex = 2;
			// 
			// comboBoxCinema
			// 
			this.comboBoxCinema.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxCinema.FormattingEnabled = true;
			this.comboBoxCinema.Items.AddRange(new object[] {
            "--請選擇--"});
			this.comboBoxCinema.Location = new System.Drawing.Point(115, 143);
			this.comboBoxCinema.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxCinema.Name = "comboBoxCinema";
			this.comboBoxCinema.Size = new System.Drawing.Size(230, 27);
			this.comboBoxCinema.TabIndex = 4;
			// 
			// textBoxName
			// 
			this.textBoxName.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxName.Location = new System.Drawing.Point(115, 13);
			this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(230, 27);
			this.textBoxName.TabIndex = 0;
			// 
			// comboBoxCategory
			// 
			this.comboBoxCategory.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxCategory.FormattingEnabled = true;
			this.comboBoxCategory.Items.AddRange(new object[] {
            "--請選擇--"});
			this.comboBoxCategory.Location = new System.Drawing.Point(115, 46);
			this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxCategory.Name = "comboBoxCategory";
			this.comboBoxCategory.Size = new System.Drawing.Size(230, 27);
			this.comboBoxCategory.TabIndex = 1;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label16.Location = new System.Drawing.Point(23, 182);
			this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(54, 19);
			this.label16.TabIndex = 41;
			this.label16.Text = "圖片：";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label14.Location = new System.Drawing.Point(23, 143);
			this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(54, 19);
			this.label14.TabIndex = 40;
			this.label14.Text = "影城：";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label12.Location = new System.Drawing.Point(23, 111);
			this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(69, 19);
			this.label12.TabIndex = 39;
			this.label12.Text = "庫存量：";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label10.Location = new System.Drawing.Point(23, 78);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(54, 19);
			this.label10.TabIndex = 38;
			this.label10.Text = "價格：";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label8.Location = new System.Drawing.Point(23, 46);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(84, 19);
			this.label8.TabIndex = 37;
			this.label8.Text = "產品類別：";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.Location = new System.Drawing.Point(23, 13);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(84, 19);
			this.label6.TabIndex = 36;
			this.label6.Text = "產品名稱：";
			// 
			// openFileDialogImage
			// 
			this.openFileDialogImage.FileName = "openFileDialog1";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FormAddProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(391, 358);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.buttonSelectImage);
			this.Controls.Add(this.pictureBoxProduct);
			this.Controls.Add(this.textBoxQty);
			this.Controls.Add(this.textBoxPrice);
			this.Controls.Add(this.comboBoxCinema);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.comboBoxCategory);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label6);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormAddProducts";
			this.Text = "產品新增";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonSelectImage;
		private System.Windows.Forms.PictureBox pictureBoxProduct;
		private System.Windows.Forms.TextBox textBoxQty;
		private System.Windows.Forms.TextBox textBoxPrice;
		private System.Windows.Forms.ComboBox comboBoxCinema;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.ComboBox comboBoxCategory;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.OpenFileDialog openFileDialogImage;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}