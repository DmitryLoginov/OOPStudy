using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PersonLibrary;

namespace Lab2
{
    /// <summary>
    /// Класс Program для работы с пользователем.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WindowWidth = 100;

            PersonList people = new PersonList();
            Random randNum = new Random();

            // a. Создание списка PersonList, состоящий из
            // семи человек, среди которых - взрослые и дети
            // в случайном порядке.
            for (int i = 0; i < 7; i++)
            {
                int person = randNum.Next(0, 2);
                switch (person)
                {
                    case 0:
                    {
                        people.Add(RandomPerson.GetSingleAdult());
                        break;
                    }
                    case 1:
                    {
                        people.Add(RandomPerson.GetChild());
                        break;
                    }
                }
            }

            // b. Вывод на экран описания всех людей списка.
            Console.WriteLine("Вывод на экран описания всех людей списка...");
            Console.ReadKey();
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine(people[i].Info + "\n");
            }

            // c. Программное определение типа четвёртого человека в списке.
            Console.WriteLine("Программное определение типа четвёртого человека в списке...");
            Console.ReadKey();
            switch (people[3])
            {
                case Adult adult:
                {
                    Console.WriteLine("Тип четвёртого человека в списке - Adult");
                    Console.WriteLine(adult.FindAJob("Стоматологическая клиника"));
                    break;
                }
                case Child child:
                {
                    Console.WriteLine("Тип четвёртого человека в списке - Child");
                    Console.WriteLine(child.GoStudy("Шахматный кружок"));
                    break;
                }
            }


            Console.ReadKey();
        }
    }
}
