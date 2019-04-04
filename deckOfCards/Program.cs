using System;
using System.Collections.Generic;

namespace deckOfCards
{
    class Card
    {
        public string stringVal{get;set;}
        public string suit{get;set;}
        public int val{get;set;}

    }

    class Deck
    {
        public List<Card> Cards = new List<Card>();
        public Deck()
        {
            string[] suits = {"Clubs","Spades","Hearts","Diamonds"};
            Dictionary<string,int> vals = new Dictionary<string,int>();
            vals.Add("Ace",1);
            vals.Add("2",2);
            vals.Add("3",3);
            vals.Add("4", 4);
            vals.Add("5", 5);
            vals.Add("6", 6);
            vals.Add("7", 7);
            vals.Add("8", 8);
            vals.Add("9", 9);
            vals.Add("10", 10);
            vals.Add("Jack", 11);
            vals.Add("Queen", 12);
            vals.Add("King", 13);
            
            foreach(string suit in suits)
            {
                foreach(var val in vals)
                {
                    Card addCard = new Card();
                    addCard.suit = suit;
                    addCard.stringVal = val.Key;
                    addCard.val = val.Value;
                    Cards.Add(addCard);
                }
            }
        }

        public Card Deal()
        {
            int top = Cards.Count -1;
            Card dealCard = Cards[top];
            Cards.RemoveAt(top);
            return dealCard;
        }

        public void Reset()
        {
            string[] suits = { "Clubs", "Spades", "Hearts", "Diamonds" };
            Dictionary<string, int> vals = new Dictionary<string, int>();
            vals.Add("Ace", 1);
            vals.Add("2", 2);
            vals.Add("3", 3);
            vals.Add("4", 4);
            vals.Add("5", 5);
            vals.Add("6", 6);
            vals.Add("7", 7);
            vals.Add("8", 8);
            vals.Add("9", 9);
            vals.Add("10", 10);
            vals.Add("Jack", 11);
            vals.Add("Queen", 12);
            vals.Add("King", 13);
            Card addCard = new Card();
            foreach (string suit in suits)
            {
                foreach (var val in vals)
                {
                    addCard.suit = suit;
                    addCard.stringVal = val.Key;
                    addCard.val = val.Value;
                    Cards.Add(addCard);
                }
            }
        }

        public void Shuffle()
        {
            int count = Cards.Count;
            Random rand = new Random();
            Card tempCard = new Card();
            for( int idx = 0; idx<count;idx++)
            {
                int rand_index = rand.Next(0,count-1);
                tempCard = Cards[idx];
                Cards[idx] = Cards[rand_index];
                Cards[rand_index] = tempCard;
            }
        }

    }

    class Player
    {
        public string name;
        List<Card> hand;

        public Player(string playerName)
        {
            name = playerName;
            hand = new List<Card>();
        }

        public Card Draw(Deck useDeck)
        {   
            Card drawedCard = useDeck.Deal();
            hand.Add(drawedCard);
            return drawedCard;
        }

        public Card Discard( int index)
        {
            Card disCard;
            if(index > hand.Count-1)
            {return null;}
            else
            {
                disCard = hand[index];
                hand.RemoveAt(index);
                return disCard;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Deck thisDeck = new Deck();
            thisDeck.Shuffle();
            Player bob = new Player("Bob");
            Card getCard = bob.Draw(thisDeck);
            Console.WriteLine("now the player "+ bob.name + " get a card "+ getCard.suit+" "+getCard.stringVal);


        }
    }
}
