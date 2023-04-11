namespace ISpan.Inseparable.Win
{
	partial class FormOrderRepos
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
			this.chartOrderCal = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.chartOrderCal)).BeginInit();
			this.SuspendLayout();
			// 
			// chartOrderCal
			// 
			chartArea1.Name = "ChartAreaOrderCal";
			this.chartOrderCal.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chartOrderCal.Legends.Add(legend1);
			this.chartOrderCal.Location = new System.Drawing.Point(45, 110);
			this.chartOrderCal.Margin = new System.Windows.Forms.Padding(2);
			this.chartOrderCal.Name = "chartOrderCal";
			this.chartOrderCal.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
			this.chartOrderCal.Size = new System.Drawing.Size(847, 529);
			this.chartOrderCal.TabIndex = 0;
			this.chartOrderCal.Text = "chartOrderCal";
			title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
			title1.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			title1.Name = "訂單統計";
			this.chartOrderCal.Titles.Add(title1);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button1.Location = new System.Drawing.Point(165, 42);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(121, 37);
			this.button1.TabIndex = 1;
			this.button1.Text = "訂單統計";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button2.Location = new System.Drawing.Point(314, 42);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(121, 37);
			this.button2.TabIndex = 2;
			this.button2.Text = "累積金額統計";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button3.Location = new System.Drawing.Point(463, 42);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(121, 37);
			this.button3.TabIndex = 3;
			this.button3.Text = "產品銷售統計";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button4.Location = new System.Drawing.Point(612, 42);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(121, 37);
			this.button4.TabIndex = 4;
			this.button4.Text = "電影銷售統計";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// FormOrderRepos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.ClientSize = new System.Drawing.Size(952, 680);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.chartOrderCal);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormOrderRepos";
			this.Text = "統計報表";
			((System.ComponentModel.ISupportInitialize)(this.chartOrderCal)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chartOrderCal;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
	}
}