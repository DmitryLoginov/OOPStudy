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
            //var electricComponents = new List<PassiveElementBase>();
            //
            //while (true)
            //{
            //    Console.WriteLine("Выберите действие:\n" +
            //        "\t1 - добавить в список резистор;\n" +
            //        "\t2 - добавить в список конденсатор;\n" +
            //        "\t3 - добавить в список индуктивность;\n" +
            //        "\t4 - посчитать и вывести комплексные сопротивления" +
            //        " элементов в списке;\n" +
            //        "\t5 - выйти из программы.");
            //    string key = Console.ReadLine();
            //    switch (key)
            //    {
            //        case "1":
            //        {
            //            electricComponents.Add(InputResistor());
            //            Console.WriteLine("Ввод завершён.\n");
            //            break;
            //        }
            //        case "2":
            //        {
            //            electricComponents.Add(InputCapacitor());
            //            Console.WriteLine("Ввод завершён.\n");
            //            break;
            //        }
            //        case "3":
            //        {
            //            electricComponents.Add(InputInductor());
            //            Console.WriteLine("Ввод завершён.\n");
            //            break;
            //        }
            //        case "4":
            //        {
            //            while(true)
            //            {
            //                try
            //                {
            //                    Console.Write("Введите частоту переменного тока: ");
            //                    string frequencyString = Console.ReadLine();
            //                    if (!Int32.TryParse(frequencyString, out int frequency))
            //                    {
            //                        throw new ArgumentException("Частота должна быть числом");
            //                    }
            //                    foreach (PassiveElementBase element in electricComponents)
            //                    {
            //                        Console.WriteLine(element.Name + "\t" + element.Impedance(frequency) + " Ом");
            //                    }
            //                    break;
            //                }
            //                catch (Exception exception)
            //                {
            //                    Console.WriteLine($"{exception.Message}\nПопробуйте снова.");
            //                }
            //            }
            //            Console.WriteLine();
            //            break;
            //        }
            //        case "5":
            //        {
            //            return;
            //        }
            //        default:
            //        {
            //            Console.WriteLine("Некорректный ввод, попробуйте снова.\n");
            //            break;
            //        }
            //    }
            //}
        }

        /// <summary>
        /// Принимает и проверяет параметр типа double.
        /// </summary>
        /// <param name="id">Строковый идентификатор.</param>
        /// <returns>Переменная типа double.</returns>
        //private static double InputParameter(string id)
        //{
        //    while (true)
        //    {
        //        try
        //        {
        //            
        //            Console.Write($"Введите {id}: ");
        //            string paramString = Console.ReadLine();
        //            paramString = paramString.Replace('.', ',');
        //            if (!Double.TryParse(paramString, out double param))
        //            {
        //                throw new ArgumentException($"Параметр \"{id}\" должен быть числом.");
        //            }
        //            return param;
        //        }
        //        catch (Exception exception)
        //        {
        //            Console.WriteLine($"{exception.Message}\nПопробуйте снова.");
        //        }
        //    }
        //    
        //}

        /// <summary>
        /// Ввод резистора с клавиатуры.
        /// </summary>
        /// <returns>Объект типа Resistor.</returns>
        //private static PassiveElementBase InputResistor()
        //{
        //    Resistor resistor = new Resistor();
        //    var inputFunc = new Func<PassiveElementBase>(() => 
        //    {
        //        resistor.Resistance = InputParameter("активное сопротивление");
        //        return resistor;
        //    });
        //    return GetParameter(inputFunc, resistor);
        //}

        /// <summary>
        /// Ввод ёмкости с клавиатуры.
        /// </summary>
        /// <returns>Объект типа Capacitor.</returns>
        //private static PassiveElementBase InputCapacitor()
        //{
        //    Capacitor capacitor = new Capacitor();
        //    var inputFunc = new Func<PassiveElementBase>(() => 
        //    {
        //        capacitor.Capacitance = InputParameter("ёмкость");
        //        return capacitor;
        //    });
        //    return GetParameter(inputFunc, capacitor);
        //}

        /// <summary>
        /// Ввод индуктивности с клавиатуры.
        /// </summary>
        /// <returns>Объект типа Inductor.</returns>
        //private static PassiveElementBase InputInductor()
        //{
        //    Inductor inductor = new Inductor();
        //    var inputFunc = new Func<PassiveElementBase>(() => 
        //    {
        //        inductor.Inductance = InputParameter("индуктивность");
        //        return inductor;
        //    });
        //    return GetParameter(inputFunc, inductor);
        //}

        //TODO: XML +
        /// <summary>
        /// Производит валидацию параметров объекта PassiveElementBase
        /// при вводе с клавиатуры.
        /// </summary>
        /// <param name="inputFunc">
        /// Делегат Func, возвращающий объект PassiveElementBase.
        /// </param>
        /// <param name="element">Объект типа PassiveElementBase.</param>
        /// <returns>Объект типа PassiveElementBase.</returns>
        //private static PassiveElementBase GetParameter(Func<PassiveElementBase> inputFunc, 
        //    PassiveElementBase element)
        //{
        //    Console.Write("Введите название элемента: ");
        //    element.Name = Console.ReadLine();
        //    while (true)
        //    {
        //        try
        //        {
        //            return inputFunc.Invoke();
        //        }
        //        catch (Exception exception)
        //        {
        //            Console.WriteLine($"{exception.Message}\nПопробуйте снова.");
        //        }
        //    }
        //}
    }
}
