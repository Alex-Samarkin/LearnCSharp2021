using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut6
{
    public class Deck
    {
        public List<Card> Items = new List<Card>();
        Random r = new Random();

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
                    Card c = new Card() { Color = (Card.CardColor)i, Name = j };
                    Console.Write(c + " ");
                    Items.Add(c);
                }

                Console.WriteLine();
            }

            Position = 0;
        }

        public void Shuffle()
        {
            // тасуем колоду
            for (int i = 0; i < Items.Count; i++)
            {
                // выбираем карты 1,2,3 ... i
                // генерируем новую случайную позицию карты в колоде
                var pos = r.Next(0, Items.Count);
                // меняем карты (используется деконструкция вместо более привычного
                // tmp = a, a = b, b = tmp)
                (Items[pos], Items[i]) = (Items[i], Items[pos]);
            }

            Position = 0;
        }

        public void Reset()
        {
            Create();
        }

        #region Overrides of Object

        public override string ToString()
        {
            var s = "Cards is:\n";

            foreach (var card in Items)
            {
                s += card.ToString();
            }

            return s;
        }

        #endregion

        public int Position { get; set; } = 0;

        public Card RandomCard()
        {
            Position += 1;
            return Items[Position-1];
        }

    }
}
