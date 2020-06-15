using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {

        static void Main(string[] args)

        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "Робота з масивами";


            /*int[] A = new int[5];
            for (int i = 0; i < 5; i++)
            {
                A[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < 5; i++)
            {
                //  Console.WriteLine($"Елемент масиву [{i}]: {A[i]}");
                Console.WriteLine(String.Join("; ", A));
            }
            */

            //Сума і кількість від`ємних елементів
            Console.WriteLine("Сума і кількість від`ємних елементів: " + System.Environment.NewLine);
            const int n12 = 10;
            int k;
            int[] Arr = new int[n12] { 1, -4, -7, 8, -10, 12, -14, -17, 20, 21 };
            Console.WriteLine("Массив Аrr: ");
            for (k = 0; k <= n12 - 1; k++)
                Console.Write(" " + Arr[k]);
            Console.WriteLine();
            long sum12 = 0; // сумма від`ємних елементів
            long num = 0; // количество отрицательных элементов
            for (k = 0; k <= n12 - 1; k++)
                if (Arr[k] < 0)
                {
                    sum12 = sum12 + Arr[k];
                    num = num + 1;
                }
            Console.WriteLine("Сума від`ємних елементів = " + sum12);
            Console.WriteLine("Кількість від`ємних елементів = " + num + System.Environment.NewLine);

            //сума елементів двумірного масиву
            Console.WriteLine("Сума елементів двумірного масиву: " + System.Environment.NewLine);
            const int n = 5;
            int[,] A = new int[n, n];
            Random rnd = new Random();
            int sum = 0;
            for (int i = 0; i <= (n - 1); i++)
            {
                for (int j = 0; j <= (n - 1); j++)
                {
                    A[i, j] = rnd.Next(1, 10);
                    sum = sum + A[i, j];
                    Console.Write("A[{0},{1}] = {2} ", i, j, A[i, j]);
                }
                Console.WriteLine();
            }
          
            Console.WriteLine("Сума елементів масиву А= " + sum);
           

            Console.ReadKey();

        }
    }
}