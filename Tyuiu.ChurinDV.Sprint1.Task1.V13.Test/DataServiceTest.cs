using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChurinDV.Sprint1.Task1.V13.Lib;

namespace Tyuiu.ChurinDV.Sprint1.Task1.V13.Test
{
    [TestClass]
    public class DataServiceTest
    //Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат по формуле x/(0.5*x) и печатает его на экране.
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2, res);
        }
    }
}
