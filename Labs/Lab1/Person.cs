using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab1
{
    /// <summary>
    /// Класс персон.
    /// </summary>
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        /// <summary>
        /// Конструктор класса Person.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        public Person(string firstName, string lastName, int age, Gender gender)
        {
            FirstName = firstName;
            LastName = lastName;
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
        /// <param name="name"></param>
        public static void IsNameCorrect(string name)
        {
            Regex namePattern = new Regex(@"((^([a-zA-Z])+$)|(^([a-zA-Z])+(\s|-)([a-zA-Z])+$))|((^([а-яА-Я])+$)|(^([а-яА-Я])+(\s|-)([а-яА-Я])+$))");
            if (namePattern.IsMatch(name) != true)
            {
                throw new ArgumentException("Имя и фамилия должны содержать только русские или английские символы.\n" +
                    "Попробуйте ещё раз.");
            }
        }

        /// <summary>
        /// Проверяет возраст на соответствие требованиям.
        /// </summary>
        /// <param name="ageString"></param>
        public static void IsAgeCorrect(string ageString)
        {
            int age;
            const int maxAge = 130;
            if ((Int32.TryParse(ageString, out age) != true) || (age >= maxAge) || (age < 0))
            {
                throw new ArgumentException($"Возраст должен быть не отрицательным числом, меньшим {maxAge}.\n" +
                    $"Попробуйте ещё раз.");
            }
        }

        /// <summary>
        /// Проверяет корректный ввод пола.
        /// </summary>
        /// <param name="genderString"></param>
        public static void IsGenderCorrect(string genderString)
        {
            if (Enum.IsDefined(typeof(Gender), genderString) != true)
            {
                throw new ArgumentException("Некорректно введён пол.\nПопробуйте ещё раз.");
            }
            Gender genderPlaceholder = (Gender)Enum.Parse(typeof(Gender), genderString, true);
        }

    }
}
