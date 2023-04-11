namespace ISpan.Inseparable.Win
{
	partial class FormProducts
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
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxCategory = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxCinema = new System.Windows.Forms.ComboBox();
			this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.groupBoxProduct = new System.Windows.Forms.GroupBox();
			this.pictureBoxProduct = new System.Windows.Forms.PictureBox();
			this.label16 = new System.Windows.Forms.Label();
			this.labelCinema = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.labelQty = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.labelPrice = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.labelCategory = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.labelID = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonCategory = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
			this.groupBoxProduct.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(29, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "產品名稱：";
			// 
			// comboBoxCategory
			// 
			this.comboBoxCategory.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxCategory.FormattingEnabled = true;
			this.comboBoxCategory.Items.AddRange(new object[] {
            "--請選擇類別--"});
			this.comboBoxCategory.Location = new System.Drawing.Point(140, 77);
			this.comboBoxCategory.Name = "comboBoxCategory";
			this.comboBoxCategory.Size = new System.Drawing.Size(144, 30);
			this.comboBoxCategory.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(29, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 22);
			this.label2.TabIndex = 2;
			this.label2.Text = "產品類別：";
			// 
			// textBoxName
			// 
			this.textBoxName.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxName.Location = new System.Drawing.Point(140, 26);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(144, 30);
			this.textBoxName.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(29, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 22);
			this.label3.TabIndex = 5;
			this.label3.Text = "影城名稱：";
			// 
			// comboBoxCinema
			// 
			this.comboBoxCinema.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxCinema.FormattingEnabled = true;
			this.comboBoxCinema.Items.AddRange(new object[] {
            "--請選擇影城--"});
			this.comboBoxCinema.Location = new System.Drawing.Point(140, 128);
			this.comboBoxCinema.Name = "comboBoxCinema";
			this.comboBoxCinema.Size = new System.Drawing.Size(144, 30);
			this.comboBoxCinema.TabIndex = 2;
			// 
			// dataGridViewProduct
			// 
			this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewProduct.Location = new System.Drawing.Point(21, 177);
			this.dataGridViewProduct.Name = "dataGridViewProduct";
			this.dataGridViewProduct.RowHeadersWidth = 66;
			this.dataGridViewProduct.RowTemplate.Height = 32;
			this.dataGridViewProduct.Size = new System.Drawing.Size(667, 380);
			this.dataGridViewProduct.TabIndex = 6;
			this.dataGridViewProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_CellClick);
			// 
			// buttonSearch
			// 
			this.buttonSearch.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonSearch.Location = new System.Drawing.Point(588, 114);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(100, 41);
			this.buttonSearch.TabIndex = 3;
			this.buttonSearch.Text = "查詢";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// groupBoxProduct
			// 
			this.groupBoxProduct.Controls.Add(this.pictureBoxProduct);
			this.groupBoxProduct.Controls.Add(this.label16);
			this.groupBoxProduct.Controls.Add(this.labelCinema);
			this.groupBoxProduct.Controls.Add(this.label14);
			this.groupBoxProduct.Controls.Add(this.labelQty);
			this.groupBoxProduct.Controls.Add(this.label12);
			this.groupBoxProduct.Controls.Add(this.labelPrice);
			this.groupBoxProduct.Controls.Add(this.label10);
			this.groupBoxProduct.Controls.Add(this.labelCategory);
			this.groupBoxProduct.Controls.Add(this.label8);
			this.groupBoxProduct.Controls.Add(this.labelName);
			this.groupBoxProduct.Controls.Add(this.label6);
			this.groupBoxProduct.Controls.Add(this.labelID);
			this.groupBoxProduct.Controls.Add(this.label4);
			this.groupBoxProduct.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.groupBoxProduct.Location = new System.Drawing.Point(713, 56);
			this.groupBoxProduct.Name = "groupBoxProduct";
			this.groupBoxProduct.Size = new System.Drawing.Size(434, 557);
			this.groupBoxProduct.TabIndex = 8;
			this.groupBoxProduct.TabStop = false;
			this.groupBoxProduct.Text = "產品資訊";
			// 
			// pictureBoxProduct
			// 
			this.pictureBoxProduct.Location = new System.Drawing.Point(148, 278);
			this.pictureBoxProduct.Name = "pictureBoxProduct";
			this.pictureBoxProduct.Size = new System.Drawing.Size(216, 245);
			this.pictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxProduct.TabIndex = 22;
			this.pictureBoxProduct.TabStop = false;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(39, 278);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(61, 22);
			this.label16.TabIndex = 21;
			this.label16.Text = "圖片：";
			// 
			// labelCinema
			// 
			this.labelCinema.AutoSize = true;
			this.labelCinema.Location = new System.Drawing.Point(195, 243);
			this.labelCinema.Name = "labelCinema";
			this.labelCinema.Size = new System.Drawing.Size(0, 22);
			this.labelCinema.TabIndex = 20;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(39, 240);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(61, 22);
			this.label14.TabIndex = 19;
			this.label14.Text = "影城：";
			// 
			// labelQty
			// 
			this.labelQty.AutoSize = true;
			this.labelQty.Location = new System.Drawing.Point(195, 205);
			this.labelQty.Name = "labelQty";
			this.labelQty.Size = new System.Drawing.Size(0, 22);
			this.labelQty.TabIndex = 18;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(39, 202);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(78, 22);
			this.label12.TabIndex = 17;
			this.label12.Text = "庫存量：";
			// 
			// labelPrice
			// 
			this.labelPrice.AutoSize = true;
			this.labelPrice.Location = new System.Drawing.Point(195, 165);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(0, 22);
			this.labelPrice.TabIndex = 16;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(39, 164);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(61, 22);
			this.label10.TabIndex = 15;
			this.label10.Text = "價格：";
			// 
			// labelCategory
			// 
			this.labelCategory.AutoSize = true;
			this.labelCategory.Location = new System.Drawing.Point(195, 128);
			this.labelCategory.Name = "labelCategory";
			this.labelCategory.Size = new System.Drawing.Size(0, 22);
			this.labelCategory.TabIndex = 14;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(39, 126);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(95, 22);
			this.label8.TabIndex = 13;
			this.label8.Text = "產品類別：";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(195, 89);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(0, 22);
			this.labelName.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(39, 88);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(95, 22);
			this.label6.TabIndex = 11;
			this.label6.Text = "產品名稱：";
			// 
			// labelID
			// 
			this.labelID.AutoSize = true;
			this.labelID.Location = new System.Drawing.Point(195, 50);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(0, 22);
			this.labelID.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(39, 50);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 22);
			this.label4.TabIndex = 9;
			this.label4.Text = "產品ID：";
			// 
			// buttonAdd
			// 
			this.buttonAdd.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonAdd.Location = new System.Drawing.Point(340, 572);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(100, 41);
			this.buttonAdd.TabIndex = 4;
			this.buttonAdd.Text = "新增";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonEdit
			// 
			this.buttonEdit.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonEdit.Location = new System.Drawing.Point(464, 572);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(100, 41);
			this.buttonEdit.TabIndex = 5;
			this.buttonEdit.Text = "修改";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonDelete.Location = new System.Drawing.Point(588, 572);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(100, 41);
			this.buttonDelete.TabIndex = 6;
			this.buttonDelete.Text = "刪除";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonCategory
			// 
			this.buttonCategory.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonCategory.Location = new System.Drawing.Point(1037, 12);
			this.buttonCategory.Name = "buttonCategory";
			this.buttonCategory.Size = new System.Drawing.Size(110, 41);
			this.buttonCategory.TabIndex = 7;
			this.buttonCategory.Text = "類別維護";
			this.buttonCategory.UseVisualStyleBackColor = true;
			this.buttonCategory.Click += new System.EventHandler(this.buttonCategory_Click);
			// 
			// FormProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.ClientSize = new System.Drawing.Size(1187, 637);
			this.Controls.Add(this.buttonCategory);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.groupBoxProduct);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.dataGridViewProduct);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBoxCinema);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBoxCategory);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FormProducts";
			this.Text = "產品維護";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
			this.groupBoxProduct.ResumeLayout(false);
			this.groupBoxProduct.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxCategory;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBoxCinema;
		private System.Windows.Forms.DataGridView dataGridViewProduct;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.GroupBox groupBoxProduct;
		private System.Windows.Forms.PictureBox pictureBoxProduct;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label labelCinema;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label labelQty;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label labelCategory;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label labelID;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonCategory;
	}
}