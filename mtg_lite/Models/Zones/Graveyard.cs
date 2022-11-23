using mtg_lite.Models.Cards;
using mtg_lite.Models.Players;

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
            return;
        }

        public override string ToString()
        {
            return $"{"Graveyard"} ({cards.Count})";
        }
    }
}