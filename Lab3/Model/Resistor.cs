using System;
using System.Numerics;
namespace Model
{
    /// <summary>
    /// Резистор.
    /// </summary>
    [Serializable]
    public class Resistor : PassiveElementBase
    {

        /// <summary>
        /// Активное сопротивление
        /// </summary>
        private double _resistance;

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

        /// <summary>
        /// Комплексное сопротивление резистора.
        /// </summary>
        public override Complex Impedance
        {
            get
            {
                return Resistance;
            }
        }

        //TODO: XML комментарии? +
        /// <summary>
        /// Конструктор класса Resistor без параметров для сериализации.
        /// </summary>
        public Resistor() { }

        /// <summary>
        /// Конструктор класса Resistor.
        /// </summary>
        /// <param name="name">Наименование резистора.</param>
        /// <param name="resistance">Активное сопротивление.</param>
        public Resistor(string name, double resistance) : base(name)
        {
            Resistance = resistance;
        }
    }
}
