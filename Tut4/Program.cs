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
            /// TODO
            /// выберите другие цвета для вывода

            // генератор случайных чисел
            var r = new Random();
            // r.Next - методы генерации разных случайных чисел

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;

            // цикл - повторяется 100 раз
            // i - счетчик цикла, каждую итерацию увеличивается на 1
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"|{i,-10}||{r.Next(),20}|");
            }

            Console.ReadLine();

            // восстанавливает цвета консоли
            Console.ResetColor();

            //Console.BackgroundColor = ConsoleColor.Cyan;
            //Console.ForegroundColor = ConsoleColor.DarkBlue;


            // цикл повторяется, пока не сгенерируется число, равное 50
            int value = 0;
            do
            {
                value = r.Next(0, 101);
                /// TODO
                /// сделайте вывод таким, чтобы он занимал 20 позиций
                Console.WriteLine($"{value}");
            } while (value!=50);

            Console.ReadLine();

            // испраьте цикл так, чтобы он останавливался, если выпадет число, больше 50
            value = 0;

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Magenta;

            while (value<=50)
            {
                value = r.Next(0, 101);
                /// TODO
                /// сделайте вывод таким, чтобы он занимал 20 позиций
                Console.WriteLine($"{value}");
            }

            Console.ReadLine();

            /// Попробуйте предположить, сколько в среднем раз повторится цикл с генерацией случайных чисел,
            /// при условии, что должно выпасть ровно 50
            /// что будет, если мы будем ждать число 18? 93?
            ///
            /// Сколько раз повторится последний цикл (остановка, если число больше 50)
            /// что будет, если мы будем ждать число 18? 93?
            ///
            /// Раскомментируйте строки Console.BackgroundColor и ForegroundColor
        }
    }
}
