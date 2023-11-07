using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VelizhaninPI.Sprint4.Task6.V20.Lib;

namespace Tyuiu.VelizhaninPI.Sprint4.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {

            DataService ds = new DataService();

            string[] names = { "Математика", "Физика", "Химия", "Биология", "География", "История", "Литература" };
            string[] res = ds.Calculate(names);
            string[] wait = { "Физика", "Химия", "Биология", "География", "История" };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
