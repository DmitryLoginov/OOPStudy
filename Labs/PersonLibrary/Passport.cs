using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    /// <summary>
    /// Паспорт.
    /// </summary>
    public class Passport
    {
        private string _series;

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
    }
}
