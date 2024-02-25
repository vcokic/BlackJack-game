using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OTTER
{
    public class Casino
    {
        public int GetHandValue(List<Card> hand)
        {
            int handValue = 0;

            foreach (Card c in hand)
            {
                if (c.CardFace == Face.Ace)
                {
                    if (handValue < 11)
                    {
                        handValue += c.CardValue;
                    }
                    else
                    {
                        handValue += 1;
                    }
                }
                else
                {
                    handValue += c.CardValue;
                }
            }

            return handValue;
        }

        public bool IsBlackJack(List<Card> hand)
        {
            if (hand.Count == 2)
            {
                if ((hand[0].CardFace == Face.Ace && hand[1].CardValue == 10) || (hand[1].CardFace == Face.Ace && hand[0].CardValue == 10))
                {
                    return true;
                }
            }

            return false;
        }
    }

    public class Player : Casino
    {
        private List<Card> hand;
        public List<Card> Hand
        {
            get { return hand; }
            set { hand = value; }
        }

        public Player()
        {
            this.Hand = new List<Card>();
        }
    }

    public class Dealer : Casino
    {
        private List<Card> hiddenCards;
        public List<Card> HiddenCards
        {
            get { return hiddenCards; }
            set { hiddenCards = value; }
        }

        private List<Card> revealedCards;
        public List<Card> RevealedCards
        {
            get { return revealedCards; }
            set { revealedCards = value; }
        }

        public Dealer()
        {
            this.HiddenCards = new List<Card>();
            this.RevealedCards = new List<Card>();
        }

        public void RevealCard()
        {
            RevealedCards.Add(HiddenCards[0]);
            HiddenCards.RemoveAt(0);
        }
    }
}
