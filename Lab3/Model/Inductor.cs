using System;
using System.Numerics;

namespace Model
{
    [Serializable]
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

        /// <summary>
        /// 
        /// </summary>
        public override Complex Impedance
        {
            get
            {
                return new Complex(0, 2 * Math.PI * Frequency * Inductance);
            }
        }

        public Inductor() { }

        //TODO: +
        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        //public Inductor() : this ("не задано", 1) { }

        //TODO: +
        /// <summary>
        /// Конструктор класса Inductor.
        /// </summary>
        /// <param name="name">Наименование индуктивности.</param>
        /// <param name="inductance">Индуктивность.</param>
        public Inductor(string name, double inductance) : base(name)
        {
            Inductance = inductance;
        }

        /// <summary>
        /// Возвращает комплексное сопротивление элемента.
        /// </summary>
        /// <param name="frequency">Частота электрического тока.</param>
        /// <returns>Комплексное сопротивление.</returns>
        //public override Complex Impedance(int frequency)
        //{
        //    CheckFrequency(frequency);
        //    return new Complex(0, 2 * Math.PI * frequency * Inductance);
        //}
    }
}
