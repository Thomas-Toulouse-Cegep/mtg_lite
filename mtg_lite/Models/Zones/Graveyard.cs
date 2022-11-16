using mtg_lite.Models.Cards;
using mtg_lite.Models.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Zones
{
    internal class Graveyard : Zone
    {
        public Graveyard(List<Card> cards, Player player) : base(cards, player)
        {
            cards = cards.ToList();
        }

        public override void Cardclick(Card card)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{"Graveyard"} ({cards.Count})";
        }
    }
}