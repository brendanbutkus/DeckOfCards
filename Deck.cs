using System;

using System.Collections.Generic;

namespace DeckOfCards
{
    public class Deck
    {

            public string[] suits = new string[] {"Heart", "Diamond", "Spade", "Club"};
            public string [] cardVals = new string[] {"Ace", "2", "3", "4","5","6","7","8","9","10","Jack","Queen","King"};
            List<Card> makeDeck = new List<Card>();


        public Deck()
        // anytime you use the name of the class, it is a constructor
        {
            
            for(int i = 0; i < cardVals.Length; i++)
            {
                for(int j =0; j < suits.Length; j++)
                {
                Card ourCard = new Card (cardVals[i], suits[j], i + 1);
                // we have to declare the type of variable, which is Card in this situation
                makeDeck.Add(ourCard);
                }

            }

            foreach(Card d in makeDeck)
            {
                System.Console.WriteLine($"{d.suit} {d.stringVal} {d.number}");

            }
        }

        public Card topMost()
        {
            Card topCard = makeDeck[0];
            makeDeck.RemoveAt(0);
            // System.Console.WriteLine($"Top card removed from deck, which is {d.suit} {d.stringVal}");
            return topCard;
            // putting in return gives us a way to keep track of the card dealt
        }

        public void reset()
        // if we return nothing we return void
        {
            makeDeck.Clear();
            for(int i = 0; i < cardVals.Length; i++)
            {
                for(int j =0; j < suits.Length; j++)
                {
                Card ourCard = new Card (cardVals[i], suits[j], i + 1);
                makeDeck.Add(ourCard);
                }

            }

            foreach(Card d in makeDeck)
            {
                System.Console.WriteLine(d);

            }
            System.Console.WriteLine("The deck has been reset.");
        }

        
        public void shuffle()
        {
                System.Console.WriteLine("-----Shuffling the deck----");
                Random rand = new Random();
                int idx = 0;
                while (idx < makeDeck.Count)
                {
                    Card temp = makeDeck[idx];
                    int newIdx = rand.Next(0,makeDeck.Count);
                    makeDeck[idx] = makeDeck[newIdx];
                    makeDeck[newIdx] = temp;
                    idx++;
                }
            System.Console.WriteLine("The deck has been reshuffled.");
        }


    }




}


        



