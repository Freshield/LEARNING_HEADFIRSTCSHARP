using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chp8_Test8
{
    class Deck
    {
        List<Card> cards;
        Random random = new Random();

        public Deck()
        {
            cards = new List<Card>();
            for (int kind = 1; kind < 5; kind++)
            {
                for (int number = 1; number < 14; number++)
                {
                    cards.Add(new Card(number, (Kind)kind));
                }
            }
        }

        public Deck(IEnumerable<Card> initialCards)
        {
            cards = new List<Card>(initialCards);
        }

        public int Count { get { return cards.Count; } }

        public void Add(Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }

        public Card Deal(int index)
        {
            Card CardToDeal = cards[index];
            cards.RemoveAt(index);
            return CardToDeal;
        }

        public void Shuffle()
        {
            List<Card> NewCards = new List<Card>();
            while (cards.Count > 0)
            {
                int CardToMove = random.Next(cards.Count);
                NewCards.Add(cards[CardToMove]);
                cards.RemoveAt(CardToMove);
            }
            cards = NewCards;
        }

        public IEnumerable<string> GetCardNames()
        {
            string[] CardNames = new string[cards.Count];
            for (int i = 0; i < cards.Count; i++)
            {
                CardNames[i] = cards[i].Name;
            }
            return CardNames;
        }

        public void Sort()
        {
            cards.Sort(new CardComparerByValue());
        }



    }
}
