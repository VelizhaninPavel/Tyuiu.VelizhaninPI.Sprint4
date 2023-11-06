using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VelizhaninPI.Sprint4.Task5.V10.Lib;

namespace Tyuiu.VelizhaninPI.Sprint4.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = { {-4, 5, 5, 6, 4, },
                             { 7, -5, 4, 0, -5 },
                             { 5, 0, -5, 2, 5 },
                             { -2, 5, 0, 1, -3 },
                             { 4, 7, 7, 4, -3,} };

            int wait = 71;
            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}
