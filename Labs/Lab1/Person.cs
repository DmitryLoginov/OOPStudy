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
        public Gender Gender { get; set; }

        // Конструктор класса
        public Person(string firstName, string lastName, uint age, Gender gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
        }

        // Чтение персоны с клавиатуры

        // Вывод персоны на экран
        public void Print()
        {
            Console.Write($"\n{this.FirstName}\t{this.LastName}\t{this.Age}\t{this.Gender}\t\n");
        }
    }
}
