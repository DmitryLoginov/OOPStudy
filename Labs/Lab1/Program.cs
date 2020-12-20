using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonList people = new PersonList();

            Console.WriteLine("тест:\n");
            people.Print();

            //people[0] = people.Add("Чек", "тест", 20, Gender.Male);
            people.Add("Чек", "тест", 20, Gender.Male);
            Console.WriteLine("\nтест:\n");
            people.Print();

            people.Add("Хочу", "жрать", 20, Gender.Male);
            people.Add("Ммм", "кфс", 20, Gender.Male);
            Console.WriteLine("\nтест:\n");
            people.Print();

            people.Delete(1);
            Console.WriteLine("\nтест:\n");
            people.Print();

            people.Erase();
            Console.WriteLine("\nтест:\n");
            people.Print();

            Console.ReadKey();
        }
    }
}
