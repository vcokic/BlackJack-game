using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OTTER
{
    public class Deck
    {
        private List<Card> shuffledCards;
        public List<Card> ShuffledCards
        {
            get { return shuffledCards; }
            set { shuffledCards = value; }
        }

        public Deck()
        {
            Shuffle();
        }

        private void Shuffle()
        {
            Random generator = new Random(DateTime.Now.Millisecond);
            List<Card> deckInOrder = GetDeckInOrder();
            this.ShuffledCards = new List<Card>();

            for (int i = 1; i < 53; i++)
            {
                int cardIndex = generator.Next(0, deckInOrder.Count);
                Card randomCard = deckInOrder[cardIndex];

                this.ShuffledCards.Add(randomCard);
                deckInOrder.Remove(randomCard);
            }
        }

        private List<Card> GetDeckInOrder()
        {
            List<Card> deckInOrder = new List<Card>();

            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    string path = "..//..//sprites//" + (Suit)i + (Face)j + ".png";
                    Card cardToAdd = new Card((Suit)i, (Face)j, path, 85, 223);
                    deckInOrder.Add(cardToAdd);
                }
            }

            return deckInOrder;
        }

        public List<Card> DealHand()
        {
            List<Card> hand = new List<Card>();

            for (int i = 0; i < 2; i++)
            {
                hand.Add(ShuffledCards[0]);
                ShuffledCards.RemoveAt(0);
            }

            return hand;
        }

        public Card DrawCard()
        {
            Card next = ShuffledCards[0];
            ShuffledCards.RemoveAt(0);

            return next;
        }
    }
}
