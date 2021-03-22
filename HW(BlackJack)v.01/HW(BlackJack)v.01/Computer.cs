using System;
using System.Collections.Generic;
using System.Text;

namespace HW_BlackJack_v._01
{
    public class Computer
    {
        private Deck deck;

        public Computer(Deck d)
        {
            deck = d;
        }
        public void shuffle()
        {
            int num_cards = deck.size();
            for (int i = 0; num_cards; i++)
            {
                int index = (int)(Random.Random.NextDouble() * num_cards);
                Card card_i = (Card)deck.get_Renamed(i);
                Card card_index = (Card)deck.get_Renamed(index);
                deck.replace(i, card_index);
                deck.replace(index, card_i);
            }
        }
        public Card dealCard()
        {
            if (deck.size() > 0)
            {
                return deck.removeFromFront();
            }
            return null;
        }   

        public class Random
        {
            static public System.Random Random = new System.Random();
        }
    } 
}
