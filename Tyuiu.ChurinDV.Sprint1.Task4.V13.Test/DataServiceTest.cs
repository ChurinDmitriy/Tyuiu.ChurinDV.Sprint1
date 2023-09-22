using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChurinDV.Sprint1.Task4.V13.Lib;

namespace Tyuiu.ChurinDV.Sprint1.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 3;
            double wait = 0.000413125;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);


        }
    }
}
