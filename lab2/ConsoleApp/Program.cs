using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Завдання:
            використання методів і властивостей:
            Read, ReadLine, ReadKey, Write(), Clear, Title
            */

            Console.OutputEncoding = System.Text.Encoding.UTF8;
           
            Console.Title = "Робота з консоллю";
            Console.Write("Привіт!"); // метод Write() - виведення в один рядок
           
            Console.WriteLine(""); // пустий рядок
            string str1 = "Це коротка інструкція "; // метод WriteLine() - курсор консолі переводиться на наступний рядок
            string str2 = "до програми: ";
            Console.WriteLine(str1 + str2 + System.Environment.NewLine);
            Console.WriteLine("<<Квадрат цілого числа>>" + System.Environment.NewLine); // додаємо пустий рядок в кінці
            Console.WriteLine("Натисни будь-яку клавішу і перейди до програми");

            Console.ReadKey(); // приймає й повертає символ
            Console.Clear(); // видалення інформації з буферу консолі і її вікна

            string str3 = "Введи ціле число: ";
            Console.WriteLine(str3);
            
            string x = Console.ReadLine(); // Вводимо рядок символів 

            int a = Int32.Parse(x); // Перетворимо його до цілого типу int 
              
            Console.WriteLine("");
            Console.WriteLine("Твоє число: " + a);
            a = a * a;
            Console.WriteLine("Квадрат числа дорівнює: " + a);
          
            Console.ReadKey(); 
          
        }
    }
}
