using System;
using System.IO;
using System.Text;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите полный путь к файлу");
            string pathRead = Console.ReadLine();
            string fromFile = "";
            try
            {
                fromFile = File.ReadAllText(pathRead);
            }
            catch (Exception)
            {
                Console.WriteLine("Такого файла не существует");
                return;
            }
            GetEmails(ref fromFile);
            Console.WriteLine("Введите полный путь для файла результата");
            string pathWrite = Console.ReadLine();
            try
            {
                File.WriteAllText(pathWrite, fromFile);
                Console.WriteLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Не удаётся записать файл");
                return;
            }
        }

        public static void GetEmails(ref string s) //Разбивает весь текст на массив из слов. Ищет слова содержащие @. Компанует из них новую строку.
        {
            string[] words = s.Split(" ");
            s = "";
            foreach (var item in words)
            {
                if (item.Contains('@'))
                {
                    s += (item + Environment.NewLine);
                }
            }
        }
        public static string Reverse(string input)
        {
            StringBuilder reverseString = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverseString.Append(input[i]);
            }
            return reverseString.ToString();
        }
    }
}
