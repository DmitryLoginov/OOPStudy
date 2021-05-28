using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;

namespace Model
{
    /// <summary>
    /// Случайный пассивный элемент электрической цепи.
    /// </summary>
    public static class RandomPassiveElement
    {
        /// <summary>
        /// 
        /// </summary>
        private static Random _randNum = new Random();
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static PassiveElementBase GetRandomElement()
        {
            PassiveElementBase element;
            int key = _randNum.Next(0, 3);
            switch (key)
            {
                case 0:
                {
                    element = RandomResistor();
                    break;
                }
                case 1:
                {
                    element = RandomCapacitor();
                    break;
                }
                case 2:
                {
                    element = RandomInductor();
                    break;
                }
                default:
                {
                    throw new Exception("Ошибка.");
                }
            }

            return element;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="element"></param>
        private static void RandomBaseParams(PassiveElementBase element)
        {
            element.Name = RandomName();
            element.Frequency = _randNum.Next(1, 1000);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static string RandomName()
        {
            string name = String.Empty;
            
            for (int i = 0; i < 5; i++)
            {
                name += (char)_randNum.Next('A', 'Z');
            }
            name += '-';
            for (int i = 0; i < 3; i++)
            {
                name += _randNum.Next(0, 10);
            }

            return name;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Resistor RandomResistor()
        {
            Resistor resistor = new Resistor();

            RandomBaseParams(resistor);
            resistor.Resistance = _randNum.NextDouble() * 1000;

            return resistor;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Capacitor RandomCapacitor()
        {
            Capacitor capacitor = new Capacitor();

            RandomBaseParams(capacitor);
            capacitor.Capacitance = _randNum.NextDouble() / _randNum.Next(10, 1000);

            return capacitor;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Inductor RandomInductor()
        {
            Inductor inductor = new Inductor();

            RandomBaseParams(inductor);
            inductor.Inductance = _randNum.NextDouble() / _randNum.Next(10, 1000);

            return inductor;
        }
    }
}
