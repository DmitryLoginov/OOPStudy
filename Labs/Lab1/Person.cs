using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    /// <summary>
    /// Класс персон.
    /// </summary>
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public uint Age { get; set; }
        public Gender Gender { get; set; }

        /// <summary>
        /// Конструктор класса Person.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        public Person(string firstName, string lastName, uint age, Gender gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
        }

        // Вывод персоны на экран
        //public void Print()
        //{
        //    Console.Write($"\n{this.FirstName}\t{this.LastName}\t{this.Age}\t{this.Gender}\t\n");
        //}
    }
}
