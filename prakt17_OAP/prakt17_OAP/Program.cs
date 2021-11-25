using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

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

                List<string> words = new List<string>();
                for (int i = 0; i < words_file.Length; i++)
                {
                    words.Add(words_file[i]);
                }
                var selectedWords = words.Where(u => u == serchWord).Count();
                Console.WriteLine("Кол-во нужного слова в файле - " + selectedWords);
            }
            catch
            {
                Console.WriteLine("Возникла ошибка");
            }
        }
    }
}
