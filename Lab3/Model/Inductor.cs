using System;
using System.Numerics;

namespace Model
{
    /// <summary>
    /// Индуктивность.
    /// </summary>
    public class Inductor : PassiveElementBase
    {
        /// <summary>
        /// Индуктивность.
        /// </summary>
        private double _inductance;

        /// <summary>
        /// Индуктивность.
        /// </summary>
        public double Inductance
        {
            get
            {
                return _inductance;
            }

            set
            {
                if (value > 0)
                {
                    _inductance = value;
                }
                else
                {
                    throw new ArgumentException("Индуктивность " +
                        "должна быть больше нуля.");
                }
            }
        }

        //TODO: 
        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Inductor()
        {

        }

        //TODO: 
        /// <summary>
        /// Конструктор класса Inductor.
        /// </summary>
        /// <param name="name">Наименование резистора.</param>
        /// <param name="resistance">Активное сопротивление.</param>
        /// <param name="inductance">Индуктивность.</param>
        public Inductor(string name, double resistance, 
            double inductance) : base(name, resistance)
        {
            Inductance = inductance;
        }

        /// <summary>
        /// Возвращает комплексное сопротивление элемента.
        /// </summary>
        /// <param name="frequency">Частота электрического тока.</param>
        /// <returns>Комплексное сопротивление.</returns>
        public override Complex Impedance(int frequency)
        {
            CheckFrequency(frequency);
            return new Complex(Resistance, 2 * Math.PI * 
                frequency * Inductance);
        }
    }
}
