using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MaslovDM.Sprint4.Task1.V10.Lib
{
    public class DataService : ISprint4Task1V10
    {
        public int Calculate(int[] array)
        {
            int result = 1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    result *= array[i];
                }
            }

            return result;
        }
    }
}