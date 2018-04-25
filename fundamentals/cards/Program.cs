using System;

namespace cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck decky = new Deck();
            // always gives back Ace of Clubs
            decky.Deal().ShowCard();
            // should give back a randomized card
            decky.Shuffle().Deal().ShowCard();
            decky.Initialize();
            decky.Shuffle();
            Player akagi = new Player("Akagi");
            akagi.DrawCards(3, decky);
            akagi.ShowHand();
            akagi.Discard(2);
            akagi.DrawCards(1, decky);
            akagi.ShowHand();
        }
    }
}
