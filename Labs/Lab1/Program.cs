using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Program
    { 
        private static void Main(string[] args)
        {
            PersonList firstList = new PersonList();
            PersonList secondList = new PersonList();      

            Console.WriteLine("СОЗДАНИЕ ДВУХ СПИСКО ПЕРСОН ПО ТРИ ЧЕЛОВЕКА В КАЖДОМ.");
            for (int i = 0; i < 3; i++)
            {
                firstList.Add(RandomPerson.GetRandomPerson());
                secondList.Add(RandomPerson.GetRandomPerson());
            }

            Console.ReadKey();
            PrintBothLists(firstList, secondList);

            Console.ReadKey();
            Console.WriteLine("ДОБАВЛЕНИЕ НОВОГО ЧЕЛОВЕКА В ПЕРВЫЙ СПИСОК.");
            firstList.Add(ReadPerson());
            Console.WriteLine("\nКОПИРОВАНИЕ ВТОРОГО ЧЕЛОВЕКА ИЗ ПЕРВОГО СПИСКА В КОНЕЦ ВТОРОГО.");
            secondList.Add(firstList[1]);

            Console.ReadKey();
            PrintBothLists(firstList, secondList);

            Console.ReadKey();
            Console.WriteLine("УДАЛЕНИЕ ВТОРОГО ЧЕЛОВЕКА ИЗ ПЕРВОГО СПИСКА.");
            firstList.DeleteByIndex(1);
            PrintBothLists(firstList, secondList);

            Console.ReadKey();
            Console.WriteLine("ОЧИСТКА ВТОРОГО СПИСКА.");
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
            string firstName = CheckPersonName("имя");
            string lastName = CheckPersonName("фамилию");
            int age = CheckPersonAge();
            Gender gender = CheckPersonGender();

            return new Person(firstName, lastName, age, gender);
        }

        /// <summary>
        /// Проверяет корректность введённых пользователем имени или фамилии.
        /// </summary>
        /// <param name="id">Имя или фамилия (будет отображаться в консоли).</param>
        /// <returns>Введённое пользователем имя или фамилия персоны.</returns>
        private static string CheckPersonName(string id)
        {
            string firstOrLastName;
            bool trigger;
            do
            {
                trigger = true;
                Console.Write($"Введите {id} персоны: ");
                firstOrLastName = Console.ReadLine();
                try
                {
                    Person.IsNameCorrect(firstOrLastName);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    trigger = false;
                }
            }
            while (!trigger);
            return firstOrLastName;
        }

        /// <summary>
        /// Проверяет корректность введённого пользователем возраста.
        /// </summary>
        /// <returns>Введённый пользователем возраст.</returns>
        private static int CheckPersonAge()
        {
            string ageString;
            int age;
            bool trigger;
            do
            {
                trigger = true;
                Console.Write("Введите возраст персоны: ");
                ageString = Console.ReadLine();
                if (!Int32.TryParse(ageString, out age))
                {
                    Console.WriteLine("Возраст должен быть числом.\n");
                    trigger = false;
                    continue;
                }
                try
                {
                    Person.IsAgeCorrect(age);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    trigger = false;
                }
            }
            while (!trigger);
            return age;
        }

        /// <summary>
        /// Проверяет корректность введённого пользователем пола.
        /// </summary>
        /// <returns>Введённый пользователем пол.</returns>
        private static Gender CheckPersonGender()
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
                    Console.WriteLine("Некорректно введён пол.\n");
                    trigger = false;
                }
            }
            while (!trigger);
            return (Gender)Enum.Parse(typeof(Gender), genderString, true);
        }

        private static void PrintBothLists(PersonList firstList, PersonList secondList)
        {
            Console.WriteLine("Содержимое первого списка:");
            Console.WriteLine(firstList.PrintAll());
            Console.WriteLine("Содержимое второго списка:");
            Console.WriteLine(secondList.PrintAll());
        }
    }
}
