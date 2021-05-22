using System;
using System.Numerics;
namespace Model
{
    /// <summary>
    /// Резистор.
    /// </summary>
    public class Resistor : PassiveElementBase
    {
        //TODO: 
        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Resistor()
        {
        }

        /// <summary>
        /// Конструктор класса Resistor.
        /// </summary>
        /// <param name="name">Наименование резистора.</param>
        /// <param name="resistance">Активное сопротивление.</param>
        public Resistor(string name, double resistance) : base(name, resistance)
        {
        }

        /// <summary>
        /// Возвращает комплексное сопротивление элемента.
        /// </summary>
        /// <param name="frequency">Частота электрического тока.</param>
        /// <returns>Комплексное сопротивление.</returns>
        public override Complex Impedance(int frequency)
        {
            CheckFrequency(frequency);
            return new Complex(Resistance, 0);
        }
    }
}
