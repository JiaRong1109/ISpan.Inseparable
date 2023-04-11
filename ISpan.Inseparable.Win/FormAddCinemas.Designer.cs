namespace ISpan.Inseparable.Win
{
	partial class FormAddCinemas
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxAddress = new System.Windows.Forms.TextBox();
			this.textBoxTel = new System.Windows.Forms.TextBox();
			this.comboBoxCountry = new System.Windows.Forms.ComboBox();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(24, 51);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "影城名稱：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(24, 86);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "地區：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(24, 133);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "地址：";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(24, 193);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 19);
			this.label4.TabIndex = 3;
			this.label4.Text = "電話：";
			// 
			// textBoxName
			// 
			this.textBoxName.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxName.Location = new System.Drawing.Point(113, 51);
			this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(181, 27);
			this.textBoxName.TabIndex = 0;
			// 
			// textBoxAddress
			// 
			this.textBoxAddress.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxAddress.Location = new System.Drawing.Point(113, 119);
			this.textBoxAddress.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxAddress.Multiline = true;
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.Size = new System.Drawing.Size(181, 62);
			this.textBoxAddress.TabIndex = 2;
			// 
			// textBoxTel
			// 
			this.textBoxTel.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxTel.Location = new System.Drawing.Point(113, 193);
			this.textBoxTel.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxTel.Name = "textBoxTel";
			this.textBoxTel.Size = new System.Drawing.Size(181, 27);
			this.textBoxTel.TabIndex = 3;
			// 
			// comboBoxCountry
			// 
			this.comboBoxCountry.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxCountry.FormattingEnabled = true;
			this.comboBoxCountry.Items.AddRange(new object[] {
            "--請選擇--",
            "基隆市",
            "臺北市",
            "新北市",
            "桃園市",
            "新竹市",
            "新竹縣",
            "苗栗縣",
            "臺中市",
            "彰化縣",
            "南投縣",
            "雲林縣",
            "嘉義市",
            "嘉義縣",
            "臺南市",
            "高雄市",
            "屏東縣",
            "宜蘭縣",
            "花蓮縣",
            "臺東縣",
            "澎湖縣",
            "金門縣",
            "連江縣"});
			this.comboBoxCountry.Location = new System.Drawing.Point(113, 87);
			this.comboBoxCountry.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxCountry.Name = "comboBoxCountry";
			this.comboBoxCountry.Size = new System.Drawing.Size(181, 27);
			this.comboBoxCountry.TabIndex = 1;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonAdd.Location = new System.Drawing.Point(232, 245);
			this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(62, 35);
			this.buttonAdd.TabIndex = 4;
			this.buttonAdd.Text = "新增";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FormAddCinemas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(332, 327);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.comboBoxCountry);
			this.Controls.Add(this.textBoxTel);
			this.Controls.Add(this.textBoxAddress);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormAddCinemas";
			this.Text = "影城新增";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxAddress;
		private System.Windows.Forms.TextBox textBoxTel;
		private System.Windows.Forms.ComboBox comboBoxCountry;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}