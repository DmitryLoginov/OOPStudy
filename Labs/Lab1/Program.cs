using System;
using System.Collections.Generic;

using PersonLibrary;

namespace Lab1
{
    /// <summary>
    /// Работа с пользователем.
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

            PersonList firstList = new PersonList();
            PersonList secondList = new PersonList();

            Console.WriteLine("a. Создание двух списков персон " +
                "по три человека в каждом...");
            for (int i = 0; i < 3; i++)
            {
                firstList.Add(RandomPerson.GetRandomPerson());
                secondList.Add(RandomPerson.GetRandomPerson());
            }
            Console.ReadKey();

            Console.WriteLine("b. Вывод содержимого каждого списка на экран " +
                "с соответствующими подписями списков...");
            Console.ReadKey();
            PrintBothLists(firstList, secondList);
            
            Console.WriteLine("c. Добавление нового человека в " +
                "первый список...");
            Console.ReadKey();
            firstList.Add(ReadPerson());

            Console.WriteLine("\nd. Копирование второго человека " +
                "из первого списка в конец второго списка...");
            Console.ReadKey();
            secondList.Add(firstList[1]);
            PrintBothLists(firstList, secondList);
            
            Console.WriteLine("е. Удаление второго человека из " +
                "первого списка.");
            Console.ReadKey();
            firstList.DeleteByIndex(1);
            PrintBothLists(firstList, secondList);
            
            Console.WriteLine("f. Очистка второго списка.");
            Console.ReadKey();
            secondList.Clear();
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
            var validationActions = new List<Tuple<string, Action>>()
            {
                new Tuple<string, Action>
                (
                    "Введите имя персоны: ",
                    () =>
                    {
                        personFromConsole.FirstName = Console.ReadLine();
                    }
                ),
                new Tuple<string, Action>
                (
                    "Введите фамилию персоны: ",
                    () =>
                    {
                        personFromConsole.LastName = Console.ReadLine();
                    }
                ),
                new Tuple<string, Action>
                (
                    "Введите возраст персоны: ",
                    () =>
                    {
                        string ageString = Console.ReadLine();
                        if (!Int32.TryParse(ageString, out int age))
                        {
                            throw new ArgumentException("Возраст должен " +
                                "быть числом.");
                        }
                        personFromConsole.Age = age;
                    }
                ),
                new Tuple<string, Action>
                (
                    "Введите пол персоны (Male/Female): ",
                    () =>
                    {
                        string genderString = Console.ReadLine();
                        if (!Enum.IsDefined(typeof(Gender), genderString))
                        {
                            throw new ArgumentException("Некорректно введён пол.");
                        }
                        personFromConsole.Gender = (Gender)Enum.Parse(typeof(Gender), 
                            genderString, true);
                    }
                ),
            };

            foreach(var actionItem in validationActions)
            {
                ValidateInput(actionItem.Item1, actionItem.Item2);
            }

            return personFromConsole;
        }

        /// <summary>
        /// Проверка корректности вводимых параметров.
        /// </summary>
        /// <param name="outputMessage">Параметр для проверки.</param>
        /// <param name="validationAction">Метод проверки.</param>
        private static void ValidateInput(string outputMessage, 
            Action validationAction)
        {
            while (true)
            {
                try
                {
                    Console.Write(outputMessage);
                    validationAction();
                    return;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}\nПопробуйте снова.");
                }
            }
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
