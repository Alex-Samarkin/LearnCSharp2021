using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// сводка базовых конструкций и концепций C#
/// </summary>
namespace AllInOne
{
    class Program
    {

        static void Main(string[] args)
        {
            #region Console in and out

            /// press cw and Tab Tab
            ///
            Console.WriteLine("Hello world! Проивет, мир"); // вывод
            Console.ReadLine(); // ждем нажатия клавиши Enter
            
            /// вывод строки какк отдельной переменной
            /// 
            string hello = "Hello, username!"; // строка
            // output and waiting for Enter key
            Console.WriteLine(hello);
            Console.ReadLine();

            /// вывод целого числа и десятичной дроби
            /// по отдельности
            /// 
            // output and waiting for Enter key
            int i = 10;
            double x = 10 / 3;
            Console.WriteLine(i);
            Console.WriteLine(x);
            Console.ReadLine();

            /// через строку форматирования
            /// строка содержит места заполнения вида {число}
            /// за строкой через запятую - аргументы для вывода
            /// нумеруются с 0
            /// {0} заменяется значением i
            /// {1} заменяется значением x
            /// 
            // output and waiting for Enter key
            Console.WriteLine("i = {0} x = {1}",i,x);
            Console.ReadLine();

            /// через интерполированную строку форматирования
            /// строка начинается со знака $
            /// строка содержит места заполнения вида {имя переменной} или {выражение}
            /// {i} заменяется на значение i
            /// {x} заменяется на значение x
            /// {x*x} заменяется на значение x*x, то есть квадрат x
            /// 
            // output and waiting for Enter key
            Console.WriteLine($"i = {i} x = {x} x^2 = {x*x}");
            Console.ReadLine();

            /// с форматированием (часть 1)
            /// можно через запятую указать, какое количество позиций будет занимать вывод
            /// и его выравнивание
            /// в примере для i отводится 20 позиций, но выравнивание будет отличаться
            /// i = |                  10|
            /// i = | 10                 |
            // output and waiting for Enter key
            Console.WriteLine($"i = |{i,20}|");
            Console.WriteLine($"i = |{i,-20}|");
            Console.ReadLine();

            /// с форматированием (часть 2)
            /// можно задать формат вывода с помощью специальной строки
            /// через двоеточие
            /// 
            // output and waiting for Enter key
            Console.WriteLine($"i = |{i:D5}|"); // пять знаков, decimal
            Console.WriteLine($"i = |{i:C}|");  // валюта, currency
            Console.WriteLine($"x = |{x:F3}|"); // три знака после запятой, fixed 
            Console.WriteLine($"x^2 = |{x*x:G}|");  // общий формат, general
            Console.WriteLine($"x^2 = |{x*x:N6}|");  // числовой формат, Number
            Console.ReadLine();

            /// с форматированием (часть 3)
            /// можно комбинировать формат вывода через запятую-двоеточие
            /// 
            // output and waiting for Enter key
            Console.WriteLine($"i = |{i,20:D5}|"); // пять знаков, decimal
            Console.WriteLine($"i = |{i,-20:C}|");  // валюта, currency
            Console.WriteLine($"x = |{x,20:F3}|"); // три знака после запятой, fixed 
            Console.WriteLine($"x^2 = |{x * x,15:G}|");  // общий формат, general
            Console.WriteLine($"x^2 = |{x * x,-15:N6}|");  // числовой формат, Number
            Console.ReadLine();


            #endregion
        }
    }
}
