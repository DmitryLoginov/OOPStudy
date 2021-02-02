using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    /// <summary>
    /// Класс для формирования рандомных персон.
    /// </summary>
    class RandomPerson
    {
        static private string[] _maleNames = new string[10] { "Isaac", "Zach", "Nolan", "Hans", "Robert", 
            "Terrence", "Challus", "Michael", "Nathan", "Gabe" };
        static private string[] _femaleNames = new string[10] { "Nicole", "Kendra", "Elizabeth", "Ellie", "Lexine",
            "Daina", "Jennifer", "Karen", "Alissa", "Isabel" };
        static private string[] _lastNames = new string[15] { "Clarke", "Brennan", "Hammond", "Daniels", "Kyne",
            "Mercer", "Cross", "Temple", "Stross", "Langford", "Murdoch", "McNeill", "Weller", "Altman", "Carver" };
        static private Random randNum = new Random();

        /// <summary>
        /// Возвращает случайную персону.
        /// </summary>
        /// <returns>Переменная типа Person.</returns>
        static public Person GetRandomPerson()
        {
            string name;
            string surname;
            int age;
            Gender gender = (Gender)randNum.Next(0, 1);
            switch (gender)
            {
                case Gender.Male:
                    name = _maleNames[randNum.Next(_maleNames.Length)];
                    break;
                case Gender.Female:
                    name = _femaleNames[randNum.Next(_femaleNames.Length)];
                    break;
                default:
                    return new Person("", "", 0, Gender.Male);
            }
            surname = _lastNames[randNum.Next(_lastNames.Length)];
            age = randNum.Next(0, 100);
            return new Person(name, surname, age, gender);
        }
    }
}
