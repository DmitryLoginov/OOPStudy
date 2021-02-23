using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    /// <summary>
    /// Класс, описывающий абстракцию списка, содержащего объекты класса Person.
    /// </summary>
    public class PersonList
    {
        /// <summary>
        /// Массив переменных типа Person.
        /// </summary>
        private Person[] _data;

        /// <summary>
        /// Количество персон в списке.
        /// </summary>
        public int Count
        {
            get
            {
                return _data.Length;
            }
        }

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
        /// <returns>Персона по индексу.</returns>
        /// <exception cref="System.IndexOutOfRangeException">
        /// Возникает при указании индекса вне границ массива.
        /// </exception>
        public Person this[int index]
        {
            get
            {
                return _data[index];
            }
            set
            {
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
            Add(new Person(firstName, lastName, age, gender));
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
        /// <exception cref="System.IndexOutOfRangeException">
        /// Возникает при указании индекса вне границ массива.
        /// </exception> 
        public void DeleteByIndex(int index)
        {
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
        /// <exception cref="System.IndexOutOfRangeException">
        /// Возникает при указании индекса вне границ массива.
        /// </exception>
        public string Print(int index)
        {
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
                //TODO: Дубли +
                str = str + Print(i) + "\n";
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
    }
}
