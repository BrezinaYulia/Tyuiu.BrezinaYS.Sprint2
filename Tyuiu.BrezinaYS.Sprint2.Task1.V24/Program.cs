using System;
using System.Net.Http.Headers;
using Tyuiu.BrezinaYS.Sprint2.Task1.V24.Lib;
namespace Tyuiu.BrezinaYS.Sprint2.Task1.V24
// Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать, но использовать один раз
// в выражении) и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться)
// , а также арифметических выражений, которая вернет логическую последовательность(массив):
// (True, False, True, False, True, False), при a = 325, b = 325, c = 242, d = 324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            int a = 325;
            int b = 325;
            int c = 242;
            int d = 324;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            Console.Title = "Спринт #2 | Выполнил: Брезина Ю. С. | ИИПб-24-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #24                                                              *");
            Console.WriteLine("* Выполнил: Брезина Юлия Сергеевна | ИИПб-24-2                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и логических операций, а также *");
            Console.WriteLine("* арифметических выражений, которая вернет логическую последовательность: *");
            Console.WriteLine("*(True, False, True, False, True, False),a = 325, b = 325,c = 242,d = 324 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("C = " + c);
            Console.WriteLine("D = " + d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("***************************************************************************");
            
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();


        }
    }
}
