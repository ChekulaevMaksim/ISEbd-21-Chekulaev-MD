using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExterminator
{
	public partial class FormParking : Form
	{
		Parking<IPlane> parking;

		public FormParking()
		{
			InitializeComponent();
			parking = new Parking<IPlane>(20, pictureBoxParking.Width, pictureBoxParking.Height);
			Draw();
		}
		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
			Graphics gr = Graphics.FromImage(bmp);
			parking.Draw(gr);
			pictureBoxParking.Image = bmp;
		}

		private void buttonParkingSimpleplane_Click(object sender, EventArgs e)//простой самолет
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				var exterminator = new Simpleplane(100, 1000, dialog.Color);
				int place = parking + exterminator;
				Draw();
			}
		}

		private void buttonParkingExterminator_Click(object sender, EventArgs e)//сложный самолет
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				ColorDialog dialogDop = new ColorDialog();
				if (dialogDop.ShowDialog() == DialogResult.OK)
				{
					var exterminator = new Exterminator(100, 1000, dialog.Color, dialogDop.Color,
				   true, true, true);
					int place = parking + exterminator;
					Draw();
				}
			}
		}
		private void buttonTakePlane_Click(object sender, EventArgs e)//забрать
		{
			if (maskedTextBoxParking.Text != "")
			{
				var exterminator = parking - Convert.ToInt32(maskedTextBoxParking.Text);
				if (exterminator != null)
				{
					Bitmap bmp = new Bitmap(pictureBoxLittleParking.Width,
				    pictureBoxLittleParking.Height);
					Graphics gr = Graphics.FromImage(bmp);
					exterminator.SetPosition(5, 5, pictureBoxLittleParking.Width,
				    pictureBoxLittleParking.Height);
					exterminator.DrawExterminator(gr);
					pictureBoxLittleParking.Image = bmp;
				}
				else
				{
					Bitmap bmp = new Bitmap(pictureBoxLittleParking.Width,
				    pictureBoxLittleParking.Height);
					pictureBoxLittleParking.Image = bmp;
				}
				Draw();
			}
		}
	}
}
