using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZairovAR.Sprint2.Task7.V4.Lib;
namespace Tyuiu.ZairovAR.Sprint2.Task7.V4
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
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Заиров Артур Ранисович | AСОиУБ 23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные                  *");
            Console.WriteLine("* данные (вещественные значения) и вычисляет, находится ли точка с        *");
            Console.WriteLine("* координатами X,Y в заштрихованной области.                              *");
            Console.WriteLine("***************************************************************************");
        }
    }
}
