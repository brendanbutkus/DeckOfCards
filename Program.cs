using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck a = new Deck();
            Player brendan = new Player("brendan");
            brendan.Draw(a);
            // why wont it show the player name in the terminal
            brendan.Discard(0);
            // what argument is needed for Discard function above?
            // Console.WriteLine("Hello World!");

            
        }
    }
}
