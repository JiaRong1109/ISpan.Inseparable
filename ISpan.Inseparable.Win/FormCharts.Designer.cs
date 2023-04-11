namespace ISpan.Inseparable.Win
{
	partial class FormCharts
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
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.buttonPie = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.buttonColumn = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.buttonBar = new System.Windows.Forms.Button();
			this.buttomLine = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(148, 73);
			this.chart1.Name = "chart1";
			this.chart1.Size = new System.Drawing.Size(1000, 561);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "文章類別統計";
			// 
			// buttonPie
			// 
			this.buttonPie.Location = new System.Drawing.Point(116, 12);
			this.buttonPie.Name = "buttonPie";
			this.buttonPie.Size = new System.Drawing.Size(75, 23);
			this.buttonPie.TabIndex = 1;
			this.buttonPie.Text = "Pie";
			this.buttonPie.UseVisualStyleBackColor = true;
			this.buttonPie.Click += new System.EventHandler(this.buttonPie_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(-462, -7);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "button1";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// buttonColumn
			// 
			this.buttonColumn.Location = new System.Drawing.Point(35, 12);
			this.buttonColumn.Name = "buttonColumn";
			this.buttonColumn.Size = new System.Drawing.Size(75, 23);
			this.buttonColumn.TabIndex = 1;
			this.buttonColumn.Text = "Column";
			this.buttonColumn.UseVisualStyleBackColor = true;
			this.buttonColumn.Click += new System.EventHandler(this.buttonColumn_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(-591, -23);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 1;
			this.button4.Text = "button1";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// buttonBar
			// 
			this.buttonBar.Location = new System.Drawing.Point(197, 12);
			this.buttonBar.Name = "buttonBar";
			this.buttonBar.Size = new System.Drawing.Size(75, 23);
			this.buttonBar.TabIndex = 1;
			this.buttonBar.Text = "Bar";
			this.buttonBar.UseVisualStyleBackColor = true;
			this.buttonBar.Click += new System.EventHandler(this.buttonBar_Click);
			// 
			// buttomLine
			// 
			this.buttomLine.Location = new System.Drawing.Point(278, 12);
			this.buttomLine.Name = "buttomLine";
			this.buttomLine.Size = new System.Drawing.Size(75, 23);
			this.buttomLine.TabIndex = 1;
			this.buttomLine.Text = "Line";
			this.buttomLine.UseVisualStyleBackColor = true;
			this.buttomLine.Click += new System.EventHandler(this.buttomLine_Click);
			// 
			// FormCharts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1299, 682);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.buttonColumn);
			this.Controls.Add(this.buttomLine);
			this.Controls.Add(this.buttonBar);
			this.Controls.Add(this.buttonPie);
			this.Controls.Add(this.chart1);
			this.Name = "FormCharts";
			this.Text = "FormCharts";
			this.Load += new System.EventHandler(this.FormCharts_Load);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Button buttonPie;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button buttonColumn;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button buttonBar;
		private System.Windows.Forms.Button buttomLine;
	}
}