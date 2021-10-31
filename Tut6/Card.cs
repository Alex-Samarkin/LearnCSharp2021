using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut6
{
    public class Card
    {
        // масти
        public enum CardColor
        {
            Hearts = 0,
            Diamonds,
            Clubs,
            Spades
        }

        private char[] _chars = new[]
        {
            // нажать Alt 3-6 на Num Pad
            '♥',
            '♦',
            '♣',
            '♠'
        };

        // достоинство карты - соотвествует ее имени
        public int Name = 0;

        // масть карты
        public CardColor Color = 0;

        // вышла из игры или нет
        //public bool isOut = false;

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

        public string ToCString()
        {
            //Console.OutputEncoding = Encoding.UTF8;
            string s = "";
            Console.ResetColor();
            switch (Color)
            {
                case CardColor.Hearts:
                    Console.ForegroundColor = ConsoleColor.Red;
                    s += _chars[0];
                    break;
                case CardColor.Diamonds: 
                    Console.ForegroundColor = ConsoleColor.Red;
                    s += _chars[1]; 
                    break;
                case CardColor.Clubs:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    s += _chars[2]; 
                    break;
                case CardColor.Spades:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    s += _chars[3]; 
                    break;
            }

            s += " " + ToString();
            Console.WriteLine(s);
            Console.ResetColor();
            return s;
        }

        public bool IsQueenOfSpades()
        {
            if ((Name == 12) && (Color == CardColor.Spades))
            {
                return true;
            }

            return false;
        }
    }

 
}
