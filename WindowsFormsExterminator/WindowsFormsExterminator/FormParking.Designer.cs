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
			// FormParking
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
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
	}
}