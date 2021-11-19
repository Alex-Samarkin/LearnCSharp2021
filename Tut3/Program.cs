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
                // относительно новый оператор ??
                // если в строке s ничего нет, то он заменит ее на строку "0"
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

            /// TODO
            /// измените диапазон чисел для угадывания, например на 0-50
            /// факультативно:
            /// проверьте, что пользователь ввел число в диапазоне угадывания
            /// факультативно:
            /// задайте диапазон через константы from и to
            /// используйте вместо "зашитых" в программу чисел эти константы
        }
    }
}
