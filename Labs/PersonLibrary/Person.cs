using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PersonLibrary
{
    /// <summary>
    /// Класс персон.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Имя персоны.
        /// </summary>
        private string _fisrtName;

        /// <summary>
        /// Имя персоны.
        /// </summary>
        public string FirstName
        {
            get
            {
                return _fisrtName;
            }
            private set
            {
                IsNameCorrect(value);
                _fisrtName = value;
            }
        }

        /// <summary>
        /// Фамилия персоны.
        /// </summary>
        private string _lastName;

        /// <summary>
        /// Фамилия персоны.
        /// </summary>
        public string LastName
        {
            get
            {
                return _lastName;
            }
            private set
            {
                IsNameCorrect(value);
                _lastName = value;
            }
        }

        /// <summary>
        /// Возраст персоны.
        /// </summary>
        private int _age;

        /// <summary>
        /// Возраст персоны.
        /// </summary>
        public int Age
        {
            get
            {
                return _age;
            }
            private set
            {
                IsAgeCorrect(value);
                _age = value;
            }
        }

        /// <summary>
        /// Пол персоны.
        /// </summary>
        private Gender _gender;

        /// <summary>
        /// Пол персоны.
        /// </summary>
        public Gender Gender
        {
            get
            {
                return _gender;
            }
            private set
            {
                _gender = value;
            }
        }


        /// <summary>
        /// Конструктор класса Person.
        /// </summary>
        /// <param name="firstName">Имя персоны.</param>
        /// <param name="lastName">Фамилия персоны.</param>
        /// <param name="age">Возраст персоны.</param>
        /// <param name="gender">Пол персоны.</param>
        public Person(string firstName, string lastName, int age, Gender gender)
        {
            FirstName = ToCorrectCase(firstName);
            LastName = ToCorrectCase(lastName);
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Выводит на экран информацию о персоне.
        /// </summary>
        /// <returns>Строка, содержащая имя, фамилию, пол и возраст персоны.</returns>
        public string Print()
        {
            return $"{FirstName} {LastName}, пол: {Gender}, возраст: {Age}";
        }

        /// <summary>
        /// Проверяет имя или фамилию на соответствие требованиям.
        /// </summary>
        /// <param name="name">Строка, соответствующая имени или фамилии.</param>

        public static void IsNameCorrect(string name)
        {
            Regex namePattern = new Regex(@"((^([a-zA-Z])+$)|(^([a-zA-Z])+(\s|-)([a-zA-Z])+$))|((^([а-яА-Я])+$)|(^([а-яА-Я])+(\s|-)([а-яА-Я])+$))");
            if (!namePattern.IsMatch(name))
            {
                throw new ArgumentException("Имя и фамилия должны содержать только русские или английские символы.\n");
            }
        }

        /// <summary>
        /// Проверяет возраст на соответствие требованиям.
        /// </summary>
        /// <param name="ageString">Строка, соответствующая возрасту.</param>

        public static void IsAgeCorrect(int age)
        {
            const int maxAge = 130;
            if ((age >= maxAge) || (age < 0))
            {
                throw new ArgumentException($"Возраст должен быть не отрицательным числом, меньшим {maxAge}.\n");
            }
        }

        /// <summary>
        /// Преобразует имя и фамилию к правильному регистру.
        /// </summary>
        /// <param name="name">Имя или фамилия персоны.</param>
        /// <returns>Имя/фамилия с первой заглавной буквой.</returns>

        private static string ToCorrectCase(string name)
        {
            string newName = name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
            for (int i = 0; i < newName.Length; i++)
            {
                if ((newName[i] == ' ') || (newName[i] == '-'))
                {
                    newName = newName.Substring(0, i + 1) + newName.Substring(i + 1, 1).ToUpper()
                        + newName.Substring(i + 2).ToLower();
                    break;
                }
            }
            return newName;
        }
    }
}
