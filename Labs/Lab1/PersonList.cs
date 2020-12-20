using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class PersonList
    {
        Person[] data;

        // Конструктор класса
        public PersonList()
        {
            data = new Person[0];
        }

        // Индексатор
        public Person this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }

        // Добавление новой персоны
        public void Add(string firstName, string lastName, uint age, Gender gender)
        {
            Array.Resize<Person>(ref data, data.Length + 1);
            data[data.Length - 1] = new Person(firstName, lastName, age, gender);
            //return data[data.Length - 1];
        }

        // Удаление элемента по индексу
        public void Delete(int index)
        {
            Person[] temp = new Person[data.Length];
            Array.Copy(data, temp, data.Length);
            Array.Resize<Person>(ref data, data.Length - 1);
            Array.Copy(temp, index + 1, data, index, temp.Length - index - 1);
        }

        // Вывод в консоль персоны по индексу
        public void Print(int index)
        {
            Console.Write($"{data[index].FirstName}\t");
            Console.Write($"{data[index].LastName}\t");
            Console.Write($"{data[index].Age}\t");
            Console.Write($"{data[index].Gender}\t\n");
        }

        // Вывод в консоль всех персон в списке
        public void PrintAll()
        {
            for (int i = 0; i < data.Length; i++)
            {
                Print(i);
            }
            //foreach (Person person in data)
            //{
            //    Console.Write($"{person.FirstName}\t");
            //    Console.Write($"{person.LastName}\t");
            //    Console.Write($"{person.Age}\t");
            //    Console.Write($"{person.Gender}\t\n");
            //}
        }

        // Очистить список
        public void Erase()
        {
            Array.Resize<Person>(ref data, 0);
        }

        // Получение количества элементов списка
        public int Length()
        {
            return data.Length;
        }

    }
}
