using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    /// <summary>
    /// Класс для формирования рандомных персон.
    /// </summary>
    public static class RandomPerson
    {
        /// <summary>
        /// Строковый массив мужских имён.
        /// </summary>
        private static string[] _maleNames =
        {
            "Isaac", "Zach", "Nolan", "Hans", "Robert",
            "Terrence", "Challus", "Michael", "Nathan", "Gabe"
        };

        /// <summary>
        /// Строковый массив женских имён.
        /// </summary>
        private static string[] _femaleNames =
        {
            "Nicole", "Kendra", "Elizabeth", "Ellie", "Lexine",
            "Daina", "Jennifer", "Karen", "Alissa", "Isabel"
        };

        /// <summary>
        /// Строковый массив фамилий.
        /// </summary>
        private static string[] _lastNames =
        {
            "Clarke", "Brennan", "Hammond", "Daniels", "Kyne",
            "Mercer", "Cross", "Temple", "Stross", "Langford",
            "Murdoch", "McNeill", "Weller", "Altman", "Carver"
        };

        private static Random randNum = new Random();

        /// <summary>
        /// Возвращает случайную персону.
        /// </summary>
        /// <returns>Переменная типа Person.</returns>
        public static Person GetRandomPerson()
        {
            string name;
            
            Gender gender = (Gender)randNum.Next(0, Enum.GetNames(typeof(Gender)).Length);
            switch (gender)
            {
                case Gender.Male:
                    {
                        name = _maleNames[randNum.Next(_maleNames.Length)];
                        break;
                    }
                case Gender.Female:
                    {
                        name = _femaleNames[randNum.Next(_femaleNames.Length)];
                        break;
                    }
                default:
                    {
                        return new Person("", "", 0, Gender.Male);
                    }
            }
            string surname = _lastNames[randNum.Next(_lastNames.Length)];
            int age = randNum.Next(0, 100);
            
            return new Person(name, surname, age, gender);
        }
    }
}
