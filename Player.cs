using System;
using System.Collections.Generic;

namespace DeckOfCards
{

    public class Player
    {

        public string Name;
        

        List<Card> hand = new List<Card>();

        public Player(string n)
        {
            Name = n;
        }
        public Card Draw(Deck deck)
        {
            Card newCard = deck.topMost();
            hand.Add(newCard);
            System.Console.WriteLine($"{Name} was dealt {newCard.stringVal} of {newCard.suit}");
            return newCard;
        }

        public Card Discard(int idx)
        {
            if (idx > hand.Count - 1 )
            {
                return null;
            }
            else
            {
                Card discardOne = hand[idx];
                hand.Remove(discardOne);
                System.Console.WriteLine($"Player discarded the {discardOne.stringVal} of {discardOne.suit}");
                return discardOne;
            }
            
        }




    }

}