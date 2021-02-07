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
            PersonList firstList = new PersonList();
            PersonList secondList = new PersonList();

            Person test = ReadPerson();

            Console.WriteLine($"{test.FirstName} {test.LastName} {test.Age} {test.Gender}");

            //for (int i = 0; i < 3; i++)
            //{
            //    firstList.Add(RandomPerson.GetRandomPerson());
            //}
            //
            //firstList.Add("Kek", "Lol", 20, Gender.Male);
            //
            //for (int i = 0; i < 3; i++)
            //{
            //    firstList.Add(RandomPerson.GetRandomPerson());
            //}
            //
            //Console.WriteLine("\nСодержимое первого списка:\n");
            //for (int i = 0; i < firstList.Count(); i++)
            //{
            //    Console.WriteLine(firstList.Print(i));
            //}
            //
            //int[] index = firstList.FindIndex("Kek", "Lol");
            //
            //for (int i = 0; i < index.Length; i++)
            //{
            //    Console.WriteLine(index[i]);
            //}

            //Console.WriteLine(firstList.PrintAll());
            //Console.WriteLine("\nСодержимое первого списка:\n");
            //for (int i = 0; i < firstList.Count(); i++)
            //{
            //    Console.WriteLine(firstList.Print(i));
            //}


            //Console.ReadKey();
            //
            //Console.WriteLine("\nСодержимое второго списка:\n");
            //for (int i = 0; i < secondList.Count(); i++)
            //{
            //    Console.WriteLine(secondList.Print(i));
            //}
            //
            //Console.ReadKey();
            //Console.WriteLine("\nДобавление нового человека в первый список\n" +
            //    "Копирование второго человека из первого списка в конец второго списка");
            //
            //firstList.Add("Новый", "Человек", 28, Gender.Male);
            //secondList.Add("Новый", "Человек", 28, Gender.Male);
            //secondList[3] = firstList[1];
            //
            //Console.WriteLine("\nСодержимое первого списка:\n");
            //for (int i = 0; i < firstList.Count(); i++)
            //{
            //    Console.WriteLine(firstList.Print(i));
            //}
            //
            //Console.ReadKey();
            //
            //Console.WriteLine("\nСодержимое второго списка:\n");
            //for (int i = 0; i < secondList.Count(); i++)
            //{
            //    Console.WriteLine(secondList.Print(i));
            //}
            //
            //Console.ReadKey();
            //Console.WriteLine("\nУдаление второго человека из первого списка");
            //
            //firstList.Delete(1);
            //
            //Console.WriteLine("\nСодержимое первого списка:\n");
            //for (int i = 0; i < firstList.Count(); i++)
            //{
            //    Console.WriteLine(firstList.Print(i));
            //}
            //
            //Console.ReadKey();
            //
            //Console.WriteLine("\nСодержимое второго списка:\n");
            //for (int i = 0; i < secondList.Count(); i++)
            //{
            //    Console.WriteLine(secondList.Print(i));
            //}
            //
            //Console.ReadKey();
            //Console.WriteLine("\nОчистка второго списка");
            //
            //secondList.Erase();
            //
            //Console.WriteLine("\nСодержимое первого списка:\n");
            //for (int i = 0; i < firstList.Count(); i++)
            //{
            //    Console.WriteLine(firstList.Print(i));
            //}
            //
            //Console.ReadKey();
            //
            //Console.WriteLine("\nСодержимое второго списка:\n");
            //for (int i = 0; i < secondList.Count(); i++)
            //{
            //    Console.WriteLine(secondList.Print(i));
            //}

            Console.ReadKey();
        }

        /// <summary>
        /// Ведёт диалог с пользователем для ввода персоны с клавиатуры.
        /// </summary>
        /// <returns></returns>
        private static Person ReadPerson() // надо убрать дублирование
        {
            string firstName, lastName, ageString, genderString;
            int age;
            Gender gender;
            bool k = true;

            do
            {
                k = true;
                Console.Write("Введите имя персоны: ");
                firstName = Console.ReadLine();
                try
                {
                    Person.IsNameCorrect(firstName);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    k = false;
                }
            }
            while (k == false);

            do
            {
                k = true;
                Console.Write("Введите фамилию персоны: ");
                lastName = Console.ReadLine();
                try
                {
                    Person.IsNameCorrect(lastName);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    k = false;
                }
            }
            while (k == false);

            do
            {
                k = true;
                Console.Write("Введите возраст персоны: ");
                ageString = Console.ReadLine();
                try
                {
                    Person.IsAgeCorrect(ageString);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    k = false;
                }
            }
            while (k == false);
            age = Convert.ToInt32(ageString);

            do
            {
                k = true;
                Console.Write("Введите пол персоны: ");
                genderString = Console.ReadLine();
                try
                {
                    Person.IsGenderCorrect(genderString);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    k = false;
                }
            }
            while (k == false);
            gender = (Gender)Enum.Parse(typeof(Gender), genderString, true);

            return new Person(firstName, lastName, age, gender);
        }
    }
}
