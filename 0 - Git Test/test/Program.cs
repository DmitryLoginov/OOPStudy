using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Hello, World!"; // Заголовок консоли

            Console.ForegroundColor = ConsoleColor.Magenta; // Цвет текста в консоли

            Console.WriteLine("Hello, World!"); // Сообщение в консоли

            Console.ResetColor(); // Восстанавливаем стандартный цвет

            Console.WriteLine("\nНажмите любую клавишу, чтобы выйти..."); // Выход из программы
            Console.ReadKey();
        }
    }
}
