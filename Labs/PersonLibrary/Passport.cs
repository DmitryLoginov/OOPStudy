using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PersonLibrary
{
    /// <summary>
    /// Паспорт.
    /// </summary>
    public class Passport
    {
        const string _seriesPattern = @"^[0-9]{4}$";

        const string _numberPattern = @"^[0-9]{6}$";

        private string _series;

        private string _number;

        private static Random randNum = new Random();

        /// <summary>
        /// Серия паспорта.
        /// </summary>
        public string Series
        {
            get
            {
                return _series;
            }
            set
            {
                IsDataCorrect(value, _seriesPattern);
                _series = value;
            }
        }

        /// <summary>
        /// Номер паспорта.
        /// </summary>
        public string Number
        {
            get
            {
                return _number;
            }
            set
            {
                IsDataCorrect(value, _numberPattern);
                _number = value;
            }
        }

        /// <summary>
        /// Конструктор класса Passport.
        /// </summary>
        /// <param name="series">Серия паспорта.</param>
        /// <param name="number">Номер паспорта.</param>
        public Passport(string series, string number)
        {
            Series = series;
            Number = number;
        }

        private void IsDataCorrect(string param, string pattern)
        {
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(param))
            {
                throw new ArgumentException("Некорректно заданы серия или номер паспорта.");
            }
        }

        public static Passport GetRandomPassport()
        {
            string series = String.Empty;

            for (int i = 0; i < 4; i++)
            {
                // TODO: количество цифр в серии и номере
                series += randNum.Next(10);
            }

            string number = String.Empty;

            for (int i = 0; i < 6; i++)
            {
                number += randNum.Next(10);
            }

            return new Passport(series, number);
        }
    }
}
