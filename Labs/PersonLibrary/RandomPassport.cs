﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    /// <summary>
    /// Класс для формирования случайных паспортов.
    /// </summary>
    public static class RandomPassport
    {
        /// <summary>
        /// Количество цифр в серии паспорта.
        /// </summary>
        private const int _seriesDigitsCount = 4;

        /// <summary>
        /// Количество цифр в номере паспорта.
        /// </summary>
        private const int _numberDigitsCount = 6;
        
        /// <summary>
        /// Объект класса Random.
        /// </summary>
        private static Random randNum = new Random();

        /// <summary>
        /// Возвращает случайный паспорт.
        /// </summary>
        /// <returns>Переменная типа PassportTemplate.</returns>
        public static PassportTemplate GetRandomPassport()
        {
            string series = String.Empty;

            for (int i = 0; i < _seriesDigitsCount; i++)
            {
                series += randNum.Next(10);
            }

            string number = String.Empty;

            for (int i = 0; i < _numberDigitsCount; i++)
            {
                number += randNum.Next(10);
            }

            return new PassportTemplate(series, number);
        }
    }
}