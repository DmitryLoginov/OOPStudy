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
        private int _age;
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age
        { 
            get
            {
                return _age;
            }
            private set
            {
                const int maxAge = 130;
                if ((value >= maxAge) || (value < 0))
                {
                    throw new ArgumentException($"{nameof(Age)} должен быть не отрицательным числом, меньшим {maxAge}");
                }
                _age = value;
            }
        }
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
    }
}
