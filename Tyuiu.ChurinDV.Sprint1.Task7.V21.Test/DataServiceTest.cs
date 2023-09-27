using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChurinDV.Sprint1.Task7.V21.Lib;

namespace Tyuiu.ChurinDV.Sprint1.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3.14;
            double y = 3.14;
            double wait = -17.096;
            var res = Math.Round(ds.Calculate(x, y), 3);
            Assert.AreEqual(wait, res);
        }
    }
}
