using System;
using Tyuiu.MaslovDM.Sprint4.Task0.V30.Lib;

namespace Tyuiu.MaslovDM.Sprint4.Task0.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[] array = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Массив: 9, 8, 4, 6, 9, 4, 3, 6, 1, 2                                  *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Сумма чётных элементов = " + ds.GetSumEvenArrEl(array));

            Console.WriteLine("**************************************************************************");

            Console.ReadKey();
        }
    }
}