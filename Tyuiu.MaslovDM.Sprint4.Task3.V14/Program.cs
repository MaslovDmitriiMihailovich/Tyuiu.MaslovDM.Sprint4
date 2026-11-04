using System;
using Tyuiu.MaslovDM.Sprint4.Task3.V14.Lib;

namespace Tyuiu.MaslovDM.Sprint4.Task3.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5]
            {
                { 3, 2, 3, 3, 5 },
                { 2, 3, 3, 7, 3 },
                { 7, 5, 2, 7, 3 },
                { 4, 2, 7, 5, 2 },
                { 3, 5, 4, 2, 6 }
            };

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Массив 5 на 5, найти максимальный элемент в четвёртой строке:          *");
            Console.WriteLine("**************************************************************************");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Максимальный элемент четвёртой строки = " + ds.Calculate(array));

            Console.WriteLine("**************************************************************************");

            Console.ReadKey();
        }
    }
}