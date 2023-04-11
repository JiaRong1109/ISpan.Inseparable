namespace ISpan.Inseparable.Win
{
	partial class FormOrders
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
			this.comboBoxMemberID = new System.Windows.Forms.ComboBox();
			this.comboBoxOrderID = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonOrderADD = new System.Windows.Forms.Button();
			this.buttonOrderEdit = new System.Windows.Forms.Button();
			this.buttonOrderDelete = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.buttonProductAdd = new System.Windows.Forms.Button();
			this.buttonProductDelete = new System.Windows.Forms.Button();
			this.buttonProductEdit = new System.Windows.Forms.Button();
			this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
			this.dataGridViewProductDetail = new System.Windows.Forms.DataGridView();
			this.dataGridViewTicketDetail = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.buttonTicketAdd = new System.Windows.Forms.Button();
			this.buttonTicketDelete = new System.Windows.Forms.Button();
			this.buttonTicketEdit = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductDetail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicketDetail)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(21, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "會員編號：";
			// 
			// comboBoxMemberID
			// 
			this.comboBoxMemberID.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxMemberID.FormattingEnabled = true;
			this.comboBoxMemberID.Items.AddRange(new object[] {
            "--請選擇--"});
			this.comboBoxMemberID.Location = new System.Drawing.Point(122, 26);
			this.comboBoxMemberID.Name = "comboBoxMemberID";
			this.comboBoxMemberID.Size = new System.Drawing.Size(152, 30);
			this.comboBoxMemberID.TabIndex = 0;
			this.comboBoxMemberID.SelectedIndexChanged += new System.EventHandler(this.comboBoxMemberID_SelectedIndexChanged);
			// 
			// comboBoxOrderID
			// 
			this.comboBoxOrderID.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxOrderID.FormattingEnabled = true;
			this.comboBoxOrderID.Location = new System.Drawing.Point(394, 26);
			this.comboBoxOrderID.Name = "comboBoxOrderID";
			this.comboBoxOrderID.Size = new System.Drawing.Size(152, 30);
			this.comboBoxOrderID.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(293, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 22);
			this.label2.TabIndex = 2;
			this.label2.Text = "訂單編號：";
			// 
			// buttonSearch
			// 
			this.buttonSearch.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonSearch.Location = new System.Drawing.Point(672, 14);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(76, 44);
			this.buttonSearch.TabIndex = 2;
			this.buttonSearch.Text = "查詢";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonOrderADD);
			this.groupBox1.Controls.Add(this.buttonOrderEdit);
			this.groupBox1.Controls.Add(this.buttonOrderDelete);
			this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.groupBox1.Location = new System.Drawing.Point(14, 83);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(219, 175);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "訂單";
			// 
			// buttonOrderADD
			// 
			this.buttonOrderADD.Location = new System.Drawing.Point(110, 13);
			this.buttonOrderADD.Name = "buttonOrderADD";
			this.buttonOrderADD.Size = new System.Drawing.Size(76, 44);
			this.buttonOrderADD.TabIndex = 0;
			this.buttonOrderADD.Text = "新增";
			this.buttonOrderADD.UseVisualStyleBackColor = true;
			this.buttonOrderADD.Click += new System.EventHandler(this.buttonOrderADD_Click);
			// 
			// buttonOrderEdit
			// 
			this.buttonOrderEdit.Location = new System.Drawing.Point(110, 63);
			this.buttonOrderEdit.Name = "buttonOrderEdit";
			this.buttonOrderEdit.Size = new System.Drawing.Size(76, 44);
			this.buttonOrderEdit.TabIndex = 1;
			this.buttonOrderEdit.Text = "修改";
			this.buttonOrderEdit.UseVisualStyleBackColor = true;
			this.buttonOrderEdit.Click += new System.EventHandler(this.buttonOrderEdit_Click);
			// 
			// buttonOrderDelete
			// 
			this.buttonOrderDelete.Location = new System.Drawing.Point(110, 113);
			this.buttonOrderDelete.Name = "buttonOrderDelete";
			this.buttonOrderDelete.Size = new System.Drawing.Size(76, 44);
			this.buttonOrderDelete.TabIndex = 2;
			this.buttonOrderDelete.Text = "刪除";
			this.buttonOrderDelete.UseVisualStyleBackColor = true;
			this.buttonOrderDelete.Click += new System.EventHandler(this.buttonOrderDelete_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.buttonProductAdd);
			this.groupBox2.Controls.Add(this.buttonProductDelete);
			this.groupBox2.Controls.Add(this.buttonProductEdit);
			this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.groupBox2.Location = new System.Drawing.Point(14, 296);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(219, 175);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "產品訂單明細";
			// 
			// buttonProductAdd
			// 
			this.buttonProductAdd.Location = new System.Drawing.Point(108, 13);
			this.buttonProductAdd.Name = "buttonProductAdd";
			this.buttonProductAdd.Size = new System.Drawing.Size(76, 44);
			this.buttonProductAdd.TabIndex = 0;
			this.buttonProductAdd.Text = "新增";
			this.buttonProductAdd.UseVisualStyleBackColor = true;
			this.buttonProductAdd.Click += new System.EventHandler(this.buttonProductAdd_Click);
			// 
			// buttonProductDelete
			// 
			this.buttonProductDelete.Location = new System.Drawing.Point(108, 113);
			this.buttonProductDelete.Name = "buttonProductDelete";
			this.buttonProductDelete.Size = new System.Drawing.Size(76, 44);
			this.buttonProductDelete.TabIndex = 2;
			this.buttonProductDelete.Text = "刪除";
			this.buttonProductDelete.UseVisualStyleBackColor = true;
			this.buttonProductDelete.Click += new System.EventHandler(this.buttonProductDelete_Click);
			// 
			// buttonProductEdit
			// 
			this.buttonProductEdit.Location = new System.Drawing.Point(108, 63);
			this.buttonProductEdit.Name = "buttonProductEdit";
			this.buttonProductEdit.Size = new System.Drawing.Size(76, 44);
			this.buttonProductEdit.TabIndex = 1;
			this.buttonProductEdit.Text = "修改";
			this.buttonProductEdit.UseVisualStyleBackColor = true;
			this.buttonProductEdit.Click += new System.EventHandler(this.buttonProductEdit_Click);
			// 
			// dataGridViewOrder
			// 
			this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewOrder.Location = new System.Drawing.Point(263, 83);
			this.dataGridViewOrder.Name = "dataGridViewOrder";
			this.dataGridViewOrder.RowHeadersWidth = 51;
			this.dataGridViewOrder.RowTemplate.Height = 27;
			this.dataGridViewOrder.Size = new System.Drawing.Size(917, 207);
			this.dataGridViewOrder.TabIndex = 7;
			this.dataGridViewOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrder_CellClick);
			// 
			// dataGridViewProductDetail
			// 
			this.dataGridViewProductDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewProductDetail.Location = new System.Drawing.Point(263, 296);
			this.dataGridViewProductDetail.Name = "dataGridViewProductDetail";
			this.dataGridViewProductDetail.RowHeadersWidth = 51;
			this.dataGridViewProductDetail.RowTemplate.Height = 27;
			this.dataGridViewProductDetail.Size = new System.Drawing.Size(917, 207);
			this.dataGridViewProductDetail.TabIndex = 8;
			// 
			// dataGridViewTicketDetail
			// 
			this.dataGridViewTicketDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTicketDetail.Location = new System.Drawing.Point(263, 509);
			this.dataGridViewTicketDetail.Name = "dataGridViewTicketDetail";
			this.dataGridViewTicketDetail.RowHeadersWidth = 51;
			this.dataGridViewTicketDetail.RowTemplate.Height = 27;
			this.dataGridViewTicketDetail.Size = new System.Drawing.Size(917, 207);
			this.dataGridViewTicketDetail.TabIndex = 18;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.buttonTicketAdd);
			this.groupBox3.Controls.Add(this.buttonTicketDelete);
			this.groupBox3.Controls.Add(this.buttonTicketEdit);
			this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.groupBox3.Location = new System.Drawing.Point(14, 509);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(219, 175);
			this.groupBox3.TabIndex = 17;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "票券訂單明細";
			// 
			// buttonTicketAdd
			// 
			this.buttonTicketAdd.Location = new System.Drawing.Point(108, 13);
			this.buttonTicketAdd.Name = "buttonTicketAdd";
			this.buttonTicketAdd.Size = new System.Drawing.Size(76, 44);
			this.buttonTicketAdd.TabIndex = 0;
			this.buttonTicketAdd.Text = "新增";
			this.buttonTicketAdd.UseVisualStyleBackColor = true;
			this.buttonTicketAdd.Click += new System.EventHandler(this.buttonTicketAdd_Click);
			// 
			// buttonTicketDelete
			// 
			this.buttonTicketDelete.Location = new System.Drawing.Point(108, 113);
			this.buttonTicketDelete.Name = "buttonTicketDelete";
			this.buttonTicketDelete.Size = new System.Drawing.Size(76, 44);
			this.buttonTicketDelete.TabIndex = 2;
			this.buttonTicketDelete.Text = "刪除";
			this.buttonTicketDelete.UseVisualStyleBackColor = true;
			this.buttonTicketDelete.Click += new System.EventHandler(this.buttonTicketDelete_Click);
			// 
			// buttonTicketEdit
			// 
			this.buttonTicketEdit.Location = new System.Drawing.Point(108, 63);
			this.buttonTicketEdit.Name = "buttonTicketEdit";
			this.buttonTicketEdit.Size = new System.Drawing.Size(76, 44);
			this.buttonTicketEdit.TabIndex = 1;
			this.buttonTicketEdit.Text = "修改";
			this.buttonTicketEdit.UseVisualStyleBackColor = true;
			this.buttonTicketEdit.Click += new System.EventHandler(this.buttonTicketEdit_Click);
			// 
			// FormOrders
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.ClientSize = new System.Drawing.Size(1221, 728);
			this.Controls.Add(this.dataGridViewTicketDetail);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.dataGridViewProductDetail);
			this.Controls.Add(this.dataGridViewOrder);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.comboBoxOrderID);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBoxMemberID);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormOrders";
			this.Text = "訂單維護";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductDetail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicketDetail)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxMemberID;
		private System.Windows.Forms.ComboBox comboBoxOrderID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonOrderADD;
		private System.Windows.Forms.Button buttonOrderEdit;
		private System.Windows.Forms.Button buttonOrderDelete;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button buttonProductAdd;
		private System.Windows.Forms.Button buttonProductDelete;
		private System.Windows.Forms.Button buttonProductEdit;
		private System.Windows.Forms.DataGridView dataGridViewOrder;
		private System.Windows.Forms.DataGridView dataGridViewProductDetail;
		private System.Windows.Forms.DataGridView dataGridViewTicketDetail;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button buttonTicketAdd;
		private System.Windows.Forms.Button buttonTicketDelete;
		private System.Windows.Forms.Button buttonTicketEdit;
	}
}