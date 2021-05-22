using System;
using System.Numerics;

namespace Model
{
    /// <summary>
    /// Конденсатор.
    /// </summary>
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
        /// Конструктор по умолчани.
        /// </summary>
        public Capacitor() : this("не задано", 1) { }

        //TODO: 
        /// <summary>
        /// Конструктор класса Capacitor.
        /// </summary>
        /// <param name="name">Наименование конденсатора.</param>
        /// <param name="capacitance">Ёмкость.</param>
        public Capacitor(string name, double capacitance) : base(name)
        {
            Capacitance = capacitance;
        }

        /// <summary>
        /// Возвращает комплексное сопротивление элемента.
        /// </summary>
        /// <param name="frequency">Частота электрического тока.</param>
        /// <returns>Комплексное сопротивление.</returns>
        public override Complex Impedance(int frequency)
        {
            CheckFrequency(frequency);
            return new Complex(0, -1 / (2 * Math.PI * frequency * Capacitance));
        }
    }
}
