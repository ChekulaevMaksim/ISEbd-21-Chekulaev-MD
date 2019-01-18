namespace WindowsFormsExterminator
{
	partial class FormExterm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBoxExterminator = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxExterminator)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxExterminator
			// 
			this.pictureBoxExterminator.Location = new System.Drawing.Point(12, 12);
			this.pictureBoxExterminator.Name = "pictureBoxExterminator";
			this.pictureBoxExterminator.Size = new System.Drawing.Size(776, 426);
			this.pictureBoxExterminator.TabIndex = 0;
			this.pictureBoxExterminator.TabStop = false;
			// 
			// FormExterm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pictureBoxExterminator);
			this.Name = "FormExterm";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxExterminator)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxExterminator;
	}
}

