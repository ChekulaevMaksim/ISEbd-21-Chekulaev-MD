using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WindowsFormsExterminator
{
	public class Simpleplane : Vehicle
	{
		/// <summary>
		/// Ширина отрисовки автомобиля
		/// </summary>
		protected const int extermWidth = 110;
		/// <summary>
		/// Ширина отрисовки автомобиля
		/// </summary>
		protected const int extermHeight = 60;
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="maxSpeed">Максимальная скорость</param>
		/// <param name="weight">Вес автомобиля</param>
		/// <param name="mainColor">Основной цвет кузова</param>
		public Simpleplane(int maxSpeed, float weight, Color mainColor)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
		}
		public Simpleplane(string info)
		{
			string[] strs = info.Split(';');
			if (strs.Length == 3)
			{
				MaxSpeed = Convert.ToInt32(strs[0]);
				Weight = Convert.ToInt32(strs[1]);
				MainColor = Color.FromName(strs[2]);
			}
		}
		public override void MoveTransport(Direction direction)
		{
			float step = MaxSpeed * 100 / Weight;
			switch (direction)
			{
				// вправо
				case Direction.Right:
					if (_startPosX + step < _pictureWidth - extermWidth)
					{
						_startPosX += step;
					}
					break;
				//влево
				case Direction.Left:
					if (_startPosX - step > 0)
					{
						_startPosX -= step;
					}
					break;
				//вверх
				case Direction.Up:
					if (_startPosY - step > 0)
					{
						_startPosY -= step;
					}
					break;
				//вниз
				case Direction.Down:
					if (_startPosY + step < _pictureHeight - extermHeight)
					{
						_startPosY += step;
					}
					break;
			}
		}
		public override void DrawExterminator(Graphics g)
		{
			Pen pen = new Pen(Color.Black, 2);
			g.DrawLine(pen, _startPosX + 40, _startPosY + 15, _startPosX + 90, _startPosY + 25);
			g.DrawLine(pen, _startPosX + 40, _startPosY + 35, _startPosX + 90, _startPosY + 25);
			g.DrawLine(pen, _startPosX + 40, _startPosY + 15, _startPosX + 25, _startPosY);
			g.DrawLine(pen, _startPosX + 40, _startPosY + 35, _startPosX + 25, _startPosY + 50);
			g.DrawLine(pen, _startPosX + 25, _startPosY, _startPosX + 17, _startPosY + 8);
			g.DrawLine(pen, _startPosX + 25, _startPosY + 50, _startPosX + 17, _startPosY + 42);
			g.DrawLine(pen, _startPosX + 17, _startPosY + 8, _startPosX + 7, _startPosY + 25);
			g.DrawLine(pen, _startPosX + 17, _startPosY + 42, _startPosX + 7, _startPosY + 25);
			Brush br = new SolidBrush(MainColor);
			g.FillEllipse(br, _startPosX + 15, _startPosY + 18, 15, 15);
		}
		public override string ToString()
		{
			return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
		}

	}
}
