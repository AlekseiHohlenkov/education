using System;
using System.Collections.Generic;
using System.Text;

namespace HW_BlackJack_v._01
{
    public class Card
    {


        private int suit;
        private int rank;
        public const int DIAMONDS = 4;
        public const int HEARTS = 3;
        public const int SPADES = 6;
        public const int CLUBS = 5;

        public const int TWO = 2;
        public const int THREE = 3;
        public const int FOUR = 4;
        public const int FIVE = 5;
        public const int SIX = 6;
        public const int SEVEN = 7;
        public const int EIGHT = 8;
        public const int NINE = 9;
        public const int TEN = 10;
        public const int JACK = 10;
        public const int QUEEN = 10;
        public const int KING = 10;
        public const int ACE = 11;

        public Card(int suit, int rank)
        {
            this.suit = suit;
            this.rank = rank;
        }

        public int Suit
        {
            get
            {
                return suit;
            }
        }

        public int Rank
        {
            get
            {
                return rank;
            }
        }

        public string Display()
        {

            string display;
            if (rank > 10)
            {
                display = Convert.ToString((char)rank);
            }
            else
            {
                display = Convert.ToString(rank);
            }

            switch (suit)
            {
                case DIAMONDS:
                    return display + Convert.ToString((char)DIAMONDS);
                case HEARTS:
                    return display + Convert.ToString((char)HEARTS);
                case SPADES:
                    return display + Convert.ToString((char)SPADES);
                default:
                    return display + Convert.ToString((char)CLUBS);

            }
        }
    }   
}
