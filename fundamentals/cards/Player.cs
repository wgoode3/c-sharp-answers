using System;
using System.Collections.Generic;

namespace cards
{
    class Player
    {
        private String name;
        private List<Card> hand = new List<Card>();
        public Player(String name)
        {
            this.name = name;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public String getName()
        {
            return this.name;
        }
        public void DrawCards(int num, Deck deck)
        {
            for (int i = 0; i < num; i++)
            {
                this.hand.Add(deck.Deal());
            }
        }
        public Card Discard(int index)
        {
            if (index > this.hand.Count)
            {
                return null;
            }
            else
            {
                Card card = this.hand[index];
                this.hand.Remove(card);
                return card;
            }
        }
        public void ShowHand()
        {
            Console.WriteLine($"{this.name}'s hand is:");
            for (int i = 0; i < this.hand.Count; i++)
            {
                this.hand[i].ShowCard();
            }
        }
    }
}
