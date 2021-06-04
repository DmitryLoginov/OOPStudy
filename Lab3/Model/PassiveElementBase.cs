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
        /// //TODO:
        /// </summary>
        private int _frequency;

        /// <summary>
        /// //TODO:
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
        /// 
        /// </summary>
        public virtual Complex Impedance { get; }

        //TODO:
        /// <summary>
        /// 
        /// </summary>
        public PassiveElementBase() { }
        
        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        //protected PassiveElementBase() : this("не задано") { }

        /// <summary>
        /// Конструктор класса PassiveElementBase.
        /// </summary>
        /// <param name="name">Наименование элемента</param>
        protected PassiveElementBase(string name)
        {
            Name = name;
        }

        //TODO:
        /// <summary>
        /// Возвращает комплексное сопротивление элемента.
        /// </summary>
        /// <param name="frequency">Частота электрического тока.</param>
        /// <returns>Комплексное сопротивление.</returns>
        //public abstract Complex Impedance(int frequency);

        /// <summary>
        /// Проверка частоты тока.
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
