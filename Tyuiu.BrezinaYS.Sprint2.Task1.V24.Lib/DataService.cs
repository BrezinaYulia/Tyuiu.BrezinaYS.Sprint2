using System;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BrezinaYS.Sprint2.Task1.V24.Lib
// Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать, но использовать один раз
// в выражении) и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться)
// , а также арифметических выражений, которая вернет логическую последовательность(массив):
// (True, False, True, False, True, False), при a = 325, b = 325, c = 242, d = 324
{
    public class DataService : ISprint2Task1V24
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a > c) | (d < b);
            res[1] = (a < d) & (b > c);
            res[2] = (a == b) || (d > c);
            res[3] = (a < c) && (d > b);
            res[4] = !res[1];
            res[5] = (a > c) ^ (d < b);
            return res;

        }
    }
}
