namespace WindowsFormsExterminator
{
	partial class FormPlaneConfig
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBoxDrag = new System.Windows.Forms.GroupBox();
			this.labelExterminator = new System.Windows.Forms.Label();
			this.labelSimpleplane = new System.Windows.Forms.Label();
			this.panelDrop = new System.Windows.Forms.Panel();
			this.labelDopColor = new System.Windows.Forms.Label();
			this.labelBaseColor = new System.Windows.Forms.Label();
			this.pictureBoxPlane = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panelOrange = new System.Windows.Forms.Panel();
			this.panelGold = new System.Windows.Forms.Panel();
			this.panelGray = new System.Windows.Forms.Panel();
			this.panelBlue = new System.Windows.Forms.Panel();
			this.panelGreen = new System.Windows.Forms.Panel();
			this.panelWhite = new System.Windows.Forms.Panel();
			this.panelBlack = new System.Windows.Forms.Panel();
			this.panelRed = new System.Windows.Forms.Panel();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBoxDrag.SuspendLayout();
			this.panelDrop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(776, 426);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// groupBoxDrag
			// 
			this.groupBoxDrag.Controls.Add(this.labelExterminator);
			this.groupBoxDrag.Controls.Add(this.labelSimpleplane);
			this.groupBoxDrag.Location = new System.Drawing.Point(38, 36);
			this.groupBoxDrag.Name = "groupBoxDrag";
			this.groupBoxDrag.Size = new System.Drawing.Size(174, 178);
			this.groupBoxDrag.TabIndex = 1;
			this.groupBoxDrag.TabStop = false;
			this.groupBoxDrag.Text = "Тип самолета";
			// 
			// labelExterminator
			// 
			this.labelExterminator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelExterminator.Location = new System.Drawing.Point(17, 108);
			this.labelExterminator.Name = "labelExterminator";
			this.labelExterminator.Size = new System.Drawing.Size(126, 51);
			this.labelExterminator.TabIndex = 2;
			this.labelExterminator.Text = "Истребитель";
			this.labelExterminator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelExterminator.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelExterminator_MouseDown);
			// 
			// labelSimpleplane
			// 
			this.labelSimpleplane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelSimpleplane.Location = new System.Drawing.Point(17, 30);
			this.labelSimpleplane.Name = "labelSimpleplane";
			this.labelSimpleplane.Size = new System.Drawing.Size(126, 51);
			this.labelSimpleplane.TabIndex = 2;
			this.labelSimpleplane.Text = "Обычный";
			this.labelSimpleplane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelSimpleplane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelSimpleplane_MouseDown);
			// 
			// panelDrop
			// 
			this.panelDrop.AllowDrop = true;
			this.panelDrop.Controls.Add(this.labelDopColor);
			this.panelDrop.Controls.Add(this.labelBaseColor);
			this.panelDrop.Controls.Add(this.pictureBoxPlane);
			this.panelDrop.Location = new System.Drawing.Point(266, 36);
			this.panelDrop.Name = "panelDrop";
			this.panelDrop.Size = new System.Drawing.Size(230, 297);
			this.panelDrop.TabIndex = 2;
			this.panelDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelDrop_DragDrop);
			this.panelDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelDrop_DragEnter);
			// 
			// labelDopColor
			// 
			this.labelDopColor.AllowDrop = true;
			this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelDopColor.Location = new System.Drawing.Point(13, 241);
			this.labelDopColor.Name = "labelDopColor";
			this.labelDopColor.Size = new System.Drawing.Size(203, 31);
			this.labelDopColor.TabIndex = 2;
			this.labelDopColor.Text = "Доп.Цвет";
			this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
			this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragEnter);
			// 
			// labelBaseColor
			// 
			this.labelBaseColor.AllowDrop = true;
			this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelBaseColor.Location = new System.Drawing.Point(13, 182);
			this.labelBaseColor.Name = "labelBaseColor";
			this.labelBaseColor.Size = new System.Drawing.Size(203, 33);
			this.labelBaseColor.TabIndex = 1;
			this.labelBaseColor.Text = "Основной цвет";
			this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
			this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
			// 
			// pictureBoxPlane
			// 
			this.pictureBoxPlane.Location = new System.Drawing.Point(13, 14);
			this.pictureBoxPlane.Name = "pictureBoxPlane";
			this.pictureBoxPlane.Size = new System.Drawing.Size(203, 145);
			this.pictureBoxPlane.TabIndex = 0;
			this.pictureBoxPlane.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.panelOrange);
			this.groupBox1.Controls.Add(this.panelGold);
			this.groupBox1.Controls.Add(this.panelGray);
			this.groupBox1.Controls.Add(this.panelBlue);
			this.groupBox1.Controls.Add(this.panelGreen);
			this.groupBox1.Controls.Add(this.panelWhite);
			this.groupBox1.Controls.Add(this.panelBlack);
			this.groupBox1.Controls.Add(this.panelRed);
			this.groupBox1.Location = new System.Drawing.Point(541, 41);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(209, 291);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Цвет";
			// 
			// panelOrange
			// 
			this.panelOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.panelOrange.Location = new System.Drawing.Point(28, 236);
			this.panelOrange.Name = "panelOrange";
			this.panelOrange.Size = new System.Drawing.Size(38, 34);
			this.panelOrange.TabIndex = 1;
			this.panelOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelGold
			// 
			this.panelGold.BackColor = System.Drawing.Color.Yellow;
			this.panelGold.Location = new System.Drawing.Point(117, 236);
			this.panelGold.Name = "panelGold";
			this.panelGold.Size = new System.Drawing.Size(38, 34);
			this.panelGold.TabIndex = 1;
			this.panelGold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelGray
			// 
			this.panelGray.BackColor = System.Drawing.Color.Gray;
			this.panelGray.Location = new System.Drawing.Point(28, 177);
			this.panelGray.Name = "panelGray";
			this.panelGray.Size = new System.Drawing.Size(38, 34);
			this.panelGray.TabIndex = 1;
			this.panelGray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelBlue
			// 
			this.panelBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.panelBlue.Location = new System.Drawing.Point(117, 177);
			this.panelBlue.Name = "panelBlue";
			this.panelBlue.Size = new System.Drawing.Size(38, 34);
			this.panelBlue.TabIndex = 1;
			this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelGreen
			// 
			this.panelGreen.BackColor = System.Drawing.Color.Lime;
			this.panelGreen.Location = new System.Drawing.Point(117, 120);
			this.panelGreen.Name = "panelGreen";
			this.panelGreen.Size = new System.Drawing.Size(38, 34);
			this.panelGreen.TabIndex = 1;
			this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelWhite
			// 
			this.panelWhite.BackColor = System.Drawing.Color.White;
			this.panelWhite.Location = new System.Drawing.Point(28, 120);
			this.panelWhite.Name = "panelWhite";
			this.panelWhite.Size = new System.Drawing.Size(38, 34);
			this.panelWhite.TabIndex = 1;
			this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelBlack
			// 
			this.panelBlack.BackColor = System.Drawing.Color.Black;
			this.panelBlack.Location = new System.Drawing.Point(117, 55);
			this.panelBlack.Name = "panelBlack";
			this.panelBlack.Size = new System.Drawing.Size(38, 34);
			this.panelBlack.TabIndex = 1;
			this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelRed
			// 
			this.panelRed.BackColor = System.Drawing.Color.Red;
			this.panelRed.Location = new System.Drawing.Point(28, 55);
			this.panelRed.Name = "panelRed";
			this.panelRed.Size = new System.Drawing.Size(38, 34);
			this.panelRed.TabIndex = 0;
			this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(55, 250);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(112, 33);
			this.buttonOk.TabIndex = 4;
			this.buttonOk.Text = "Добавить";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(55, 310);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(112, 34);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// FormPlaneConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panelDrop);
			this.Controls.Add(this.groupBoxDrag);
			this.Controls.Add(this.pictureBox1);
			this.Name = "FormPlaneConfig";
			this.Text = "FormPlaneConfig";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBoxDrag.ResumeLayout(false);
			this.panelDrop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBoxDrag;
		private System.Windows.Forms.Label labelExterminator;
		private System.Windows.Forms.Label labelSimpleplane;
		private System.Windows.Forms.Panel panelDrop;
		private System.Windows.Forms.PictureBox pictureBoxPlane;
		private System.Windows.Forms.Label labelDopColor;
		private System.Windows.Forms.Label labelBaseColor;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panelOrange;
		private System.Windows.Forms.Panel panelGold;
		private System.Windows.Forms.Panel panelGray;
		private System.Windows.Forms.Panel panelBlue;
		private System.Windows.Forms.Panel panelGreen;
		private System.Windows.Forms.Panel panelWhite;
		private System.Windows.Forms.Panel panelBlack;
		private System.Windows.Forms.Panel panelRed;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
	}
}