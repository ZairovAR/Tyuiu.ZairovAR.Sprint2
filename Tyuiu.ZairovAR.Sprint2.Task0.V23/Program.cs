using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZairovAR.Sprint2.Task0.V23.Lib;
using Tyuiu.ZairovAR.Sprint2.Task0.V23.Lib;


namespace Tyuiu.ZairovAR.Sprint2.Task0.V23
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
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Заиров Артур Ранисович | AСОиУБ 23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, после-  *");
            Console.WriteLine("* довательность операций не должна нарушаться) и арифметических выражений,*");
            Console.WriteLine("* которая вернет логическую последовательность(массив): (True, False,     *");
            Console.WriteLine("* True, True, False, True),  при x = 105, y = 795                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            


            int x = 105;
            int y = 795;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i=0; i<6; i++) 
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadLine();
        }
    }
}
