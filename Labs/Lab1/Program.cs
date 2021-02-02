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
            
            firstList.Add("Методика", "Войти", 18, Gender.Female);
            firstList.Add("Главная", "Тест", 27, Gender.Female);
            firstList.Add("Средства", "Окно", 18, Gender.Male);
            
            secondList.Add("Обозреватель", "Свойства", 37, Gender.Male);
            secondList.Add("Список", "Сообщение", 11, Gender.Male);
            secondList.Add("Правка", "Анализ", 28, Gender.Female);
            
            Console.WriteLine("Содержимое первого списка:\n");
            for (int i = 0; i < firstList.Count(); i++)
            {
                Console.WriteLine(firstList.Print(i));
            }

            Console.ReadKey();

            Console.WriteLine("\nСодержимое второго списка:\n");
            for (int i = 0; i < secondList.Count(); i++)
            {
                Console.WriteLine(secondList.Print(i));
            }

            Console.ReadKey();
            Console.WriteLine("\nДобавление нового человека в первый список\n" +
                "Копирование второго человека из первого списка в конец второго списка");

            firstList.Add("Новый", "Человек", 28, Gender.Male);
            secondList.Add("Новый", "Человек", 28, Gender.Male);
            secondList[3] = firstList[1];
            
            Console.WriteLine("\nСодержимое первого списка:\n");
            for (int i = 0; i < firstList.Count(); i++)
            {
                Console.WriteLine(firstList.Print(i));
            }

            Console.ReadKey();

            Console.WriteLine("\nСодержимое второго списка:\n");
            for (int i = 0; i < secondList.Count(); i++)
            {
                Console.WriteLine(secondList.Print(i));
            }

            Console.ReadKey();
            Console.WriteLine("\nУдаление второго человека из первого списка");

            firstList.Delete(1);
            
            Console.WriteLine("\nСодержимое первого списка:\n");
            for (int i = 0; i < firstList.Count(); i++)
            {
                Console.WriteLine(firstList.Print(i));
            }

            Console.ReadKey();

            Console.WriteLine("\nСодержимое второго списка:\n");
            for (int i = 0; i < secondList.Count(); i++)
            {
                Console.WriteLine(secondList.Print(i));
            }

            Console.ReadKey();
            Console.WriteLine("\nОчистка второго списка");

            secondList.Erase();

            Console.WriteLine("\nСодержимое первого списка:\n");
            for (int i = 0; i < firstList.Count(); i++)
            {
                Console.WriteLine(firstList.Print(i));
            }

            Console.ReadKey();

            Console.WriteLine("\nСодержимое второго списка:\n");
            for (int i = 0; i < secondList.Count(); i++)
            {
                Console.WriteLine(secondList.Print(i));
            }


            //PersonList people = new PersonList();
            //
            //Console.WriteLine("тест:\n");
            //Console.WriteLine($"Количество элементов списка равно {people.Count()}");
            //people.PrintAll();
            //
            //people.Add("Чек", "тест", 20, Gender.Male);
            //Console.WriteLine("\nтест:\n");
            //Console.WriteLine($"Количество элементов списка равно {people.Count()}");
            //people.PrintAll();
            //
            //people.Add("Хочу", "жрать", 20, Gender.Male);
            //people.Add("Ммм", "кфс", 20, Gender.Male);
            //Console.WriteLine("\nтест:\n");
            //Console.WriteLine($"Количество элементов списка равно {people.Count()}");
            //people.PrintAll();
            //
            //// blah blah blah
            //people.Delete(1);
            //Console.WriteLine("\nтест:\n");
            //Console.WriteLine($"Количество элементов списка равно {people.Count()}");
            //people.PrintAll();
            //
            //people.Erase();
            //Console.WriteLine("\nтест:\n");
            //people.PrintAll();
            //
            Console.ReadKey();
        }
    }
}
