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
            //player.Battlefield.CardRotate(card);
            //card.Tapped = true;
            card.Picture.RotateFlip(RotateFlipType.Rotate180FlipNone);
            card.ChangeTapped(!card.Tapped);

            // CardRotate(card); // rotate the card situated in Zone.cs
            // card.TappedChanged += Card_TappedChanged;
            // player.PlayCard(card); // do things with mana value
        }

        public static void Card_TappedChanged(object? card, bool cardTapped)
        {
            // card.Tapped = cardTapped;
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