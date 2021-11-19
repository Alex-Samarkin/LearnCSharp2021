using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Простой вывод
            Console.WriteLine("Hello, World, Привет мир!");

            //Ввод
            Console.ReadLine();

            //две переменные
            int x = 0;
            int y = 100;

            //вывод
            Console.WriteLine("x= {0} y= {1} x+y= {2}",x,y,x+y);
            Console.ReadLine();

            //вывод версия 2
            //объясните разницу между выводом первой и второй строки
            Console.WriteLine($"x= {x,0:g15} y= {y,-15} x+y= {x+y}");
            Console.WriteLine($"x= {x,0:g15} y= {y,15} x+y= {x + y}");
            Console.ReadLine();

            /// TODO
            /// Напечатайте свою фамилию
            /// Напечатайте сегодняшнюю дату
            /// Напечатайте дату, как результат вывода свойста (скобки не нужны)
            /// DateTime.Today
            /// DateTime.Now
            /// объясните разницу
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
