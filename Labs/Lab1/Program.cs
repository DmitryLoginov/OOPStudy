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

            for (int i = 0; i < 3; i++)
            {
                firstList.Add(RandomPerson.GetRandomPerson());
            }

            firstList.Add("Kek", "Lol", 20, Gender.Male);

            for (int i = 0; i < 3; i++)
            {
                firstList.Add(RandomPerson.GetRandomPerson());
            }

            Console.WriteLine("\nСодержимое первого списка:\n");
            for (int i = 0; i < firstList.Count(); i++)
            {
                Console.WriteLine(firstList.Print(i));
            }

            int[] index = firstList.FindIndex("Kek", "Lol");

            for (int i = 0; i < index.Length; i++)
            {
                Console.WriteLine(index[i]);
            }

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
    }
}
