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
        /// Активное сопротивление.
        /// </summary>
        private double _resistance;

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

        /// <summary>
        /// Активное сопротивление.
        /// </summary>
        public double Resistance
        {
            get
            {
                return _resistance;
            }
            set
            {
                if (value > 0)
                {
                    _resistance = value;
                }
                else
                {
                    throw new ArgumentException("Активное сопротивление " +
                        "должно быть больше нуля.");
                }
            }
        }

        //TODO: цепочка конструкторов
        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        protected PassiveElementBase()
        {
            Name = "не задано";
            Resistance = 1;
        }

        /// <summary>
        /// Конструктор класса PassiveElementBase.
        /// </summary>
        /// <param name="name">Наименование элемента</param>
        /// <param name="resistance">Активное сопротивление.</param>
        protected PassiveElementBase(string name, double resistance)
        {
            Name = name;
            Resistance = resistance;
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
