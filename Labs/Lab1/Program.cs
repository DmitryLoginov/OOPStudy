using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        /// <summary>
        /// Делегат для вызова методов проверки свойств персоны.
        /// </summary>
        /// <param name="param"></param>
        private delegate void Check(string param);
        
        static void Main(string[] args)
        {
            PersonList firstList = new PersonList();
            PersonList secondList = new PersonList();

            Console.WriteLine("Создание двух списков персон по три человека в каждом.");
            for (int i = 0; i < 3; i++)
            {
                firstList.Add(RandomPerson.GetRandomPerson());
                secondList.Add(RandomPerson.GetRandomPerson());
            }
            
            Console.ReadKey();
            Console.WriteLine("Содержимое первого списка:");
            Console.WriteLine(firstList.PrintAll());
            Console.WriteLine("Содержимое второго списка:");
            Console.WriteLine(secondList.PrintAll());

            Console.ReadKey();
            Console.WriteLine("Добавление нового человека в первый список.");
            firstList.Add(RandomPerson.GetRandomPerson());
            Console.WriteLine("Копирование второго человека из первого списка в конец второго.");
            secondList.Add(firstList[1]);

            Console.ReadKey();
            Console.WriteLine("Содержимое первого списка:");
            Console.WriteLine(firstList.PrintAll());
            Console.WriteLine("Содержимое второго списка:");
            Console.WriteLine(secondList.PrintAll());

            Console.ReadKey();
            Console.WriteLine("Удаление второго человека из первого списка.");
            firstList.DeleteByIndex(1);
            Console.WriteLine("Содержимое первого списка:");
            Console.WriteLine(firstList.PrintAll());
            Console.WriteLine("Содержимое второго списка:");
            Console.WriteLine(secondList.PrintAll());

            Console.ReadKey();
            Console.WriteLine("Очистка второго списка.");
            secondList.Erase();
            Console.WriteLine("Содержимое первого списка:");
            Console.WriteLine(firstList.PrintAll());
            Console.WriteLine("Содержимое второго списка:");
            Console.WriteLine(secondList.PrintAll());

            Console.WriteLine("Нажмите любую клавишу, чтобы выйти...");
            Console.ReadKey();
        }

        /// <summary>
        /// Ведёт диалог с пользователем для ввода персоны с клавиатуры.
        /// </summary>
        /// <returns>Переменная типа Person.</returns>
        private static Person ReadPerson()
        {
            string firstName, lastName, ageString, genderString;

            Check method = Person.IsNameCorrect;
            firstName = RightRegister(CheckInputValue("имя", method));
            lastName = RightRegister(CheckInputValue("фамилию", method));

            method = Person.IsAgeCorrect;
            ageString = CheckInputValue("возраст", method);

            method = Person.IsGenderCorrect;
            genderString = CheckInputValue("пол", method);

            int age = Convert.ToInt32(ageString);
            Gender gender = (Gender)Enum.Parse(typeof(Gender), genderString, true);

            return new Person(firstName, lastName, age, gender);
        }

        /// <summary>
        /// Принимает от пользователя параметр и вызывает метод для проверки этого параметра.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="method"></param>
        /// <returns>Строка, введённая пользователем.</returns>
        private static string CheckInputValue(string id, Check method)
        {
            string param;
            bool k;
            do
            {
                k = true;
                Console.Write($"Введите {id} персоны: ");
                param = Console.ReadLine();
                try
                {
                    method(param);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    k = false;
                }
            }
            while (k == false);
            return param;
        }

        /// <summary>
        /// Преобразует имя и фамилию в правильный регистр.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Имя/фамилия с первой заглавной буквой и прописными остальными.</returns>
        private static string RightRegister(string name)
        {
            string rightName = name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
            int index;
            for (int i = 0; i < rightName.Length; i++)
            {
                if ((rightName[i] == ' ') || (rightName[i] == '-'))
                {
                    index = i;
                    rightName = rightName.Substring(0, i + 1) + rightName.Substring(i + 1, 1).ToUpper() 
                        + rightName.Substring(i + 2).ToLower();
                    break;
                }
            }
            return rightName;
        }
    }
}
