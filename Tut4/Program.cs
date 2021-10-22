using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut4
{
    class Program
    {
        static void Main(string[] args)
        {
            // генератор случайных чисел
            var r = new Random();
            // r.Next - методы генерации разных случайных чисел


            // цикл - повторяется 100 раз
            // i - счетчик цикла, каждую итерацию увеличивается на 1
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"{i,-10} {r.Next()}");
            }

            Console.ReadLine();

            // цикл повторяется, пока не сгенерируется число, равное 50
            int value = 0;
            do
            {
                value = r.Next(0, 101);
                Console.WriteLine($"{value}");
            } while (value!=50);

            Console.ReadLine();

            // испраьте цикл так, чтобы он останавливался, если выпадет число, больше 50

        }
    }
}
