using mtg_lite.Models.Cards;
using mtg_lite.Models.Players;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (card.Tapped)
            {
                card.Tapped = true;

                CardRotate(card);
            }
            else
            {
                card.Tapped = false;
            }
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