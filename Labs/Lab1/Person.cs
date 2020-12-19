using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public uint Age { get; set; }
        public Gender Gender { get; set }

        public Person(string firstName, string lastName, uint age, Gender gender) // Конструктор класса
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
        }
    }
}
