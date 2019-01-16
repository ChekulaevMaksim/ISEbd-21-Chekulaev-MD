using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WindowsFormsExterminator
{
	public class Exterminator : Simpleplane, IComparable<Exterminator>, IEquatable<Exterminator>
	{
		/// <summary>
		/// Дополнительный цвет
		/// </summary>
		public Color DopColor { private set; get; }
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="maxSpeed">Максимальная скорость</param>
		/// <param name="weight">Вес автомобиля</param>
		/// <param name="mainColor">Основной цвет кузова</param>
		/// <param name="dopColor">Дополнительный цвет</param>
		public Exterminator(int maxSpeed, float weight, Color mainColor, Color dopColor, bool
	   frontSpoiler, bool sideSpoiler, bool backSpoiler) : base(maxSpeed, weight, mainColor)
		{
			DopColor = dopColor;

		}
		public Exterminator(string info) : base(info)
		{
			string[] strs = info.Split(';');
			if (strs.Length == 4)
			{
				MaxSpeed = Convert.ToInt32(strs[0]);
				Weight = Convert.ToInt32(strs[1]);
				MainColor = Color.FromName(strs[2]);
				DopColor = Color.FromName(strs[3]);
			}
		}
		/// <summary>
		/// Установка позиции автомобиля
		/// </summary>
		/// <param name="x">Координата X</param>
		/// <param name="y">Координата Y</param>
		/// <param name="width">Ширина картинки</param>
		/// <param name="height">Высота картинки</param>
		public void SetPosition(int x, int y, int width, int height)
		{
			_startPosX = x;
			_startPosY = y;
			_pictureWidth = width;
			_pictureHeight = height;
		}
		/// <summary>
		/// Изменение направления пермещения
		/// </summary>
		/// <param name="direction">Направление</param>


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
		/// <param name="g"></param>
		public override void DrawExterminator(Graphics g)
		{
			SolidBrush fillQuad = new SolidBrush(MainColor);
			g.FillRectangle(fillQuad, _startPosX + 22, _startPosY + 7, 7, 7);
			SolidBrush fillQuadSec = new SolidBrush(MainColor);
			g.FillRectangle(fillQuad, _startPosX + 22, _startPosY + 37, 7, 7);
			SolidBrush fillRect = new SolidBrush(DopColor);
			g.FillRectangle(fillRect, _startPosX + 35, _startPosY + 7, 35, 3);
			SolidBrush fillRect1 = new SolidBrush(DopColor);
			g.FillRectangle(fillRect, _startPosX + 35, _startPosY + 41, 35, 3);
			SolidBrush fillEll = new SolidBrush(Color.Red);
			g.FillEllipse(fillEll, _startPosX + 70, _startPosY + 4, 18, 8);
			g.FillEllipse(fillEll, _startPosX + 70, _startPosY + 38, 18, 8);
			base.DrawExterminator(g);
		}
		public void SetDopColor(Color color)
		{
			DopColor = color;
		}
		public override string ToString()
		{
			return base.ToString() + ";" + DopColor.Name;
		}
		/// <summary>
		/// Метод интерфейса IComparable для класса SportCar
		/// </summary>
		/// <param name="other"></param>
		/// <returns></returns>
		public int CompareTo(Exterminator other)
		{
			var res = (this is Simpleplane).CompareTo(other is Simpleplane);
			if (res != 0)
			{
				return res;
			}
			if (DopColor != other.DopColor)
			{
				DopColor.Name.CompareTo(other.DopColor.Name);
			}
			return 0;
		}
		/// <summary>
		/// Метод интерфейса IEquatable для класса SportCar
		/// </summary>
		/// <param name="other"></param>
		/// <returns></returns>
		public bool Equals(Exterminator other)
		{
			var res = (this as Simpleplane).Equals(other as Simpleplane);
			if (!res)
			{
				return res;
			}
			if (DopColor != other.DopColor)
			{
				return false;
			}
			return true;
		}
		/// <summary>
		/// Перегрузка метода от object
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public override bool Equals(Object obj)
		{
			if (obj == null)
			{
				return false;
			}
			Exterminator exterminatorObj = obj as Exterminator;
			if (exterminatorObj == null)
			{
				return false;
			}
			else
			{
				return Equals(exterminatorObj);
			}
		}
		/// <summary>
		/// Перегрузка метода от object
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
}
