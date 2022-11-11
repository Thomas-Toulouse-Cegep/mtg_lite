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
        private static Random rng = new Random();
        private List<Card> shuffledcards; //= cards.OrderBy(a => rng.Next());

        public Library(List<Card> cards, Player player) : base(cards, player)
        {
            cards = shuffledcards;
        }

        public void Shuffle()
        {
            shuffledcards.OrderBy(a => rng.Next());
        }
    }
}