using mtg_lite.Models.Cards;
using mtg_lite.Models.Cards.CardBacks;
using mtg_lite.Models.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Zones
{
    internal class Library : Zone
    {
        private Random rng = new Random();

        public Library(List<Card> cards, Player player) : base(cards, player)
        {
            cards = cards.ToList();
            foreach (Card card in cards)
            {
                if (card.Tapped == false)
                {
                    CardBack back = new CardBack();
                }
            }
            Shuffle();
        }

        public List<Card> Shuffle()
        {
            cards = cards.OrderBy(a => rng.Next()).ToList();
            return cards;
        }

        public override Card TopCard
        {
            get
            {
                if (cards.Count == 0)
                {
                    return new DarkCardBack();
                }
                return new CardBack();
            }
        }

        public override string ToString()
        {
            return $"{"Library"} ({cards.Count})";
        }

        public override void Cardclick(Card card)
        {
            if (cards.Count == 0)
            {
                return;
            }
            RemoveCard(cards.Last());
        }
    }
}