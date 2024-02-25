using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OTTER
{
    public enum Suit
    {
        Clubs = 1,
        Diamonds = 2,
        Hearts = 3,
        Spades = 4
    }

    public enum Face
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }

    public class Card : Sprite
    {
        private Suit cardSuit;
        public Suit CardSuit
        {
            get { return cardSuit; }
            set { cardSuit = value; }
        }

        private Face cardFace;
        public Face CardFace
        {
            get { return cardFace; }
            set { cardFace = value; }
        }

        private int cardValue;
        public int CardValue
        {
            get { return cardValue; }
            set { cardValue = value; }
        }

        public Card(Suit s, Face f, string path, int xCor, int yCor) : base(path, xCor, yCor)
        {
            this.CardSuit = s;
            this.CardFace = f;
            if ((int)this.CardFace == 11 || (int)this.CardFace == 12 || (int)this.CardFace == 13)
            {
                this.CardValue = 10;
            }
            else if ((int)this.CardFace == 1)
            {
                this.CardValue = 11;
            }
            else
            {
                this.CardValue = (int)this.CardFace;
            }
        }

        public void ShowCard(int positionX, int positionY)
        {
            SetX(positionX);
            SetY(positionY);
            SetVisible(true);
        }
    }
}
