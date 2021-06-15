using System;
using System.Numerics;
using System.Xml.Serialization;

namespace Model
{
    /// <summary>
    /// Абстрактный пассивный элемент электрической схемы.
    /// </summary>
    [Serializable]
    [XmlInclude(typeof(Resistor))]
    [XmlInclude(typeof(Capacitor))]
    [XmlInclude(typeof(Inductor))]
    public abstract class PassiveElementBase
    {
        /// <summary>
        /// Наименование элемента.
        /// </summary>
        private string _name;

        /// <summary>
        /// Частота электрического тока.
        /// </summary>
        private int _frequency;

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
                    throw new ArgumentException("Название не может быть " +
                        "пустой строкой или null.");
                }
            }
        }

        /// <summary>
        /// Частота электрического тока.
        /// </summary>
        public int Frequency
        {
            get
            {
                return _frequency;
            }
            set
            {
                CheckFrequency(value);
                _frequency = value;
            }
        }

        /// <summary>
        /// Комплексное сопротивление элемента.
        /// </summary>
        public abstract Complex Impedance { get; }

        /// <summary>
        /// Конструктор класса PassiveElementBase без параметров для сериализации.
        /// </summary>
        protected PassiveElementBase() { }

        /// <summary>
        /// Конструктор класса PassiveElementBase.
        /// </summary>
        /// <param name="name">Наименование элемента</param>
        protected PassiveElementBase(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Проверяет частоту тока.
        /// </summary>
        /// <param name="frequency">Частота.</param>
        private void CheckFrequency(int frequency)
        {
            if (frequency < 0)
            {
                throw new ArgumentException("Частота должна быть больше либо равна нулю.");
            }
        }
    }
}
