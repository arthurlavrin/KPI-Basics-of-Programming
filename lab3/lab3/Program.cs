using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "Перетворення і приведення типів";
           
            // ЗАВДАННЯ А

            Console.WriteLine("»  Завдання А: " + System.Environment.NewLine + "Неявне перетворення float -> double" + System.Environment.NewLine);
            float num1 = 0.0001f; // f - символ форматування для виводу чисел з фіксованою точністю
            Console.WriteLine("Значення змінної типу float: " + num1);
            double num2 = num1;
            Console.WriteLine("Значення змінної типу double: " + num2 + System.Environment.NewLine);
            
            //ЗАВДАННЯ Б

            Console.WriteLine("»  Завдання Б: " + System.Environment.NewLine + "Явне перетворення char -> sbyte" + System.Environment.NewLine);
            char c1 = "cat"[2]; // приміняючи [2] до рядка, звертаємося до нього як до масиву символів і обираємо 3-й
            Console.WriteLine("Значення змінної типу char: " + c1);
            sbyte s1 = Convert.ToSByte(c1);
            Console.WriteLine("Значення змінної типу sbyte: " + s1 + System.Environment.NewLine);
            
            /*
            Console.WriteLine("Завдання Б: " + System.Environment.NewLine + "Явне перетворення char -> sbyte" + System.Environment.NewLine);
            char c2 = 'a'; // Змінні типу char можуть отримувати значення одного символу, взятого в одинарні лапки
            Console.WriteLine("Значення змінної типу char: " + c2); //Дані типу char представляють символьне значення коду, введеного з клавіатури. Код символу представляє собою ціле число.
            sbyte s2 = Convert.ToSByte(c2);
            Console.WriteLine("Значення змінної типу sbyte: " + s2 + System.Environment.NewLine);
            */

            //ЗАВДАННЯ В

            Console.WriteLine("»  Завдання В: " + System.Environment.NewLine + "Методи класу Convert: " + System.Environment.NewLine +
                "ToBoolean(Int32), ToByte(Int32), ToDateTime(String), ToDouble(Boolean), ToInt16(Byte)" + 
                System.Environment.NewLine);
            Console.WriteLine("Метод ToBoolean(Int32): ");
            int num3 = -25548612; 
            Console.WriteLine("Значення змінної типу int: " + num3);
            bool b1 = Convert.ToBoolean(num3); // повертає true, якщо значення num3 не дорівнює нулю, в протилежному випадку — false
            Console.WriteLine("Значення змінної типу bool: " + b1 + System.Environment.NewLine);

            Console.WriteLine("Метод ToByte(Int32): ");
            int num4 = 245;
            Console.WriteLine("Значення змінної типу int: " + num4);
            byte b2 = Convert.ToByte(num4); // byte може приймати значення від 0 до 255 включно
            Console.WriteLine("Значення змінної типу byte: " + b2 + System.Environment.NewLine);

            Console.WriteLine("Метод ToDateTime(String): ");
            string str1 = "22 January 2020 17:32:47"; // рядкове представлення дати і часу
            Console.WriteLine("Значення змінної типу str: " + str1);
            Console.WriteLine("Що є еквівалентне: " + Convert.ToDateTime(str1) + System.Environment.NewLine); // повертає дату і час, що еквівалентні значенню str1

            Console.WriteLine("Метод ToDouble(Boolean): ");
            bool b3 = true;
            Console.WriteLine("Значення змінної типу bool: " + b3);
            double num5 = Convert.ToDouble(b3); // при значенні false повертає нуль
            Console.WriteLine("Значення змінної типу double: " + num5 + System.Environment.NewLine);

            Console.WriteLine("Метод ToInt16(Byte): ");
            byte b4 = 64; //приймає значення від 0 до 255 включно
            Console.WriteLine("Значення змінної типу byte: " + b4);
            int num6 = Convert.ToInt16(b4); 
            Console.WriteLine("Значення змінної типу int: " + num6 + System.Environment.NewLine);

            // ЗАВДАННЯ Г
            Console.WriteLine("»  Завдання Г: " + System.Environment.NewLine + "Методи класу String: " + System.Environment.NewLine +
                "String.CopyTo(), String.IndexOfAny(Char[], Int32), String.PadLeft(Int32, Char), String.Split(String, StringSplitOptions)" +
                System.Environment.NewLine);

            Console.WriteLine("Метод String.CopyTo(): ");
            // Embed an array of characters in a string
            string strSource = "changed";
            char[] destination = { 'T', 'h', 'e', ' ', 'i', 'n', 'i', 't', 'i', 'a', 'l', ' ',
                'a', 'r', 'r', 'a', 'y' };

            // Print the char array
            Console.WriteLine(destination);
            // Embed the source string in the destination string
            strSource.CopyTo(0, destination, 4, strSource.Length);
            // Print the resulting array
            Console.WriteLine(destination);
     

            // Пошук з масиву символів
            Console.WriteLine(System.Environment.NewLine + "Метод String.IndexOfAny(Char[], Int32): "); 
            string s2 = "Це текст";
            char[] myCh = { 'Ы', 'х', 'т' };
            if (s2.IndexOfAny(myCh) != -1) // -1, если не найден ни один знак из anyOf
                Console.WriteLine("Один із символів з масиву myCh " +
                    "знайдено на позиції {0}", s2.IndexOfAny(myCh) + System.Environment.NewLine);
            
            Console.WriteLine("Метод String.PadLeft(Int32, Char): ");
            string str = "forty-two";
            char pad = '.';

            Console.WriteLine(str.PadLeft(15, pad));
            Console.WriteLine(str.PadLeft(2, pad) + System.Environment.NewLine);

            Console.WriteLine("Метод String.Split(String, StringSplitOptions): ");
            string[] separators = { ",", ".", "!", "?", ";", ":", " " };
            string value = "My; !dog, is: very? pretty";
            string[] words = value.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words)
            Console.WriteLine(word + System.Environment.NewLine);

            Console.WriteLine("Метод String.TrimEnd(): ");

            // Trim with Characters
            char[] trimChars = { '*', '@', ' ' };
            string str4 = "@@**  Suresh Dasari  **@";

            Console.WriteLine("Before Trim: {0}", str4);
            Console.WriteLine("After Trim: {0}", str4.TrimEnd(trimChars));

            Console.ReadLine();
        }
    }
}
