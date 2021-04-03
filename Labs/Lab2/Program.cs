using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PersonLibrary;

namespace Lab2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Adult test = new Adult
            (
                "Lol",
                "Kek",
                40,
                Gender.Male,
                "1234",
                "567890"
            );

            test.GetAJob("офисный планктон");

            Console.WriteLine(test.Info);
            Console.ReadKey();
        }
    }
}
