﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Card
    {
        // масти
        public enum CardColor
        {
            Hearts = 0,
            Diamonds,
            Clubs,
            Spades
        }
        // достоинство карты - соотвествует ее имени
        public int Name = 0;
        // масть карты
        public CardColor Color = 0;
        // вышла из игры или нет
        public bool isOut = false;

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

        public bool IsQueenOfSpades()
        {
            if ((Name == 12)&&(Color==CardColor.Spades))
            {
                return true;
            }

            return false;
        }
    }

    class Cards
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
                    Card c = new Card() { Color = (Card.CardColor)i, Name = j, isOut = false };
                    Console.Write(c + " ");
                    Items.Add(c);
                }

                Console.WriteLine();
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

            Card card = new Card();

            Console.WriteLine(card);

            // колода
            Cards cards = new Cards();
            // создаем карты
            cards.Create();

            Console.WriteLine(cards.RandomCard());
            Console.WriteLine(cards);
            Console.WriteLine(cards.RandomCard());
            Console.WriteLine(cards);
            Console.WriteLine(cards.RandomCard());
            Console.WriteLine(cards);
            Console.WriteLine(cards.RandomCard());
            Console.WriteLine(cards);
            Console.WriteLine(cards.RandomCard());
            Console.WriteLine(cards);

            Console.ReadLine();
        }
    }
}