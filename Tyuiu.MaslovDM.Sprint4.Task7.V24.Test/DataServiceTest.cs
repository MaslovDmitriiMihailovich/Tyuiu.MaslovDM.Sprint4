using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MaslovDM.Sprint4.Task7.V24.Lib;

namespace Tyuiu.MaslovDM.Sprint4.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int res = ds.Calculate(5, 3, "651827384219648");
            int wait = 1179648;

            Assert.AreEqual(wait, res);
        }
    }
}