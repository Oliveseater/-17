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

            List<string> search = new List<string>();
            List<string> searchNumbers = new List<string>(); // for A

            for (int i = 0; i < forPolisovatel.Length; i++)
            {
                forPolisovatel[i] = Console.ReadLine(); //заполнение массива
                search.Add(forPolisovatel[i]); // добавления каждого элемента массива в коллекцию

                
                foreach (char c in forPolisovatel[i]) // for A
                {
                    searchNumbers.Add(c.ToString()); //получение обсолютно каждого символа, для поиска цифр
                }
            }
            // for A
            {
                string[] numbers = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" }; //массив цифр
                var selectedNumbers = 0;
                for (int n = 0; n < numbers.Length; n++)
                {
                    selectedNumbers += searchNumbers.Where(u => u == numbers[n]).Count(); // поиск цифр
                }
                Console.WriteLine("Кол-во цифр в массиве - " + selectedNumbers);
            }
            Console.WriteLine();
            //for B
            {
                for (int j = 0; j < search.ToArray().Length; j++)
                {
                    if (search[j].Contains("/"))
                        break;
                    else Console.WriteLine(search[j]);
                }
                Console.WriteLine("Выведенны все элементы до элемента где содержится /");
            }
            Console.WriteLine();
            //for C
            {
                StreamWriter sw = File.CreateText("newArray.txt");
                int character = 0;
                for (int j = 0; j < search.ToArray().Length; j++)
                {
                    if (search[j].Contains("/"))
                        character = j;
                }
                for (int z = character; z < search.ToArray().Length; z++)
                {
                    search[character] = string.Concat(search[character].Select(c => (char)(char.ToLower(c) ^ char.ToUpper(c) ^ c)));
                    Console.WriteLine(search[character]);
                    sw.WriteLine(search[character]);
                    character++;
                }
                sw.Close();
                Console.WriteLine("Выведенны все элементы после элемента где содержится /");
            }

        }
    }
}
