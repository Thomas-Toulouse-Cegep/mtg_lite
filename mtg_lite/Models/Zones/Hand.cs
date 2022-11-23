using mtg_lite.Models.Cards;
using mtg_lite.Models.Players;
using MTGO_lite.Models.Manas;

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
            if (card.Type == "Land")
            {
                RemoveCard(card);
            }
            else
            {
                try
                {
                    if (player.ManaPool.payable(card.ManaCost))
                    {
                        RemoveCard(card);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        public override string ToString()
        {
            return $"{"Hand"} ({cards.Count})";
        }
    }
}