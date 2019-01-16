﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsExterminator
{
	/// <summary>
	/// Класс-ошибка "Если на парковке уже заняты все места"
	/// </summary>
	public class ParkingOverflowException : Exception
	{
		public ParkingOverflowException() : base("В ангаре нет свободных мест")
		{ }
	}

}