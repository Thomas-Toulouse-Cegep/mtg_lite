using mtg_lite.Models.Cards;
using mtg_lite.Models.Players;

namespace mtg_lite.Models.Zones
{
    public class Battlefield : Zone
    {
        public Battlefield(List<Card> cards, Player player) : base(cards, player)
        {
            cards = cards.ToList();
        }

        public override void Cardclick(Card card)
        {
            if (!card.Tapped)
            {
                //card.Tapped = true;
                card.TappedChanged += Card_TappedChanged; ;
                player.PlayCard(card);
                CardRotate(card);
            }
            else
            {
                card.Tapped = false;
            }
        }

        private void Card_TappedChanged(object? sender, bool tapped)
        {
            tapped = true;
        }

        public override string ToString()
        {
            return $"{"Battlefield"} ({cards.Count})";
        }

        public List<Card> returnLand()
        {
            List<Card> lands = new List<Card>();
            foreach (Card card in cards)
            {
                if (card.Type == "Land")
                {
                    lands.Add(card);
                }
            }
            return lands;
        }

        public List<Card> returnCreatures()
        {
            List<Card> creatures = new List<Card>();
            foreach (Card card in cards)
            {
                if (card.Type == "Creatures")
                {
                    creatures.Add(card);
                }
            }
            return creatures;
        }
    }
}