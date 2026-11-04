using System;
using Tyuiu.MaslovDM.Sprint4.Task2.V8.Lib;

namespace Tyuiu.MaslovDM.Sprint4.Task2.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[] array = new int[11];
            Random rnd = new Random();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Массив из 11 случайных чисел в диапазоне от 2 до 7                     *");
            Console.WriteLine("**************************************************************************");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(2, 8);
            }

            Console.WriteLine("Массив: " + string.Join(", ", array));

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Сумма нечётных элементов = " + ds.Calculate(array));

            Console.WriteLine("**************************************************************************");

            Console.ReadKey();
        }
    }
}