namespace WindowsFormsExterminator
{
	partial class FormParking
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
			this.pictureBoxParking = new System.Windows.Forms.PictureBox();
			this.maskedTextBoxParking = new System.Windows.Forms.MaskedTextBox();
			this.pictureBoxLittleParking = new System.Windows.Forms.PictureBox();
			this.listBoxLevels = new System.Windows.Forms.ListBox();
			this.buttonTakePlane = new System.Windows.Forms.Button();
			this.buttonSetPlane = new System.Windows.Forms.Button();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLittleParking)).BeginInit();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBoxParking
			// 
			this.pictureBoxParking.Location = new System.Drawing.Point(12, 27);
			this.pictureBoxParking.Name = "pictureBoxParking";
			this.pictureBoxParking.Size = new System.Drawing.Size(865, 405);
			this.pictureBoxParking.TabIndex = 0;
			this.pictureBoxParking.TabStop = false;
			// 
			// maskedTextBoxParking
			// 
			this.maskedTextBoxParking.Location = new System.Drawing.Point(925, 255);
			this.maskedTextBoxParking.Name = "maskedTextBoxParking";
			this.maskedTextBoxParking.Size = new System.Drawing.Size(106, 20);
			this.maskedTextBoxParking.TabIndex = 1;
			// 
			// pictureBoxLittleParking
			// 
			this.pictureBoxLittleParking.Location = new System.Drawing.Point(892, 297);
			this.pictureBoxLittleParking.Name = "pictureBoxLittleParking";
			this.pictureBoxLittleParking.Size = new System.Drawing.Size(139, 73);
			this.pictureBoxLittleParking.TabIndex = 2;
			this.pictureBoxLittleParking.TabStop = false;
			// 
			// listBoxLevels
			// 
			this.listBoxLevels.FormattingEnabled = true;
			this.listBoxLevels.Location = new System.Drawing.Point(885, 45);
			this.listBoxLevels.Name = "listBoxLevels";
			this.listBoxLevels.Size = new System.Drawing.Size(118, 108);
			this.listBoxLevels.TabIndex = 3;
			// 
			// buttonTakePlane
			// 
			this.buttonTakePlane.Location = new System.Drawing.Point(883, 385);
			this.buttonTakePlane.Name = "buttonTakePlane";
			this.buttonTakePlane.Size = new System.Drawing.Size(147, 22);
			this.buttonTakePlane.TabIndex = 6;
			this.buttonTakePlane.Text = "button3";
			this.buttonTakePlane.UseVisualStyleBackColor = true;
			this.buttonTakePlane.Click += new System.EventHandler(this.buttonTakePlane_Click);
			// 
			// buttonSetPlane
			// 
			this.buttonSetPlane.Location = new System.Drawing.Point(885, 171);
			this.buttonSetPlane.Name = "buttonSetPlane";
			this.buttonSetPlane.Size = new System.Drawing.Size(117, 38);
			this.buttonSetPlane.TabIndex = 7;
			this.buttonSetPlane.Text = "button1";
			this.buttonSetPlane.UseVisualStyleBackColor = true;
			this.buttonSetPlane.Click += new System.EventHandler(this.buttonSetPlane_Click);
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(1088, 24);
			this.menuStrip.TabIndex = 8;
			this.menuStrip.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// сохранитьToolStripMenuItem
			// 
			this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
			this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.сохранитьToolStripMenuItem.Text = "Сохранить";
			this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
			// 
			// загрузитьToolStripMenuItem
			// 
			this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
			this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.загрузитьToolStripMenuItem.Text = "Загрузить";
			this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.Filter = "txt file | *.txt";
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			this.openFileDialog.Filter = "txt file | *.txt";
			// 
			// FormParking
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1088, 588);
			this.Controls.Add(this.buttonSetPlane);
			this.Controls.Add(this.buttonTakePlane);
			this.Controls.Add(this.listBoxLevels);
			this.Controls.Add(this.pictureBoxLittleParking);
			this.Controls.Add(this.maskedTextBoxParking);
			this.Controls.Add(this.pictureBoxParking);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "FormParking";
			this.Text = "FormParking";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLittleParking)).EndInit();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxParking;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxParking;
		private System.Windows.Forms.PictureBox pictureBoxLittleParking;
		private System.Windows.Forms.ListBox listBoxLevels;
		private System.Windows.Forms.Button buttonTakePlane;
		private System.Windows.Forms.Button buttonSetPlane;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
	}
}