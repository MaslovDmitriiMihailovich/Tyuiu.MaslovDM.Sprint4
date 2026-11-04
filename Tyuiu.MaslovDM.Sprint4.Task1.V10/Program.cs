using System;
using Tyuiu.MaslovDM.Sprint4.Task1.V10.Lib;

namespace Tyuiu.MaslovDM.Sprint4.Task1.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[] array = new int[11];

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Введите 11 целых чисел от 1 до 8 (каждое с новой строки):              *");
            Console.WriteLine("**************************************************************************");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Элемент " + (i + 1) + ": ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Произведение нечётных элементов = " + ds.Calculate(array));

            Console.WriteLine("**************************************************************************");

            Console.ReadKey();
        }
    }
}