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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.buttonTakePlane = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLittleParking)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxParking
			// 
			this.pictureBoxParking.Location = new System.Drawing.Point(12, 12);
			this.pictureBoxParking.Name = "pictureBoxParking";
			this.pictureBoxParking.Size = new System.Drawing.Size(550, 291);
			this.pictureBoxParking.TabIndex = 0;
			this.pictureBoxParking.TabStop = false;
			// 
			// maskedTextBoxParking
			// 
			this.maskedTextBoxParking.Location = new System.Drawing.Point(660, 232);
			this.maskedTextBoxParking.Name = "maskedTextBoxParking";
			this.maskedTextBoxParking.Size = new System.Drawing.Size(106, 20);
			this.maskedTextBoxParking.TabIndex = 1;
			// 
			// pictureBoxLittleParking
			// 
			this.pictureBoxLittleParking.Location = new System.Drawing.Point(627, 274);
			this.pictureBoxLittleParking.Name = "pictureBoxLittleParking";
			this.pictureBoxLittleParking.Size = new System.Drawing.Size(139, 73);
			this.pictureBoxLittleParking.TabIndex = 2;
			this.pictureBoxLittleParking.TabStop = false;
			// 
			// listBoxLevels
			// 
			this.listBoxLevels.FormattingEnabled = true;
			this.listBoxLevels.Location = new System.Drawing.Point(620, 22);
			this.listBoxLevels.Name = "listBoxLevels";
			this.listBoxLevels.Size = new System.Drawing.Size(118, 108);
			this.listBoxLevels.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(618, 153);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(119, 24);
			this.button1.TabIndex = 4;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(617, 194);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(119, 18);
			this.button2.TabIndex = 5;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// buttonTakePlane
			// 
			this.buttonTakePlane.Location = new System.Drawing.Point(618, 362);
			this.buttonTakePlane.Name = "buttonTakePlane";
			this.buttonTakePlane.Size = new System.Drawing.Size(147, 22);
			this.buttonTakePlane.TabIndex = 6;
			this.buttonTakePlane.Text = "button3";
			this.buttonTakePlane.UseVisualStyleBackColor = true;
			this.buttonTakePlane.Click += new System.EventHandler(this.buttonTakePlane_Click);
			// 
			// FormParking
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonTakePlane);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listBoxLevels);
			this.Controls.Add(this.pictureBoxLittleParking);
			this.Controls.Add(this.maskedTextBoxParking);
			this.Controls.Add(this.pictureBoxParking);
			this.Name = "FormParking";
			this.Text = "FormParking";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLittleParking)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxParking;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxParking;
		private System.Windows.Forms.PictureBox pictureBoxLittleParking;
		private System.Windows.Forms.ListBox listBoxLevels;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button buttonTakePlane;
	}
}