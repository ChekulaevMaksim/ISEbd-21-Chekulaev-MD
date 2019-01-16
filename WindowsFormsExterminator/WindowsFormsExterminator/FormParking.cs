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
		/// <summary>
		/// Объект от класса многоуровневой парковки
		/// </summary>
		MultiLevelParking parking;
		FormPlaneConfig form;
		/// <summary>
		/// Количество уровней-парковок
		/// </summary>
		private const int countLevel = 5;

		public FormParking()
		{
			InitializeComponent();
			parking = new MultiLevelParking(countLevel, pictureBoxParking.Width, pictureBoxParking.Height);
			//заполнение listBox
			for (int i = 0; i < countLevel; i++)
			{
				listBoxLevels.Items.Add("Уровень " + (i + 1));
			}
			listBoxLevels.SelectedIndex = 0;
		}
		private void Draw()
		{
			if (listBoxLevels.SelectedIndex > -1)
			{//если выбран один из пуктов в listBox (при старте программы ни один пунктне будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
				Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
				Graphics gr = Graphics.FromImage(bmp);
				parking[listBoxLevels.SelectedIndex].Draw(gr);
				pictureBoxParking.Image = bmp;
			}

		}

		private void buttonTakePlane_Click(object sender, EventArgs e)//забрать
		{
			if (listBoxLevels.SelectedIndex > -1)
			{
				if (maskedTextBoxParking.Text != "")
				{
					var exterminator = parking[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBoxParking.Text);
					if (exterminator != null)
					{
						Bitmap bmp = new Bitmap(pictureBoxLittleParking.Width, pictureBoxLittleParking.Height);
						Graphics gr = Graphics.FromImage(bmp);
						exterminator.SetPosition(5, 5, pictureBoxLittleParking.Width, pictureBoxLittleParking.Height);
						exterminator.DrawExterminator(gr);
						pictureBoxLittleParking.Image = bmp;
					}
					else
					{
						Bitmap bmp = new Bitmap(pictureBoxLittleParking.Width, pictureBoxLittleParking.Height);
						pictureBoxLittleParking.Image = bmp;
					}
					Draw();
				}
			}

		}
		private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
		{
			Draw();
		}

		private void buttonSetPlane_Click(object sender, EventArgs e)
		{
			form = new FormPlaneConfig();
			form.AddEvent(AddPlane);
			form.Show();
		}
		private void AddPlane(IPlane exterminator)
		{
			if (exterminator != null && listBoxLevels.SelectedIndex > -1)
			{
				int place = parking[listBoxLevels.SelectedIndex] + exterminator;
				if (place > -1)
				{
					Draw();
				}
				else
				{
					MessageBox.Show("Самолет не удалось поставить");
				}
			}
		}
	}
}
