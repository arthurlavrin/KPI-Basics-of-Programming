
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Lab6
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            try
            {
                CreateArrayFile();

                CreateMatrixFile();

                Lab6Action();
                


            }
            catch (Exception e)
            {
                Console.WriteLine("Приложение завершило работу с ошибкой: {0}", e.Message);
                throw e;
            }

        }


        static void Lab6Action()
        {
            Console.Clear();

            string filePath = @"C:\Temp\myArr.txt";
            Console.WriteLine("Массив з файлу: {0}", Path.GetFileName(filePath));
            int[] parsedArr = (int[])ReadArrFromFile(filePath);
            PrintArray(parsedArr);
            Console.ReadKey();


            int indexOfLastMin = Array.LastIndexOf(parsedArr, parsedArr.Min());
            Console.WriteLine("\nОстаннiй минимальний элемента {0}, має iндекс: [{1}]", parsedArr.Min(), indexOfLastMin);

            //замінемо місцями мін та останній єлемент
            Console.WriteLine("Змiнемо мiсцями останнiй мiнiмальний елемент з останнiм елементом массиву\n");
            int buffer = parsedArr[20];
            parsedArr[20] = parsedArr[indexOfLastMin];
            parsedArr[indexOfLastMin] = buffer;
            PrintArray(parsedArr);

            WriteToFile(parsedArr, @"C:\Temp\myArr.txt");


            int[] minElements = Array.FindAll(parsedArr, x => x == parsedArr.Min());

            if (minElements.Count() > 1)
            {
                Console.WriteLine("\nКiлькiсть мiнiмальних элементiв массиву: {0} ", minElements.Count());
                Console.WriteLine("Мiнiмальнi елементи мають iндекси:");
                int[] MinElemsIndexes = GetMinElemsIndex(parsedArr, parsedArr.Min());
                PrintArray(MinElemsIndexes);
                //зміенемо місцями елементи массиву.
                Console.WriteLine("\nЗмiнемо мiсцями останнє та перше мiнiмальне значення");

                buffer = parsedArr[MinElemsIndexes[0]];
                parsedArr[MinElemsIndexes[0]] = parsedArr[MinElemsIndexes[MinElemsIndexes.Count() - 1]];
                parsedArr[MinElemsIndexes[MinElemsIndexes.Count() - 1]] = buffer;
                PrintArray(parsedArr);
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine("\nМасив має тiльки одне мiнiмальне значення");
            }


            int[,] myMatrix = ReadMatrixFromFile(@"C:\Temp\myMatrix.txt");
            Console.WriteLine("\n Матриця з файлу myMatrix.txt ");
            PrintMatrix(myMatrix);


            Console.WriteLine("Cума найбiльших значень її рядкiв = {0}", CountMaxRowElemsSumm(myMatrix));

            Console.ReadKey();




        }
        static void CreateArrayFile()
        {
            

            Console.Clear();
            Console.WriteLine("Створюемо масив А довжиною М=20:");
            int[] randomArray = CreateArray(20);

            WriteToFile(randomArray, @"C:\Temp\myArr.txt");
           

        }
        static int[] CreateArray(int arrSize)
        {
            int[] myArray = new int[arrSize];
            Random rnd = new Random();
            for (int i = 0; i < arrSize; i++)
            {
                myArray[i] = rnd.Next(-5, 5);
            }
            return myArray;
        }

        static void PrintArray(Array arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");

            }
        }
        static int[] GetMinElemsIndex(int[] arr, int minVal)
        {
            List<int> indexList = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == minVal)
                {
                    indexList.Add(i);
                }
            }
            return indexList.ToArray();
        }
        static void CreateMatrixFile()
        {
            Console.WriteLine("Створюємо матрицю MxN=10x12: ");
            int[,] myMatrix = CreateMatrix(10, 12);

            WriteMatrixToFile(myMatrix, @"C:\Temp\myMatrix.txt");   




        }
        static int[,] CreateMatrix(int m, int n)

        {

            int[,] squareMatrix = new int[m, n];
            Random rnd = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    squareMatrix[i, j] = rnd.Next(-10, 10);
                }
            }
            return squareMatrix;
        }

        static void PrintMatrix(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine(" ");
            }
        }

        static int CountMaxRowElemsSumm(int[,] matrix)
        {
            int sum = 0;
            int maxVal = matrix[0, 0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (maxVal <= matrix[i, j])
                    {
                        maxVal = matrix[i, j];
                    }

                }
                sum += maxVal;
            }
            return sum;
        }



        static void WriteToFile(Array arr, string newFilePath)
        {
            StreamWriter sw = new StreamWriter(newFilePath, false);

            foreach (var item in arr)
            {
                sw.Write(item.ToString() + "\t");
            }
            sw.Close();
        }
        static void WriteMatrixToFile(int[,] arr, string newFilePath)
        {
            StreamWriter sw = new StreamWriter(newFilePath, false);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sw.Write(arr[i, j].ToString() + "\t");
                }
                sw.WriteLine("\n ");

            }
            sw.Close();
        }
        static Array ReadArrFromFile(string filePath)
        {


            StreamReader rd = new StreamReader(filePath);
            string infoFromFile = rd.ReadToEnd();
            string[] numsToParse = infoFromFile.Split(new char[] { '\t' });
            rd.Close();
            int[] myArr = new int[numsToParse.Length];
            int i = 0;
            foreach (string item in numsToParse)
            {
                if (item != string.Empty)
                {
                    myArr[i] = Convert.ToInt32(item);
                    i++;
                }

            }
            return myArr;
        }
        static int[,] ReadMatrixFromFile(string filePath)
        {
            StreamReader rd = new StreamReader(filePath);
            int i = 0, j = 0;
            int[,] result = new int[10, 12];
            string input = rd.ReadToEnd();
            char[] separator = { '\n', '\r' };
            foreach (var row in input.Split(separator))
            {

                // Console.WriteLine("строка {0} -:{1} ",i, row);
                // i++;

                if (row.Trim() != String.Empty)
                {
                    j = 0;
                    foreach (var col in row.Trim().Split('\t'))
                    {

                        result[i, j] = int.Parse(col.Trim());
                        j++;
                    }
                    i++;
                }


            }
            rd.Close();
            Console.ReadKey();
            return result;
        }
    }
}