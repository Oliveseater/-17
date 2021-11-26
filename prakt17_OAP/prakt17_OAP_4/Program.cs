using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace prakt17_OAP_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contry> contry = new List<Contry>();
            contry.Add(new Contry() { nameContry = "Россия", population = 146023195});
            contry.Add(new Contry() { nameContry = "Сингапур", population = 6058739});
            contry.Add(new Contry() { nameContry = "США", population = 335028178});
            contry.Add(new Contry() { nameContry = "Франция", population = 65790152});
            contry.Add(new Contry() { nameContry = "Индия", population = 1408044253});
            contry.Add(new Contry() { nameContry = "Египет", population = 105838455});

            //длина строки
            var selectOrder = contry.OrderBy(x => x.nameContry.Length);
            foreach (var x in selectOrder)
                Console.WriteLine(x.nameContry + " - " + x.population);
            Console.WriteLine();

            //по численности от числа n, в порядке возрастания
            var selectOrderPopulation = contry.Where(a => a.population > 104000000).OrderBy(x => x.nameContry);
            foreach (var x in selectOrderPopulation)
                Console.WriteLine(x.nameContry + " - " + x.population);
        }
    }
}
