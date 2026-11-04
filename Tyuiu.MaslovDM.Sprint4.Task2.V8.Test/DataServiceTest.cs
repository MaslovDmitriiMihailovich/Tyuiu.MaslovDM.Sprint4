using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MaslovDM.Sprint4.Task2.V8.Lib;

namespace Tyuiu.MaslovDM.Sprint4.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 2, 3, 4, 5, 6, 7, 2, 3, 4, 5, 7 };

            int res = ds.Calculate(array);
            int wait = 30;

            Assert.AreEqual(wait, res);
        }
    }
}