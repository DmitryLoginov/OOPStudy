using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    /// <summary>
    /// Класс, описывающий абстракцию списка, содержащего объекты класса Person.
    /// </summary>
    public class PersonList
    {
        private Person[] _data;

        /// <summary>
        /// Конструктор класса PersonList.
        /// </summary>
        public PersonList()
        {
            _data = new Person[0];
        }

        /// <summary>
        /// Индексатор.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Person this[int index]
        {
            get
            {
                if ((index < 0) || (index > (_data.Length - 1)))
                {
                    throw new IndexOutOfRangeException("Выход за границы массива.");
                }
                return _data[index];
            }
            set
            {
                if ((index < 0) || (index > (_data.Length - 1)))
                {
                    throw new IndexOutOfRangeException("Выход за границы массива.");
                }
                _data[index] = value;
            }
        }

        /// <summary>
        /// Добавляет новую персону в конец списка.
        /// </summary>
        /// <param name="firstName">Имя персоны.</param>
        /// <param name="lastName">Фамилия персоны.</param>
        /// <param name="age">Возраст персоны.</param>
        /// <param name="gender">Пол персоны.</param>
        public void Add(string firstName, string lastName, int age, Gender gender)
        {
            Array.Resize<Person>(ref _data, _data.Length + 1);
            _data[_data.Length - 1] = new Person(firstName, lastName, age, gender);
        }

        /// <summary>
        /// Добавляет новую персону в конец списка.
        /// </summary>
        /// <param name="person">Переменная типа Person.</param>
        public void Add(Person person)
        {
            Array.Resize<Person>(ref _data, _data.Length + 1);
            _data[_data.Length - 1] = person;
        }

        /// <summary>
        /// Удаляет персону по индексу.
        /// </summary>
        /// <param name="index">Индекс персоны в списке.</param>
        public void DeleteByIndex(int index)
        {
            if ((index < 0) || (index > (_data.Length - 1)))
            {
                throw new IndexOutOfRangeException("Выход за границы массива.");
            }
            Person[] tmpArray = new Person[_data.Length];
            Array.Copy(_data, tmpArray, _data.Length);
            Array.Resize<Person>(ref _data, _data.Length - 1);
            Array.Copy(tmpArray, index + 1, _data, index, tmpArray.Length - index - 1);
        }

        /// <summary>
        /// Удаляет персону по имени и фамилии.
        /// </summary>
        /// <param name="firstName">Имя персоны.</param>
        /// <param name="lastName">Фамилия персоны.</param>
        public void DeleteByName(string firstName, string lastName)
        {
            Person[] tmpArray = new Person[0];
            for (int i = 0; i < _data.Length; i++)
            {
                if ((_data[i].FirstName != firstName) && (_data[i].LastName != lastName))
                {
                    Array.Resize<Person>(ref tmpArray, tmpArray.Length + 1);
                    tmpArray[tmpArray.Length - 1] = _data[i];
                }
            }
            _data = tmpArray;
        }

        /// <summary>
        /// Выводит на экран персону по указанному индексу.
        /// </summary>
        /// <param name="index">Индекс персоны в списке.</param>
        /// <returns>Строка, содержащая имя, фамилию, пол и возраст персоны.</returns>
        public string Print(int index)
        {
            if ((index < 0) || (index > (_data.Length - 1)))
            {
                throw new IndexOutOfRangeException("Выход за границы массива.");
            }
            return $"{_data[index].FirstName} {_data[index].LastName}, " +
                $"пол: {_data[index].Gender}, возраст: {_data[index].Age}";
        }

        /// <summary>
        /// Выводит всех персон в списке.
        /// </summary>
        /// <returns>Строка с информацией о персонах в списке.</returns>
        public string PrintAll()
        {
            string str = "";
            for (int i = 0; i < _data.Length; i++)
            {
                str = str + $"{_data[i].FirstName} {_data[i].LastName}, " +
                    $"пол: {_data[i].Gender}, возраст: {_data[i].Age}\n";
            }
            return str;
        }

        /// <summary>
        /// Осуществляет поиск индексов элементов при наличии их в списке.
        /// </summary>
        /// <param name="firstName">Имя персоны.</param>
        /// <param name="lastName">Фамилия персоны.</param>
        /// <returns>Массив индексов персон, удовлетворяющих условиям.</returns>
        public int[] FindIndex(string firstName, string lastName)
        {
            int[] index = new int[0];
            for (int i = 0; i < _data.Length; i++)
            {
                if ((_data[i].FirstName == firstName) && (_data[i].LastName == lastName))
                {
                    Array.Resize<int>(ref index, index.Length + 1);
                    index[index.Length - 1] = i;
                }
            }
            return index;
        }

        /// <summary>
        /// Удаляет всех персон в списке.
        /// </summary>
        public void Erase()
        {
            Array.Resize<Person>(ref _data, 0);
        }

        /// <summary>
        /// Возвращает количество персон в списке.
        /// </summary>
        /// <returns>Целое число персон в списке.</returns>
        public int Count()
        {
            return _data.Length;
        }
    }
}
