using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Ввести с клавиатуры предложение.
Предложение представляет собой слова, разделенные пробелом.
Знаки препинания не используются.
Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»).");
            Console.WriteLine("");
            Console.Write("Введите предложение: ");
                        
            string str = Console.ReadLine().ToLower().Replace(" ", "");
                        
            char[] CharArray = str.ToCharArray();
           
            Array.Reverse(CharArray);
            
            string strReverse = new string(CharArray);

            if (str == strReverse)
            {
                Console.WriteLine("Введенное предложение является палиндромом");
            }
            else
            {
                Console.WriteLine("Введенное предложение НЕ является палиндромом");
            }
            
            Console.ReadKey();
        }
    }
}
