using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChurinDV.Sprint1.Task5.V1.Lib;

namespace Tyuiu.ChurinDV.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x1 = 10;
            double y1 = 10;
            double x2 = 20;
            double y2 = 20;
            DataService ds = new DataService();
            double res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            int result = Convert.ToInt32(res);
            int wait = 14;
            Assert.AreEqual(wait, result);

        }
    }
}
