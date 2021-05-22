using System;
using System.Numerics;

namespace Model
{
    /// <summary>
    /// Абстрактный пассивный элемент электрической схемы.
    /// </summary>
    public abstract class PassiveElementBase
    {
        /// <summary>
        /// Наименование элемента.
        /// </summary>
        private string _name;

        /// <summary>
        /// Наименование элемента.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Наименование не может быть " +
                        "пустой строкой или null.");
                }
            }
        }

        //TODO: цепочка конструкторов +
        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        protected PassiveElementBase() : this("не задано") { }

        /// <summary>
        /// Конструктор класса PassiveElementBase.
        /// </summary>
        /// <param name="name">Наименование элемента</param>
        protected PassiveElementBase(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Возвращает комплексное сопротивление элемента.
        /// </summary>
        /// <param name="frequency">Частота электрического тока.</param>
        /// <returns>Комплексное сопротивление.</returns>
        public abstract Complex Impedance(int frequency);

        /// <summary>
        /// Проверка частоты тока.
        /// </summary>
        /// <param name="frequency">Частота.</param>
        protected void CheckFrequency(int frequency)
        {
            if (frequency < 0)
            {
                throw new ArgumentException("Частота должна быть больше нуля.");
            }
        }
    }
}
