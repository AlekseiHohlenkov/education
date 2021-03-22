using System;

namespace HW_BlackJack_v._01
{
    class Program
    {
       public static void Main(string[] args)
        {
            Deck deck = new Deck();
            Computer computer = new Computer(deck);
            computer.shuffle();
            Console.WriteLine(deck);
        }
    }
}
