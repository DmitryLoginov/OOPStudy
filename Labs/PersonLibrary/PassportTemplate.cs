using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PersonLibrary
{
    //TODO naming +
    /// <summary>
    /// Паспорт.
    /// </summary>
    public class PassportTemplate
    {
        /// <summary>
        /// Шаблон для проверки серии паспорта.
        /// </summary>
        const string _seriesPattern = @"^[0-9]{4}$";

        /// <summary>
        /// Шаблон для проверки номера паспорта.
        /// </summary>
        const string _numberPattern = @"^[0-9]{6}$";

        /// <summary>
        /// Серия паспорта.
        /// </summary>
        private string _series;

        /// <summary>
        /// Номер паспорта.
        /// </summary>
        private string _number;

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
        public PassportTemplate(string series, string number)
        {
            Series = series;
            Number = number;
        }

        /// <summary>
        /// Проверяет серию или номер паспорта на соответствие требованиям.
        /// </summary>
        /// <param name="param">Серия/номер паспорта.</param>
        /// <param name="pattern">Шаблон для проверки.</param>
        private void IsDataCorrect(string param, string pattern)
        {
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(param))
            {
                throw new ArgumentException("Некорректно заданы серия или номер паспорта.");
            }
        }
    }
}
