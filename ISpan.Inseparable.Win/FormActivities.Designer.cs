namespace ISpan.Inseparable.Win
{
    partial class FormActivities
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAddActivity = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.dateTimePickerActivity = new System.Windows.Forms.DateTimePicker();
            this.textBoxActivityID = new System.Windows.Forms.TextBox();
            this.buttonEditActivity = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewActivity = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxActivityTitle = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxActivityDescription = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPeopleLimit = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelActivityDateTime = new System.Windows.Forms.Label();
            this.labelActivityTitle = new System.Windows.Forms.Label();
            this.labelActivityID = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivity)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonAddActivity);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.dateTimePickerActivity);
            this.groupBox1.Controls.Add(this.textBoxActivityID);
            this.groupBox1.Controls.Add(this.buttonEditActivity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataGridViewActivity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxActivityTitle);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(8, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(754, 610);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "活動查詢";
            // 
            // buttonAddActivity
            // 
            this.buttonAddActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddActivity.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonAddActivity.Location = new System.Drawing.Point(496, 563);
            this.buttonAddActivity.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddActivity.Name = "buttonAddActivity";
            this.buttonAddActivity.Size = new System.Drawing.Size(125, 38);
            this.buttonAddActivity.TabIndex = 12;
            this.buttonAddActivity.Text = "新增活動...";
            this.buttonAddActivity.UseVisualStyleBackColor = true;
            this.buttonAddActivity.Click += new System.EventHandler(this.buttonAddActivity_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonClear.Location = new System.Drawing.Point(521, 64);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 38);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "清空";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // dateTimePickerActivity
            // 
            this.dateTimePickerActivity.CustomFormat = "yyyy/MM/dd   HH:mm:ss";
            this.dateTimePickerActivity.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePickerActivity.Location = new System.Drawing.Point(379, 29);
            this.dateTimePickerActivity.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerActivity.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerActivity.Name = "dateTimePickerActivity";
            this.dateTimePickerActivity.Size = new System.Drawing.Size(180, 30);
            this.dateTimePickerActivity.TabIndex = 8;
            // 
            // textBoxActivityID
            // 
            this.textBoxActivityID.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxActivityID.Location = new System.Drawing.Point(103, 75);
            this.textBoxActivityID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxActivityID.Name = "textBoxActivityID";
            this.textBoxActivityID.Size = new System.Drawing.Size(191, 30);
            this.textBoxActivityID.TabIndex = 7;
            // 
            // buttonEditActivity
            // 
            this.buttonEditActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditActivity.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonEditActivity.Location = new System.Drawing.Point(626, 563);
            this.buttonEditActivity.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditActivity.Name = "buttonEditActivity";
            this.buttonEditActivity.Size = new System.Drawing.Size(119, 38);
            this.buttonEditActivity.TabIndex = 9;
            this.buttonEditActivity.Text = "編輯活動";
            this.buttonEditActivity.UseVisualStyleBackColor = true;
            this.buttonEditActivity.Click += new System.EventHandler(this.buttonEditActivity_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(16, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "活動ID：";
            // 
            // dataGridViewActivity
            // 
            this.dataGridViewActivity.AllowUserToAddRows = false;
            this.dataGridViewActivity.AllowUserToDeleteRows = false;
            this.dataGridViewActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActivity.Location = new System.Drawing.Point(12, 137);
            this.dataGridViewActivity.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewActivity.Name = "dataGridViewActivity";
            this.dataGridViewActivity.ReadOnly = true;
            this.dataGridViewActivity.RowHeadersWidth = 82;
            this.dataGridViewActivity.RowTemplate.Height = 38;
            this.dataGridViewActivity.Size = new System.Drawing.Size(732, 416);
            this.dataGridViewActivity.TabIndex = 10;
            this.dataGridViewActivity.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewActivity_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(311, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "日期：";
            // 
            // textBoxActivityTitle
            // 
            this.textBoxActivityTitle.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxActivityTitle.Location = new System.Drawing.Point(103, 31);
            this.textBoxActivityTitle.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxActivityTitle.Name = "textBoxActivityTitle";
            this.textBoxActivityTitle.Size = new System.Drawing.Size(130, 30);
            this.textBoxActivityTitle.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonSearch.Location = new System.Drawing.Point(644, 64);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 38);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "查詢";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "標題：";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBoxActivityDescription);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.labelPeopleLimit);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.labelActivityDateTime);
            this.groupBox2.Controls.Add(this.labelActivityTitle);
            this.groupBox2.Controls.Add(this.labelActivityID);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(766, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(424, 449);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "活動資料";
            // 
            // textBoxActivityDescription
            // 
            this.textBoxActivityDescription.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxActivityDescription.Location = new System.Drawing.Point(18, 197);
            this.textBoxActivityDescription.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxActivityDescription.Multiline = true;
            this.textBoxActivityDescription.Name = "textBoxActivityDescription";
            this.textBoxActivityDescription.ReadOnly = true;
            this.textBoxActivityDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxActivityDescription.Size = new System.Drawing.Size(389, 233);
            this.textBoxActivityDescription.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(30, 34);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 22);
            this.label12.TabIndex = 36;
            this.label12.Text = "活動ID：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(15, 68);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 22);
            this.label11.TabIndex = 37;
            this.label11.Text = "活動標題：";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label.Location = new System.Drawing.Point(15, 134);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(95, 22);
            this.label.TabIndex = 38;
            this.label.Text = "活動時間：";
            this.label.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(15, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 39;
            this.label5.Text = "活動說明：";
            // 
            // labelPeopleLimit
            // 
            this.labelPeopleLimit.AutoSize = true;
            this.labelPeopleLimit.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelPeopleLimit.Location = new System.Drawing.Point(113, 102);
            this.labelPeopleLimit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPeopleLimit.Name = "labelPeopleLimit";
            this.labelPeopleLimit.Size = new System.Drawing.Size(18, 22);
            this.labelPeopleLimit.TabIndex = 48;
            this.labelPeopleLimit.Text = "  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(15, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 22);
            this.label6.TabIndex = 40;
            this.label6.Text = "人數限制：";
            // 
            // labelActivityDateTime
            // 
            this.labelActivityDateTime.AutoSize = true;
            this.labelActivityDateTime.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelActivityDateTime.Location = new System.Drawing.Point(113, 134);
            this.labelActivityDateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelActivityDateTime.Name = "labelActivityDateTime";
            this.labelActivityDateTime.Size = new System.Drawing.Size(18, 22);
            this.labelActivityDateTime.TabIndex = 48;
            this.labelActivityDateTime.Text = "  ";
            this.labelActivityDateTime.Visible = false;
            // 
            // labelActivityTitle
            // 
            this.labelActivityTitle.AutoSize = true;
            this.labelActivityTitle.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelActivityTitle.Location = new System.Drawing.Point(113, 68);
            this.labelActivityTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelActivityTitle.Name = "labelActivityTitle";
            this.labelActivityTitle.Size = new System.Drawing.Size(18, 22);
            this.labelActivityTitle.TabIndex = 48;
            this.labelActivityTitle.Text = "  ";
            // 
            // labelActivityID
            // 
            this.labelActivityID.AutoSize = true;
            this.labelActivityID.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelActivityID.Location = new System.Drawing.Point(113, 34);
            this.labelActivityID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelActivityID.Name = "labelActivityID";
            this.labelActivityID.Size = new System.Drawing.Size(30, 22);
            this.labelActivityID.TabIndex = 47;
            this.labelActivityID.Text = "     ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd   HH:mm:ss";
            this.dateTimePicker1.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker1.Location = new System.Drawing.Point(422, 107);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 30);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(354, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "日期：";
            // 
            // FormActivities
            // 
            this.AcceptButton = this.buttonSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1202, 643);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1119, 642);
            this.Name = "FormActivities";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "活動管理";
            this.Load += new System.EventHandler(this.FormActivities_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivity)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxActivityID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxActivityTitle;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEditActivity;
        private System.Windows.Forms.DataGridView dataGridViewActivity;
        private System.Windows.Forms.DateTimePicker dateTimePickerActivity;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelPeopleLimit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelActivityDateTime;
        private System.Windows.Forms.Label labelActivityTitle;
        private System.Windows.Forms.Label labelActivityID;
        private System.Windows.Forms.TextBox textBoxActivityDescription;
        private System.Windows.Forms.Button buttonAddActivity;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
    }
}