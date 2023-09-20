using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

//Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат по формуле x/(0.5*x) и печатает его на экране.
namespace Tyuiu.ChurinDV.Sprint1.Task1.V13.Lib
{
    public class DataService : ISprint1Task1V13
    {
        public double Calculate(double x, double y)
        {
            return x / (0.5 * x);
        }
    }
}
