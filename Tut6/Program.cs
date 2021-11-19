using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut6
{
    class Program
    {
        static void Main(string[] args)
        {
            Card c = new Card();
            c.ToCString();
            Console.ReadLine();

            Deck d = new Deck();
            d.Create();
            d.Shuffle();

            Console.WriteLine(d.ToString());
            Console.ReadLine();
            Console.WriteLine(d.RandomCard());

            /// d.Shuffle();
            
            // улучшенный алгоритм перемешивания (на самом деле все равно плохой)
            // что плохого в алгоритме перемешивания?
            d.ShuffleN(15);

            Console.Clear();
            Console.WriteLine(@"___________________________________________________________
Играем в игру штосс.
Каждый ход сдается две карты - мне и вам.
Выигрывает тот, кому придет пиковая дама (Queen of Spades).
----------------------------------------------------------
Нажмите <Enter> для продолжения
___________________________________________________________
");
            Console.ReadLine();
            for (int i = 0; i < d.Items.Count; i++)
            {
                var c1 = d.RandomCard();
                var c2 = d.RandomCard();

                Console.WriteLine($"Ход {i + 1}");
                Console.WriteLine($"Моя карта {c1.ToString()}");
                Console.WriteLine($"Ваша карта {c2.ToString()}");

                if (c1.IsQueenOfSpades())
                {
                    Console.WriteLine("Вы проиграли!");
                    break;
                }

                if (c2.IsQueenOfSpades())
                {
                    Console.WriteLine("Вы выиграли!");
                    break;
                }

                Console.WriteLine("Нажмите <Enter> для следующей сдачи.");
                Console.ReadLine();
            }


            Console.ReadLine();
        }
    }
}
