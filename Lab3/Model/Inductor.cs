using System;
using System.Numerics;

namespace Model
{
    /// <summary>
    /// Индуктивность.
    /// </summary>
    [Serializable]
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
        /// Комплексное сопротивлние индуктивного элемента.
        /// </summary>
        public override Complex Impedance
        {
            get
            {
                return new Complex(0, 2 * Math.PI * Frequency * Inductance);
            }
        }

        //TODO: XML комментарии? +
        /// <summary>
        /// Конструктор класса Inductor без параметров для сериализации.
        /// </summary>
        public Inductor() { }

        /// <summary>
        /// Конструктор класса Inductor.
        /// </summary>
        /// <param name="name">Наименование индуктивности.</param>
        /// <param name="inductance">Индуктивность.</param>
        public Inductor(string name, double inductance) : base(name)
        {
            Inductance = inductance;
        }
    }
}
