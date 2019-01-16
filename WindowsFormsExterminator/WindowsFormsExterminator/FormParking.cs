using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

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
		private Logger logger;

		public FormParking()
		{
			InitializeComponent();
			logger = LogManager.GetCurrentClassLogger();
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
					
					try
					{

						var exterminator = parking[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBoxParking.Text);
					
						Bitmap bmp = new Bitmap(pictureBoxLittleParking.Width, pictureBoxLittleParking.Height);
						Graphics gr = Graphics.FromImage(bmp);
						exterminator.SetPosition(5, 5, pictureBoxLittleParking.Width,pictureBoxLittleParking.Height);
						exterminator.DrawExterminator(gr);
						pictureBoxLittleParking.Image = bmp;

						logger.Info("Изъят самолет " + exterminator.ToString() + " с места " + maskedTextBoxParking.Text);

						Draw();
					}
					catch (ParkingNotFoundException ex)
					{
						MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
						Bitmap bmp = new Bitmap(pictureBoxLittleParking.Width,pictureBoxLittleParking.Height);
						pictureBoxLittleParking.Image = bmp;
					}
					catch (Exception ex)
					{
					MessageBox.Show(ex.Message, "Неизвестная ошибка",
					   MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
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
				try
				{

					int place = parking[listBoxLevels.SelectedIndex] + exterminator;
					logger.Info("Добавлен самолет " + exterminator.ToString() + " на место " + place);
					Draw();
				}
				catch (ParkingOverflowException ex)
				{
					MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
				   MessageBoxIcon.Error);
				}
				catch (ParkingAlreadyHaveException ex)
				{
					MessageBox.Show(ex.Message, "Дублирование", MessageBoxButtons.OK,
				   MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Неизвестная ошибка",
				   MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}
		}
		private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				try
				{
					parking.SaveData(saveFileDialog.FileName);
					MessageBox.Show("Сохранение прошло успешно", "Результат",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
					logger.Info("Сохранено в файл " + saveFileDialog.FileName);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
				   MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				try
				{
					parking.LoadData(openFileDialog.FileName);
					MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
					MessageBoxIcon.Information);
					logger.Info("Загружено из файла " + openFileDialog.FileName);
				}
				catch (ParkingOccupiedPlaceException ex)
				{
					MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
				   MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
				   MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				Draw();
			}
		}

		private void buttonSort_Click(object sender, EventArgs e)
		{
			parking.Sort();
			Draw();
			logger.Info("Сортировка уровней");
		}
	}
}
