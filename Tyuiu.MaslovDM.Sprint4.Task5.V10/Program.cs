using System;
using Tyuiu.MaslovDM.Sprint4.Task5.V10.Lib;

namespace Tyuiu.MaslovDM.Sprint4.Task5.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5];
            Random rnd = new Random();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Массив 5 на 5 из случайных чисел в диапазоне от -4 до 7                *");
            Console.WriteLine("**************************************************************************");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(-4, 8);
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Сумма положительных элементов = " + ds.Calculate(matrix));

            Console.WriteLine("**************************************************************************");

            Console.ReadKey();
        }
    }
}