using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PersonLibrary;

namespace Lab1
{
    public class Program
    { 
        public static void Main(string[] args)
        {
            PersonList firstList = new PersonList();
            PersonList secondList = new PersonList();

            Console.WriteLine("a. Создание двух списков персон " +
                "по три человека в каждом...");
            for (int i = 0; i < 3; i++)
            {
                firstList.Add(RandomPerson.Get());
                secondList.Add(RandomPerson.Get());
            }
            Console.ReadKey();

            Console.WriteLine("b. Вывод содержимого каждого списка на экран " +
                "с соответствующими подписями списков...");
            Console.ReadKey();
            PrintBothLists(firstList, secondList);
            
            Console.WriteLine("c. Добавление нового человека в первый список...");
            Console.ReadKey();
            firstList.Add(ReadPerson());

            Console.WriteLine("\nd. Копирование второго человека " +
                "из первого списка в конец второго списка...");
            Console.ReadKey();
            secondList.Add(firstList[1]);
            PrintBothLists(firstList, secondList);
            
            Console.WriteLine("е. Удаление второго человека из первого списка.");
            Console.ReadKey();
            firstList.DeleteByIndex(1);
            PrintBothLists(firstList, secondList);
            
            Console.WriteLine("f. Очистка второго списка.");
            Console.ReadKey();
            secondList.Erase();
            PrintBothLists(firstList, secondList);

            Console.WriteLine("Нажмите любую клавишу, чтобы выйти...");
            Console.ReadKey();
        }

        /// <summary>
        /// Ведёт диалог с пользователем для ввода персоны с клавиатуры.
        /// </summary>
        /// <returns>Переменная типа Person.</returns>
        private static Person ReadPerson()
        {
            Person personFromConsole = new Person();

            CheckPersonFirstName(personFromConsole);
            CheckPersonLastName(personFromConsole);
            CheckPersonAge(personFromConsole);
            CheckPersonGender(personFromConsole);

            return personFromConsole;
        }

        /// <summary>
        /// Проверяет корректность введённого пользователем имени.
        /// </summary>
        /// <param name="person">Персона, вводимая с клавиатуры.</param>
        private static void CheckPersonFirstName(Person person)
        {
            bool trigger;

            do
            {
                trigger = true;
                Console.Write("Введите имя персоны: ");
                string firstName = Console.ReadLine();
                try
                {
                    person.FirstName = firstName;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    trigger = false;
                    Console.WriteLine("Попробуйте ещё раз.");
                }
            }
            while (!trigger);
        }

        /// <summary>
        /// Проверяет корректность введённой пользователем фамилии.
        /// </summary>
        /// <param name="person">Персона, вводимая с клавиатуры.</param>
        private static void CheckPersonLastName(Person person)
        {
            bool trigger;

            do
            {
                trigger = true;
                Console.Write("Введите фамилию персоны: ");
                string lastName = Console.ReadLine();
                try
                {
                    person.LastName = lastName;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    trigger = false;
                    Console.WriteLine("Попробуйте ещё раз.");
                }
            }
            while (!trigger);
        }

        /// <summary>
        /// Проверяет корректность введённого пользователем возраста.
        /// </summary>
        /// <param name="person">Персона, вводимая с клавиатуры.</param>
        private static void CheckPersonAge(Person person)
        {
            bool trigger;

            do
            {
                trigger = true;
                Console.Write("Введите возраст персоны: ");
                string ageString = Console.ReadLine();
                if (!Int32.TryParse(ageString, out int age))
                {
                    Console.WriteLine("Возраст должен быть числом.");
                    trigger = false;
                    Console.WriteLine("Попробуйте ещё раз.");
                    continue;
                }
                try
                {
                    person.Age = age;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    trigger = false;
                    Console.WriteLine("Попробуйте ещё раз.");
                }
            }
            while (!trigger);
        }

        /// <summary>
        /// Проверяет корректность введённого пользователем пола.
        /// </summary>
        /// <param name="person">Персона, вводимая с клавиатуры.</param>
        private static void CheckPersonGender(Person person)
        {
            string genderString;
            bool trigger;

            do
            {
                trigger = true;
                Console.Write("Введите пол персоны (Male/Female): ");
                genderString = Console.ReadLine();
                if (!Enum.IsDefined(typeof(Gender), genderString))
                {
                    Console.WriteLine("Некорректно введён пол.");
                    trigger = false;
                    Console.WriteLine("Попробуйте ещё раз.");
                }
            }
            while (!trigger);

            person.Gender = (Gender)Enum.Parse(typeof(Gender), genderString, true);
        }

        /// <summary>
        /// Выводит в консоль два списка персон.
        /// </summary>
        /// <param name="firstList">Первый список.</param>
        /// <param name="secondList">Второй список.</param>
        private static void PrintBothLists(PersonList firstList, 
            PersonList secondList)
        {
            Console.WriteLine("Содержимое первого списка:");
            Console.WriteLine(firstList.PrintAll());
            Console.WriteLine("Содержимое второго списка:");
            Console.WriteLine(secondList.PrintAll());
        }
    }
}
