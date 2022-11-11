using mtg_lite.Models.Cards;
using mtg_lite.Models.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Zones
{
    internal class Hand : Zone
    {
        public Hand(List<Card> cards, Player player) : base(cards, player)
        {
            // player.Hand.AddCard(cards);
            /*CardAdded?.Invoke(this, card);
            CardsChanged?.Invoke(this, cards); */
        }

        public List<Card> AddCard()
        {
            return cards;
        }

        public override string ToString()
        {
            return $"{"Hand"} ({cards.Count})";
        }
    }
}