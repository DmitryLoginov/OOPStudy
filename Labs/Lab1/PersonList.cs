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
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        public void Add(string firstName, string lastName, int age, Gender gender)
        {
            Array.Resize<Person>(ref _data, _data.Length + 1);
            _data[_data.Length - 1] = new Person(firstName, lastName, age, gender);
        }

        /// <summary>
        /// Добавляет новую персону в конец списка.
        /// </summary>
        /// <param name="person"></param>
        public void Add(Person person)
        {
            Array.Resize<Person>(ref _data, _data.Length + 1);
            _data[_data.Length - 1] = person;
        }

        /// <summary>
        /// Удаляет персону по индексу.
        /// </summary>
        /// <param name="index"></param>
        public void DeleteByIndex(int index)
        {
            Person[] temp = new Person[_data.Length];
            Array.Copy(_data, temp, _data.Length);
            Array.Resize<Person>(ref _data, _data.Length - 1);
            Array.Copy(temp, index + 1, _data, index, temp.Length - index - 1);
        }

        /// <summary>
        /// Удаляет персону по имени и фамилии.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public void DeleteByName(string firstName, string lastName)
        {
            Person[] temp = new Person[0];
            for (int i = 0; i < _data.Length; i++)
            {
                if ((_data[i].FirstName != firstName) && (_data[i].LastName != lastName))
                {
                    Array.Resize<Person>(ref temp, temp.Length + 1);
                    temp[temp.Length - 1] = _data[i];
                }
            }
            _data = temp;
        }

        /// <summary>
        /// Выводит на экран персону по указанному индексу.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Строка, содержащая имя, фамилию, пол и возраст персоны.</returns>
        public string Print(int index)
        {
            return $"{_data[index].FirstName} {_data[index].LastName}, " +
                $"пол: {_data[index].Gender}, возраст: {_data[index].Age}";
        }

        /// <summary>
        /// Выводит всех персон в списке.
        /// </summary>
        public string PrintAll()
        {
            string str = "";
            for (int i = 0; i < _data.Length; i++)
            {
                str = str + $"\n{_data[i].FirstName} {_data[i].LastName}, " +
                    $"пол: {_data[i].Gender}, возраст: {_data[i].Age}";
            }
            return str;
        }

        /// <summary>
        /// Осуществляет поиск индексов элементов при наличии их в списке.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
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
