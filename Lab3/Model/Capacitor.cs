using System;
using System.Numerics;

namespace Model
{
    /// <summary>
    /// Конденсатор.
    /// </summary>
    [Serializable]
    public class Capacitor : PassiveElementBase
    {
        /// <summary>
        /// Ёмкость.
        /// </summary>
        private double _capacitance;

        /// <summary>
        /// Ёмкость.
        /// </summary>
        public double Capacitance
        {
            get
            {
                return _capacitance;
            }

            set
            {
                if (value > 0)
                {
                    _capacitance = value;
                }
                else
                {
                    throw new ArgumentException("Ёмкость должна быть " +
                        "больше нуля.");
                }
            }
        }

        /// <summary>
        /// Комплексное сопротивление ёмкостного элемента.
        /// </summary>
        public override Complex Impedance
        {
            get
            {
                return new Complex(0, -1 / (2 * Math.PI * Frequency * Capacitance));
            }
        }

        /// <summary>
        /// Конструктор класса Capacitor без параметров для сериализации.
        /// </summary>
        public Capacitor() { }

        /// <summary>
        /// Конструктор класса Capacitor.
        /// </summary>
        /// <param name="name">Наименование конденсатора.</param>
        /// <param name="capacitance">Ёмкость.</param>
        public Capacitor(string name, double capacitance) : base(name)
        {
            Capacitance = capacitance;
        }
    }
}
