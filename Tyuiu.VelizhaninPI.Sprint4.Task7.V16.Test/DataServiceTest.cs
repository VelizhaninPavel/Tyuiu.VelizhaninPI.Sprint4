using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VelizhaninPI.Sprint4.Task7.V16.Lib;

namespace Tyuiu.VelizhaninPI.Sprint4.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            
            string str = "382976421897948";
            int rows = 5;
            int columns = 3;
            int wait = 196608;
            int res = ds.Calculate(rows, columns, str);
            Assert.AreEqual(wait, res);
        }
    }
}
