﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsExterminator
{
	public class MultiLevelParking
	{
		/// <summary>
		/// Список с уровнями парковки
		/// </summary>
		List<Parking<IPlane>> parkingStages;
		/// <summary>
		/// Сколько мест на каждом уровне
		/// </summary>
		private const int countPlaces = 20;
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="countStages">Количество уровенй парковки</param>
		/// <param name="pictureWidth"></param>
		/// <param name="pictureHeight"></param>
		public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
		{
			parkingStages = new List<Parking<IPlane>>();
			for (int i = 0; i < countStages; ++i)
			{
				parkingStages.Add(new Parking<IPlane>(countPlaces, pictureWidth,  pictureHeight));
			}
		}
		/// <summary>
		/// Индексатор
		/// </summary>
		/// <param name="ind"></param>
		/// <returns></returns>
		public Parking<IPlane> this[int ind]
		{
			get
			{
				if (ind > -1 && ind < parkingStages.Count)
				{
					return parkingStages[ind];
				}
				return null;
			}
		}
	}

}