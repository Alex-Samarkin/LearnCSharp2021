using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Игра 'Угадай число'
я загадаю число от 0 до 100, вы попробуете угадать. 
Я отвечу только больше ваше число моего или меньше.
");

            Console.WriteLine("Ваше число?");

            Console.ReadLine();

        }
    }
}
