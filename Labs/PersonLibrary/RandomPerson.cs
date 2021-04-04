using System;
using System.Collections.Generic;

namespace PersonLibrary
{
    /// <summary>
    /// Класс для формирования случайных персон.
    /// </summary>
    public static class RandomPerson
    {
        /// <summary>
        /// Строковый массив мужских имён.
        /// </summary>
        private static string[] _maleNames =
        {
            "Isaac", "Zach", "Nolan", "Hans", "Robert", "Noah",
            "Terrence", "Challus", "Michael", "Nathan", "Gabe",
            "Jacob", "Arthur", "Benjamin", "Victor", "Franco",
            "Austin", "Mark", "Dylan", "Sam", "Warren", "Colin"
        };

        /// <summary>
        /// Строковый массив женских имён.
        /// </summary>
        private static string[] _femaleNames =
        {
            "Nicole", "Kendra", "Elizabeth", "Ellie", "Lexine",
            "Daina", "Jennifer", "Karen", "Alissa", "Isabel",
            "Amelia", "Rachel", "Damara", "Catherine", "Amanda",
            "Sarah", "Donna", "Sandra", "Jessica"
        };

        /// <summary>
        /// Строковый массив фамилий.
        /// </summary>
        private static string[] _lastNames =
        {
            "Clarke", "Brennan", "Hammond", "Daniels", "Kyne",
            "Mercer", "Cross", "Temple", "Stross", "Langford",
            "Murdoch", "McNeill", "Weller", "Altman", "Carver",
            "Danik", "Delille", "Mathius", "Neumann", "Tatchet",
            "Phelps", "Santos", "Rosen", "Norton", "Caldwell",
            "Eckhardt", "Vincent", "Cooper", "Borges", "Cho",
            "Barrow", "Pawling", "Malyech", "Li", "Chang"
        };

        private static string[] _jobs =
        {
            "работа1", "работа2", "работа3"
        };

        /// <summary>
        /// Объект класса Random.
        /// </summary>
        private static Random randNum = new Random();

        /// <summary>
        /// Возвращает случайную персону.
        /// </summary>
        /// <returns>Переменная типа Person.</returns>
        public static Person Get()
        {
            string name;
            
            Gender gender = (Gender)randNum.Next(0, 
                Enum.GetNames(typeof(Gender)).Length);
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
                    throw new Exception("Неизвестный пол.");
                }
            }
            string surname = _lastNames[randNum.Next(_lastNames.Length)];
            int age = randNum.Next(Person.MinAge, Person.MaxAge);
            
            return new Person(name, surname, age, gender);
        }

        /// <summary>
        /// Возвращает случайного взрослого (без пары).
        /// </summary>
        /// <returns></returns>
        public static Adult GetSingleAdult()
        {
            Person tempPerson = Get();

            Adult newAdult = new Adult(tempPerson.FirstName, tempPerson.LastName,
                tempPerson.Age, tempPerson.Gender, Passport.GetRandomPassport());

            newAdult.GetAJob(_jobs[randNum.Next(_jobs.Length)]);

            return newAdult;
        }

        /// <summary>
        /// Возвращает бездетную пару случайных персон.
        /// </summary>
        /// <returns></returns>
        public static List<Adult> GetChildlessAdultPair()
        {
            Person tempMale = Get();
            Adult newMale = new Adult(tempMale.FirstName, tempMale.LastName,
                tempMale.Age, tempMale.Gender, Passport.GetRandomPassport());

            Person tempFemale = Get();
            Adult newFemale = new Adult(tempFemale.FirstName, tempFemale.LastName,
                tempFemale.Age, tempFemale.Gender, Passport.GetRandomPassport());

            newMale.GetAJob(_jobs[randNum.Next(_jobs.Length)]);
            newFemale.GetAJob(_jobs[randNum.Next(_jobs.Length)]);

            Adult.GetMarried(newMale, newFemale);

            return new List<Adult>() { newMale, newFemale };
        }
    }
}
