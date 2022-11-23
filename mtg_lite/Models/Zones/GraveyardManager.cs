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
    public static class GraveyardManager
    {
        private static Dictionary<string, List<Card>> graveyards = new Dictionary<string, List<Card>>();

        static GraveyardManager()
        {
        }

        public static List<Card> GetCards(string handsName)
        {
            if (graveyards.ContainsKey("librairieCard"))
            {
                return graveyards["librairieCard"];
            }
            return new List<Card>();
        }
    }
}