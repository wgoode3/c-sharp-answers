using System;

namespace cards
{
    class Card
    {
        private String suit;
        private String value;
        public Card(String suit, String value)
        {
            this.suit = suit;
            this.value = value;
        }
        public String GetSuit()
        {
            return this.suit;
        }
        public void SetSuit(String suit)
        {
            this.suit = suit;
        }
        public String GetValue()
        {
            return this.value;
        }
        public void SetValue(String value)
        {
            this.value = value;
        }
        public void ShowCard()
        {
            Console.WriteLine($"The {this.value} of {this.suit}");
        }

    }
}
