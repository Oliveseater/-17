using System;
using System.IO;
using System.Linq;

namespace prakt17_OAP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Какое слово хотите найти?");
                string serchWord = Console.ReadLine().ToLower();

                StreamReader sr = File.OpenText("input.txt");
                string[] words_file = sr.ReadToEnd().ToLower().Split(new char[] { ' ' });
                sr.Close();

                var selectedWords = words_file.Where(u => u == serchWord).Count();
                Console.WriteLine("Кол-во нужного слова в файле - " + selectedWords);
            }
            catch
            {
                Console.WriteLine("Возникла ошибка");
            }
        }
    }
}
