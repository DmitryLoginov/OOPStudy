using System;
using System.Numerics;
namespace Model
{
    [Serializable]
    /// <summary>
    /// Резистор.
    /// </summary>
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
        /// 
        /// </summary>
        public override Complex Impedance
        {
            get
            {
                return Resistance;
            }
        }

        public Resistor() { }
        
        //TODO: +
        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        //public Resistor() : this("не задано", 1) { }

        /// <summary>
        /// Конструктор класса Resistor.
        /// </summary>
        /// <param name="name">Наименование резистора.</param>
        /// <param name="resistance">Активное сопротивление.</param>
        public Resistor(string name, double resistance) : base(name)
        {
            Resistance = resistance;
        }

        /// <summary>
        /// Возвращает комплексное сопротивление элемента.
        /// </summary>
        /// <param name="frequency">Частота электрического тока.</param>
        /// <returns>Комплексное сопротивление.</returns>
        //public override Complex Impedance(int frequency)
        //{
        //    CheckFrequency(frequency);
        //    return new Complex(Resistance, 0);
        //}
    }
}
