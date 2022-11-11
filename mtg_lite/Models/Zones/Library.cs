using mtg_lite.Models.Cards;
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
        //private static List<Card> shuffledcards; //= cards.OrderBy(a => rng.Next());

        public Library(List<Card> cards, Player player) : base(cards, player)
        {
            cards = cards.ToList();
            //this.RemoveCard(cards.First());
            if (cards[0].Tapped)
            {
            }
            Shuffle();
        }

        public List<Card> Shuffle()
        {
            cards = cards.OrderBy(a => rng.Next()).ToList();
            return cards;
        }

        public override void i()
        {
            RemoveCard(cards.Last());

            //this.RemoveCard(cards.First());
        }

        public override string ToString()
        {
            return $"{"Library"} ({cards.Count})";
        }
    }
}