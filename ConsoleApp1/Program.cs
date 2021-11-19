using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// класс представляет отдельную карту
    /// </summary>
    class Card
    {
        /// <summary>
        /// внутри класса содержатся поля и методы
        /// внутри класса можно создавать вложенные типы данных
        /// </summary>
        
        // масти
        public enum CardColor
        {
            /// <summary>
            /// вложенный тип - перечисление
            /// он создает ряд констант, которые обозначаются в виде понятных строк
            /// в нашем случае - 4 масти соответствуют 4-м константам
            /// первая обычно эквивалаентна 0, следующие - 1, 2, ...
            /// </summary>
            Hearts = 0,
            Diamonds,
            Clubs,
            Spades
        }

        /// <summary>
        /// это поля
        /// можно считать, что поля это локальные переменные
        /// у каждого экземпляра класса свои поля
        /// поля это атрибуты, характеристики отдельных представителей класса (экземпляров, объектов)
        /// </summary>
        
        // достоинство карты - соотвествует ее имени
        public int Name = 0;
        // масть карты
        public CardColor Color = CardColor.Hearts;
        // вышла из игры или нет
        public bool isOut = false;

        /// <summary>
        /// это метод класса
        /// метод реализует поведение объекта
        /// методы класса - общие в том смысле, что поведение всех экземпляров класса одинаковое
        /// методы используют поля класса, поэтому разные объекты дадут разные результаты при вызове одного и того же метода
        ///
        /// этот метод преобразует объект в строку
        /// как именно - так, как вы хотите
        ///
        /// он ПЕРЕОПРЕДЕЛЯЕТ тот метод, который был у класса-родителя - override
        /// </summary>
        /// <returns>
        /// возвращает строку с именем и мастью карты
        /// $"{n} of {Color}"
        /// </returns>
        public override string ToString()
        {
            string n = "";
            switch (Name)
            {
                case 0: n = "Jocker"; break;
                case 1: n = "Ace"; break;

                case 11: n = "Jack"; break;
                case 12: n = "Queen"; break;
                case 13: n = "King"; break;
                
                default: n = Name.ToString(); break;
            }

            return $"{n} of {Color}";
        }

        /// <summary>
        /// проверка, что карта - королева пик
        /// </summary>
        /// <returns>true усли карта королева пик, false - в любом другом случае</returns>
        public bool IsQueenOfSpades()
        {
            if ((Name == 12)&&(Color==CardColor.Spades))
            {
                return true;
            }

            return false;
        }
    }

    /// <summary>
    /// класс представляющий колоду карт
    /// </summary>
    class Cards
    {
        /// <summary>
        /// список карт в колоде
        /// </summary>
        public List<Card> Items = new List<Card>();
        Random r = new Random();

        /// <summary>
        /// создание колоды 52 карты
        /// </summary>
        public void Create()
        {
            // создаем колоду
            // сначала перебираем масти

            Console.WriteLine("Start of creation");

            for (int i = 0; i < 4; i++)
            {
                // теперь перебираем номиналы карт
                for (int j = 1; j < 14; j++)
                {
                    Card c = new Card() { Color = (Card.CardColor)i, Name = j, isOut = false };
                    Console.Write(c + " ");
                    Items.Add(c);
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// сброс состояния колоды к начальному 
        /// </summary>
        public void Reset()
        {
            // возвращаем все карты в колоду
            foreach (Card card in Items)
            {
                card.isOut = false;
            }
        }

        #region Overrides of Object

        public override string ToString()
        {
            var s = "Cards is:\n";

            foreach (var card in Items)
            {
                s += card.ToString() + $" {card.isOut} ";
            }

            return s;
        }

        #endregion
        /// <summary>
        /// сдача случайной карты
        /// случайным образом выбирается карта, если она вышла из колоды, то выбирается
        /// еще одна, и т.д.
        /// выбранная карта отмечается как сыгранная
        /// </summary>
        /// <returns>карта случайной масти и номинала
        /// </returns>
        public Card RandomCard()
        {
            
            var Max = Items.Count;
            Card c;
            do
            {
                int i = r.Next(Max);
                c = Items[i];
                // для проверки
                Console.Write(c+" ");
            } while (c.isOut == true);

            Console.WriteLine();
            c.isOut = true;
            return c;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                @" Играем в карты
Из стандартной колоды (52 карты) наугад выбирается карта.
Карты сдаются поочередно - казино и вам.
Выигрывает тот, кому придет дама пик.
");
            Console.ReadLine();

   
            ///TEST создаем карту и выводим ее номинал на экран
            Card card = new Card();
            Console.WriteLine(card);
            Console.ReadLine();

            ///TEST создаем колоду карт
            // колода
            Cards cards = new Cards();
            // создаем карты
            cards.Create();
            Console.ReadLine();

            ///TEST Выдаем одну случайную карту
            Console.WriteLine(cards.RandomCard());
            Console.WriteLine(cards);
            Console.ReadLine();

            ///TEST Выдаем 50 карт
            for (int i = 0; i < 50; i++)
            {
                Console.Write($"{i,-6} ");
                Console.WriteLine(cards.RandomCard());
            }
            Console.WriteLine(cards);
            Console.ReadLine();

            ///TEST Выдаем карты, пока не выпадет дама пик
            cards.Reset();
            int j = 0;
            Card c;
            do
            {
                j++;
                c = cards.RandomCard();
                Console.WriteLine($"{j,-6} {c}");
            } while (c.IsQueenOfSpades()!=true);

            Console.WriteLine(cards);
            Console.ReadLine();

            cards.Reset();
            Console.Clear();
            Console.WriteLine(@"-----------------------------------
Играем в игру штосс.
Каждый ход сдается две карты - мне и вам.
Выигрывает тот, кому придет пиковая дама (Queen of Spades).
----------------------------------------------------------
Нажмите <Enter> для продолжения

");
            Console.ReadLine();
            for (int i = 0; i < cards.Items.Count; i++)
            {
                var c1 = cards.RandomCard();
                var c2 = cards.RandomCard();

                Console.WriteLine($"Ход {i+1}");
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
