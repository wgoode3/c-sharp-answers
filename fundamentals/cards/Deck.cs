using System;

namespace cards
{
    class Deck
    {
        private Card[] deck = new Card[52];
        public Deck()
        {
            Initialize();
        }
        public void Initialize()
        {
            deck = new Card[52];
            String[] suits = { "Spades", "Hearts", "Diamonds", "Clubs" };
            String[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    deck[13 * i + j] = new Card(suits[i], values[j]);
                }
            }
        }
        public Card Deal()
        {
            Card card = this.deck[this.deck.Length - 1];
            Array.Resize(ref this.deck, this.deck.Length - 1);
            return card;
        }
        public Deck Shuffle()
        {
            Random rng = new Random();
            int n = this.deck.Length;
            while (n > 1)
            {
                int k = rng.Next(n--);
                Card temp = this.deck[n];
                this.deck[n] = this.deck[k];
                this.deck[k] = temp;
            }
            return this;
        }
    }
}
