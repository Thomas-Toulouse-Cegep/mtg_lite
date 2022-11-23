using mtg_lite.Models.Cards;
using mtg_lite.Models.Cards.Permanent;
using MTGO_lite.Models.Manas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Zones
{
    public static class HandManager
    {
        private static Dictionary<string, List<Card>> hands = new Dictionary<string, List<Card>>();

        static HandManager()
        {
        }

        public static List<Card> GetCards(string handsName)
        {
            if (hands.ContainsKey("librairieCard"))
            {
                return hands["librairieCard"];
            }
            return new List<Card>();
        }
    }
}