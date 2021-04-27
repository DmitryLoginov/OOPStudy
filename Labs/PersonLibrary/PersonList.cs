using System;

namespace PersonLibrary
{
    /// <summary>
    /// Класс, описывающий абстракцию списка, 
    /// содержащего объекты класса Person.
    /// </summary>
    public class PersonList
    {
        /// <summary>
        /// Массив переменных типа Person.
        /// </summary>
        private PersonBase[] _data;

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
            _data = new PersonBase[0];
        }

        /// <summary>
        /// Индексатор.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Персона по индексу.</returns>
        /// <exception cref="System.IndexOutOfRangeException">
        /// Выбрасывается при указании индекса вне границ массива.
        /// </exception>
        public PersonBase this[int index]
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
        /// <param name="person">Переменная типа Person.</param>
        public void Add(PersonBase person)
        {
            Array.Resize<PersonBase>(ref _data, _data.Length + 1);
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
            PersonBase[] tempArray = new PersonBase[_data.Length];
            Array.Copy(_data, tempArray, _data.Length);
            Array.Resize<PersonBase>(ref _data, _data.Length - 1);
            Array.Copy(tempArray, index + 1, _data, index, 
                tempArray.Length - index - 1);
        }

        /// <summary>
        /// Удаляет персону по имени и фамилии.
        /// </summary>
        /// <param name="firstName">Имя персоны.</param>
        /// <param name="lastName">Фамилия персоны.</param>
        public void DeleteByName(string firstName, string lastName)
        {
            PersonBase[] tempArray = new PersonBase[0];
            
            for (int i = 0; i < _data.Length; i++)
            {
                if ((_data[i].FirstName != firstName) && 
                    (_data[i].LastName != lastName))
                {
                    Array.Resize<PersonBase>(ref tempArray, tempArray.Length + 1);
                    tempArray[tempArray.Length - 1] = _data[i];
                }
            }
            
            _data = tempArray;
        }

        /// <summary>
        /// Выводит всех персон в списке.
        /// </summary>
        /// <returns>Строка с информацией о персонах в списке.</returns>
        public string PrintAll()
        {
            string outputString = string.Empty;
            
            for (int i = 0; i < _data.Length; i++)
            {
                outputString = outputString + _data[i].Info + "\n";
            }
            
            return outputString;
        }

        /// <summary>
        /// Осуществляет поиск индексов элементов при наличии их в списке.
        /// </summary>
        /// <param name="firstName">Имя персоны.</param>
        /// <param name="lastName">Фамилия персоны.</param>
        /// <returns>
        /// Массив индексов персон, удовлетворяющих условию.
        /// </returns>
        public int[] FindIndex(string firstName, string lastName)
        {
            int[] indexArray = new int[0];
            
            for (int i = 0; i < _data.Length; i++)
            {
                if ((_data[i].FirstName == firstName) && 
                    (_data[i].LastName == lastName))
                {
                    Array.Resize<int>(ref indexArray, indexArray.Length + 1);
                    indexArray[indexArray.Length - 1] = i;
                }
            }
            
            return indexArray;
        }

        /// <summary>
        /// Удаляет всех персон в списке.
        /// </summary>
        public void Clear()
        {
            Array.Resize<PersonBase>(ref _data, 0);
        }
    }
}
