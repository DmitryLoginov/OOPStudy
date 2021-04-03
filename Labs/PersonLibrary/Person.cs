using System;
using System.Collections.Generic;
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
            set
            {
                IsNameCorrect(value);
                _fisrtName = ToCorrectCase(value);
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
            set
            {
                IsNameCorrect(value);
                _lastName = ToCorrectCase(value);
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
            set
            {
                IsAgeCorrect(value);
                _age = value;
            }
        }

        /// <summary>
        /// Пол персоны.
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Информация о персоне.
        /// </summary>
        public virtual string Info
        {
            get
            {
                return $"{FirstName} {LastName}, пол: {Gender}, возраст: {Age}";
            }
        }

        /// <summary>
        /// Наименьший допустимый возраст персоны.
        /// </summary>
        public const int MinAge = 0;

        /// <summary>
        /// Наибольший допустимый возраст персоны.
        /// </summary>
        public const int MaxAge = 130;

        /// <summary>
        /// Конструктор класса Person.
        /// </summary>
        /// <param name="firstName">Имя персоны.</param>
        /// <param name="lastName">Фамилия персоны.</param>
        /// <param name="age">Возраст персоны.</param>
        /// <param name="gender">Пол персоны.</param>
        public Person(string firstName, string lastName,
            int age, Gender gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Person() : this("Unknown", "Person", 0, Gender.Male)
        {
        }

        /// <summary>
        /// Проверяет имя или фамилию на соответствие требованиям.
        /// </summary>
        /// <param name="name">
        /// Строка, соответствующая имени или фамилии.
        /// </param>
        private void IsNameCorrect(string name)
        {
            var lettersSet = new List<char[]>()
            {
                new char[] {'a','z','A','Z'},
                new char[] {'а','я','А','Я'}
            };

            var patternsList = new List<string>();
            foreach (var letters in lettersSet)
            {
                var lettersPattern = $"[{letters[0]}-{letters[1]}{letters[2]}-{letters[3]}]";
                patternsList.Add($@"((^({lettersPattern})+$)|(^({lettersPattern})+(\s|-)({lettersPattern})+$))");
            }

            Regex namePattern = new Regex(String.Join("|", patternsList));
            
            if (!namePattern.IsMatch(name))
            {
                throw new ArgumentException("Имя и фамилия должны содержать " +
                    "только русские или английские символы.");
            }
        }

        /// <summary>
        /// Проверяет возраст на соответствие требованиям.
        /// </summary>
        /// <param name="ageString">Строка, соответствующая возрасту.</param>
        private void IsAgeCorrect(int age)
        {
            if ((age >= MaxAge) || (age < 0))
            {
                throw new ArgumentException($"Возраст должен быть " +
                    $"не отрицательным числом, меньшим {MaxAge}.");
            }
        }

        /// <summary>
        /// Преобразует имя и фамилию к правильному регистру.
        /// </summary>
        /// <param name="name">Имя или фамилия персоны.</param>
        /// <returns>Имя или фамилия с первой заглавной буквой.</returns>
        private string ToCorrectCase(string name)
        {
            string newName = name.Substring(0, 1).ToUpper() + 
                name.Substring(1).ToLower();
            
            for (int i = 0; i < newName.Length; i++)
            {
                if ((newName[i] == ' ') || (newName[i] == '-'))
                {
                    newName = newName.Substring(0, i + 1) + 
                        newName.Substring(i + 1, 1).ToUpper() + 
                        newName.Substring(i + 2).ToLower();
                    break;
                }
            }
            
            return newName;
        }
    }
}
