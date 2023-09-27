using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using Tyuiu.ChurinDV.Sprint1.Task6.V5.Lib;

namespace Tyuiu.ChurinDV.Sprint1.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "вася казак коля калаш гога шалаш";
            DataService ds = new DataService();
            string[] slova = strTest.Split(' ');
            string res = "";
            for (int i = 0; i < slova.Length; i++)
            {
                string word = slova[i];
                string rev = new string(word.Reverse().ToArray());
                if (word == rev)
                {
                    res += (word + " ");
                }
            }
            string wait = "казак шалаш";
            Assert.AreEqual(wait, res);
        }
    }
}
