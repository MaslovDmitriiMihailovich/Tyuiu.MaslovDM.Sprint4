using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MaslovDM.Sprint4.Task5.V10.Lib;

namespace Tyuiu.MaslovDM.Sprint4.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5]
            {
                { -4, 1, 2, -1, 3 },
                { 5, -2, 7, 0, -3 },
                { 4, 6, -4, 1, 2 },
                { -1, 3, 5, -2, 7 },
                { 0, -3, 6, 4, -1 }
            };

            int res = ds.Calculate(matrix);
            int wait = 56;

            Assert.AreEqual(wait, res);
        }
    }
}