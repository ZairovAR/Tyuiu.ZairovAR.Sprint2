using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZairovAR.Sprint2.Task1.V4.Lib;


namespace Tyuiu.ZairovAR.Sprint2.Task1.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Заиров А. Р. | ACOиУБ 23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *"); 
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Заиров Артур Ранисович | AСОиУБ 23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, послед- *");
            Console.WriteLine("* овательность можно чередовать, но использовать один раз в выражении) и  *");
            Console.WriteLine("* логических операций (|, &, ||, &&, !, ^, последовательность операций не *");
            Console.WriteLine("* должна нарушаться), а также арифметических выражений, которая вернет    *");
            Console.WriteLine("* логическую  последовательность(массив): (False, False, False, False,    *");
            Console.WriteLine("* True, False), при a = 175, b = 176, c = 414, d = 414                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");



            int a = 175;
            int b = 176;
            int c = 414;
            int d = 414;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadLine();
        }
    }
}
