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
        private static Dictionary<string, List<Card>> libraries = new Dictionary<string, List<Card>>();

        public Hand(List<Card> cards, Player player) : base(cards, player)
        {
            cards = cards.ToList();
            // player.Hand.AddCard(cards);
            /*CardAdded?.Invoke(this, card);
            CardsChanged?.Invoke(this, cards); */
        }

        public override void Cardclick(Card card)
        {
            if (cards.Count == 0)
            {
                return;
            }
            RemoveCard(card);
        }

        public override string ToString()
        {
            return $"{"Hand"} ({cards.Count})";
        }
    }
}