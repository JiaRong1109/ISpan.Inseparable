namespace ISpan.Inseparable.Win
{
	partial class FormEditRooms
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
			this.buttonEdit = new System.Windows.Forms.Button();
			this.textBoxRoom = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.labelRoomID = new System.Windows.Forms.Label();
			this.labelCinema = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonEdit
			// 
			this.buttonEdit.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonEdit.Location = new System.Drawing.Point(249, 156);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(74, 39);
			this.buttonEdit.TabIndex = 1;
			this.buttonEdit.Text = "更新";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// textBoxRoom
			// 
			this.textBoxRoom.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxRoom.Location = new System.Drawing.Point(108, 117);
			this.textBoxRoom.Name = "textBoxRoom";
			this.textBoxRoom.Size = new System.Drawing.Size(127, 27);
			this.textBoxRoom.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(23, 117);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 19);
			this.label2.TabIndex = 4;
			this.label2.Text = "影廳：";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(23, 75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 19);
			this.label1.TabIndex = 5;
			this.label1.Text = "影城：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(23, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 19);
			this.label3.TabIndex = 5;
			this.label3.Text = "影廳ID：";
			// 
			// labelRoomID
			// 
			this.labelRoomID.AutoSize = true;
			this.labelRoomID.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelRoomID.Location = new System.Drawing.Point(105, 44);
			this.labelRoomID.Name = "labelRoomID";
			this.labelRoomID.Size = new System.Drawing.Size(0, 19);
			this.labelRoomID.TabIndex = 5;
			// 
			// labelCinema
			// 
			this.labelCinema.AutoSize = true;
			this.labelCinema.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelCinema.Location = new System.Drawing.Point(105, 75);
			this.labelCinema.Name = "labelCinema";
			this.labelCinema.Size = new System.Drawing.Size(0, 19);
			this.labelCinema.TabIndex = 9;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FormEditRooms
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(346, 219);
			this.Controls.Add(this.labelCinema);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.textBoxRoom);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelRoomID);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "FormEditRooms";
			this.Text = "影廳修改";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.TextBox textBoxRoom;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label labelRoomID;
		private System.Windows.Forms.Label labelCinema;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}