using System;
using Tyuiu.MaslovDM.Sprint4.Task6.V9.Lib;

namespace Tyuiu.MaslovDM.Sprint4.Task6.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string[] array = { "Красный", "Оранжевый", "Желтый", "Зеленый", "Синий", "Индиго", "Фиолетовый" };

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Массив: " + string.Join(", ", array));
            Console.WriteLine("* Подсчитать элементы, длина которых меньше 7                            *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Количество элементов = " + ds.Calculate(array));

            Console.WriteLine("**************************************************************************");

            Console.ReadKey();
        }
    }
}