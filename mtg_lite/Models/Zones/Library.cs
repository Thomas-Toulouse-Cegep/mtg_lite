using mtg_lite.Models.Cards;
using mtg_lite.Models.Cards.CardBacks;
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

        /// <summary>
        ///
        /// </summary>
        /// <param name="cards"> the list of card (the Deck)</param>
        /// <param name="player">the player of this deck</param>
        public Library(List<Card> cards, Player player) : base(cards, player)
        {
            cards = cards.ToList();

            Shuffle();
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns>shuffle the card arround and it will return a random card at the top</returns>
        public List<Card> Shuffle()
        {
            cards = cards.OrderBy(a => rng.Next()).ToList();
            return cards;
        }

        /// <summary>
        /// let user not see top card
        /// </summary>
        public override Card TopCard
        {
            get
            {
                if (cards.Count == 0)
                {
                    return new DarkCardBack();
                }
                return new CardBack();
            }
        }

        public override string ToString()
        {
            return $"{"Library"} ({cards.Count})";
        }

        public override void Cardclick(Card card)
        {
            if (cards.Count == 0)
            {
                return;
            }
            RemoveCard(cards.Last());
        }
    }
}