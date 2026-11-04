using System;
using Tyuiu.MaslovDM.Sprint4.Task7.V24.Lib;

namespace Tyuiu.MaslovDM.Sprint4.Task7.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string value = "651827384219648";
            int n = 5;
            int m = 3;

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Строка: " + value);
            Console.WriteLine("* Матрица " + n + " на " + m + ", произведение чётных чисел                          *");
            Console.WriteLine("**************************************************************************");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(value[i * m + j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Произведение = " + ds.Calculate(n, m, value));

            Console.WriteLine("**************************************************************************");

            Console.ReadKey();
        }
    }
}