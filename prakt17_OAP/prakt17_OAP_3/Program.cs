using System;
using System.IO;
using System.Linq;

namespace prakt17_OAP_3
{
    class Program
    {
        static int DigitCount(double[] wow, double b)
        {
            int count = 0;

            foreach (var i in wow)
                if (i == b) count++;

            return count;
        }

        static void Main(string[] args)
        {
            try
            {
                double[] wow = { 5.1, 3, 9.2, 3, 2.3, 5.1, 3 };
                for (int i = 0; i < wow.Length; i++)
                {
                    Console.WriteLine(wow[i]);
                }
                Console.WriteLine("----------------------------------------------------------");

                var select = wow.GroupBy(x => x).OrderBy(g => g.Count()).Select(g => g.Key);
                foreach (var x in select)
                    Console.WriteLine(x + " - " + DigitCount(wow, x));
                Console.WriteLine("----------------------------------------------------------");
                foreach (var x in select)
                {
                    if (DigitCount(wow, x) > 1)
                    {
                        Console.WriteLine(x * 2 + " - " + DigitCount(wow, x));
                    }
                    else Console.WriteLine(x + " - " + DigitCount(wow, x));
                }
            }
            catch { Console.WriteLine("Возникла ошибка");  }
        }
    }
}
