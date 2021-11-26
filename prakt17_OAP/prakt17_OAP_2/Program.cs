using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace prakt17_OAP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2
            string[] forPolisovatel = new string[10];
            Console.WriteLine("Введите 10 элементов в массив, с использованием цифр и знака /");

            List<string> searchNumbers = new List<string>(); // for A

            for (int i = 0; i < forPolisovatel.Length; i++)
            {
                forPolisovatel[i] = Console.ReadLine(); //заполнение массива 
                
                foreach (char c in forPolisovatel[i]) // for A
                {
                    searchNumbers.Add(c.ToString()); //получение обсолютно каждого символа, для поиска цифр
                }
            }

            // for A
            string[] numbers = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" }; //массив цифр для их поиска в массиве
            var selectedNumbers = 0;
            for (int n = 0; n < numbers.Length; n++)
            {
                selectedNumbers += searchNumbers.Where(u => u == numbers[n]).Count(); // поиск цифр среди символов и их счёт
            }
            Console.WriteLine("Кол-во цифр в массиве - " + selectedNumbers);
            Console.WriteLine();

            //for B
            for (int j = 0; j < forPolisovatel.Length; j++)
            {
                if (forPolisovatel[j].Contains("/"))
                    break;
                else Console.WriteLine(forPolisovatel[j]);
            }
            Console.WriteLine("Выведенны все элементы до элемента где содержится /");
            Console.WriteLine();

            //for C
            {
                StreamWriter sw = File.CreateText("newArray.txt");
                int character = 0;
                for (int j = 0; j < forPolisovatel.Length; j++)
                {
                    if (forPolisovatel[j].Contains("/"))
                        character = j;
                }
                for (int z = character; z < forPolisovatel.Length; z++)
                {
                    forPolisovatel[character] = string.Concat(forPolisovatel[character].Select(c => (char)(char.ToLower(c) ^ char.ToUpper(c) ^ c)));
                    Console.WriteLine(forPolisovatel[character]);
                    sw.WriteLine(forPolisovatel[character]);
                    character++;
                }
                sw.Close();
                Console.WriteLine("Выведенны все элементы после элемента где содержится /");
            }

        }
    }
}
