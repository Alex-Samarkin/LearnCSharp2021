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
            // Загадываем случайное число от 0 до 100
            var r = new Random();
            int I = r.Next(0, 101);

            Console.WriteLine(@"Игра 'Угадай число'
я загадаю число от 0 до 100, вы попробуете угадать. 
Я отвечу только больше ваше число моего или меньше.
");
            int i = 0;
            do
            {
                string s = Console.ReadLine();
                i = Int32.Parse(s??"0");

                if (i<I)
                {
                    Console.WriteLine("Меньше");
                }
                if (i > I)
                {
                    Console.WriteLine("Больше");
                }

            } while (I!=i);

            Console.WriteLine("Угадали!!!");
            Console.ReadLine();

        }
    }
}
