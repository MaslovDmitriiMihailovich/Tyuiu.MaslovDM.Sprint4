using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MaslovDM.Sprint4.Task6.V9.Lib
{
    public class DataService : ISprint4Task6V9
    {
        public int Calculate(string[] array)
        {
            string[] result = Array.FindAll(array, s => s.Length < 7);

            return result.Length;
        }
    }
}