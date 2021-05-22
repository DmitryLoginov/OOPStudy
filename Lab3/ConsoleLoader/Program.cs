using System;
using System.Collections.Generic;

using Model;

namespace ConsoleLoader
{
    /// <summary>
    /// Класс Program для тестирования.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var electricComponents = new List<PassiveElementBase>();

            while (true)
            {
                Console.WriteLine("Выберите действие:\n" +
                    "\t1 - добавить в список резистор;\n" +
                    "\t2 - добавить в список конденсатор;\n" +
                    "\t3 - добавить в список индуктивность;\n" +
                    "\t4 - посчитать и вывести комплексные сопротивления" +
                    " элементов в списке;\n" +
                    "\t5 - выйти из программы.");
                string key = Console.ReadLine();
                switch (key)
                {
                    case "1":
                    {
                        electricComponents.Add(InputResistor());
                        Console.WriteLine("Ввод завершён.\n");
                        break;
                    }
                    case "2":
                    {
                        electricComponents.Add(InputCapacitor());
                        Console.WriteLine("Ввод завершён.\n");
                        break;
                    }
                    case "3":
                    {
                        electricComponents.Add(InputInductor());
                        Console.WriteLine("Ввод завершён.\n");
                        break;
                    }
                    case "4":
                    {
                        while(true)
                        {
                            try
                            {
                                Console.Write("Введите частоту переменного тока: ");
                                string frequencyString = Console.ReadLine();
                                if (!Int32.TryParse(frequencyString, out int frequency))
                                {
                                    throw new ArgumentException("Частота должна быть числом");
                                }
                                foreach (PassiveElementBase element in electricComponents)
                                {
                                    Console.WriteLine(element.Name + "\t" + element.Impedance(frequency) + " Ом");
                                }
                                break;
                            }
                            catch (Exception exception)
                            {
                                Console.WriteLine($"{exception.Message}\nПопробуйте снова.");
                            }
                        }
                        Console.WriteLine();
                        break;
                    }
                    case "5":
                    {
                        return;
                    }
                    default:
                    {
                        Console.WriteLine("Некорректный ввод, попробуйте снова.\n");
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Ввод базовых параметров объекта PassiveElementBase.
        /// </summary>
        /// <param name="element">Объект типа PassiveElementBase</param>
        private static void InputBaseParams(PassiveElementBase element)
        {
            var validationActions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.Write("Введите название элемента: ");
                    element.Name = Console.ReadLine();
                }),
                new Action(() =>
                {
                    //TODO: дублирование
                    Console.Write("Введите значение активного сопротивления элемента: ");
                    string resistanceString = Console.ReadLine();
                    resistanceString = resistanceString.Replace('.', ',');
                    if (!Double.TryParse(resistanceString, out double resistance))
                    {
                        throw new ArgumentException("Активное сопротивление должно быть числом.");
                    }
                    element.Resistance = resistance;
                })
            };

            foreach (var actionItem in validationActions)
            {
                ValidateInput(actionItem);
            }
        }
        
        /// <summary>
        /// Проверка вводимых пользователем параметров.
        /// </summary>
        /// <param name="validationAction">Делегат.</param>
        private static void ValidateInput(Action validationAction)
        {
            while (true)
            {
                try
                {
                    validationAction();
                    return;
                }
                catch (Exception exception)
                {
                    Console.WriteLine($"{exception.Message}\nПопробуйте снова.");
                }
            }
        }

        /// <summary>
        /// Ввод параметров объекта Resistor.
        /// </summary>
        /// <returns>Объект типа Resistor.</returns>
        private static Resistor InputResistor()
        {
            Resistor resistor = new Resistor();
            InputBaseParams(resistor);
            return resistor;
        }

        /// <summary>
        /// Ввод параметров объекта Capacitor.
        /// </summary>
        /// <returns>Объект типа Capacitor.</returns>
        private static Capacitor InputCapacitor()
        {
            Capacitor capacitor = new Capacitor();
            InputBaseParams(capacitor);

            var validationAction = new Action(() =>
            {
                //TODO: дублирование
                Console.Write("Введите значение ёмкости: ");
                string capacitanceString = Console.ReadLine();
                capacitanceString = capacitanceString.Replace('.', ',');
                if (!Double.TryParse(capacitanceString, out double capacitance))
                {
                    throw new ArgumentException("Ёмкость должна быть числом.");
                }
                capacitor.Capacitance = capacitance;
            });

            ValidateInput(validationAction);
            
            return capacitor;
        }

        /// <summary>
        /// Ввод параметров объекта Inductor.
        /// </summary>
        /// <returns>Объект типа Inductor.</returns>
        private static Inductor InputInductor()
        {
            Inductor inductor = new Inductor();
            InputBaseParams(inductor);

            var validationAction = new Action(() =>
            {
                //TODO: дублирование
                Console.Write("Введите значение индуктивности: ");
                string inductanceString = Console.ReadLine();
                inductanceString = inductanceString.Replace('.', ',');
                if (!Double.TryParse(inductanceString, out double inductance))
                {
                    throw new ArgumentException("Ёмкость должна быть числом.");
                }
                inductor.Inductance = inductance;
            });

            ValidateInput(validationAction);

            return inductor;
        }
    }
}
