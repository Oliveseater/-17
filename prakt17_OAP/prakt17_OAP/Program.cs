using System;
using System.IO;
using System.Linq;

namespace prakt17_OAP
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Какое слово хотите найти?");
            string serchWord = Console.ReadLine().ToLower();
            if (serchWord != null)
            {
                StreamReader sr = File.OpenText("input.txt");
                if (File.Exists("input.txt"))
                {
                    string proverka = sr.ReadToEnd();
                    if (proverka != "")
                    {
                        string[] words_file = sr.ReadToEnd().ToLower().Split(new char[] { ' ' });
                        var selectedWords = words_file.Where(u => u == serchWord).Count();
                        Console.WriteLine("Кол-во нужного слова в файле - " + selectedWords);
                    }
                    else Console.WriteLine("Файл пуст");
                    sr.Close();
                }
                else Console.WriteLine("Файл не найден");
            }
            else Console.WriteLine("Введена пустая строка");
        }
    }
}
