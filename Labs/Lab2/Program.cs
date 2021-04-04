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
            //Adult test = new Adult
            //(
            //    "Lol",
            //    "Kek",
            //    40,
            //    Gender.Male,
            //    "1234",
            //    "567890"
            //);
            //
            //test.GetAJob("офисный планктон");
            //
            //Console.WriteLine(test.Info);

            //for (int i = 0; i < 10; i++)
            //{
            //    Passport test = Passport.GetRandomPassport();
            //    Console.WriteLine($"{test.Series} {test.Number}\n");
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Adult test = RandomPerson.GetSingleAdult();
            //    Console.WriteLine(test.Info);
            //}

            List<Adult> test = RandomPerson.GetChildlessAdultPair();

            foreach(Adult chel in test)
            {
                Console.WriteLine(chel.Info);
            }

            Console.ReadKey();
        }
    }
}
