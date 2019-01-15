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
				{
					//если выбран один из пуктов в listBox (при старте программы ни один пунктне будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
					Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
					Graphics gr = Graphics.FromImage(bmp);
					parking[listBoxLevels.SelectedIndex].Draw(gr);
					pictureBoxParking.Image = bmp;
				}
			}
			private void buttonParkingSimpleplane_Click(object sender, EventArgs e)//простой самолет
			{
				if (listBoxLevels.SelectedIndex > -1)
				{
					ColorDialog dialog = new ColorDialog();
					if (dialog.ShowDialog() == DialogResult.OK)
					{
						var exterminator = new Simpleplane(100, 1000, dialog.Color);
						int place = parking[listBoxLevels.SelectedIndex] + exterminator;
						if (place == -1)
						{
							MessageBox.Show("Нет свободных мест", "Ошибка",
						   MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						Draw();
					}
				}
			}
			private void buttonParkingExterminator_Click(object sender, EventArgs e)//сложный самолет
			{
				if (listBoxLevels.SelectedIndex > -1)
				{
					ColorDialog dialog = new ColorDialog();
					if (dialog.ShowDialog() == DialogResult.OK)
					{
						ColorDialog dialogDop = new ColorDialog();
						if (dialogDop.ShowDialog() == DialogResult.OK)
						{
							var exterminator = new Exterminator(100, 1000, dialog.Color, dialogDop.Color, true, true, true);
							int place = parking[listBoxLevels.SelectedIndex] + exterminator;
							if (place == -1)
							{
								MessageBox.Show("Нет свободных мест", "Ошибка",
							   MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
							Draw();
						}
					}
				}
			}
			private void buttonTakePlane_Click(object sender, EventArgs e)
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
	}	
}
