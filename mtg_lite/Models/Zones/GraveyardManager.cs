using mtg_lite.Models.Cards;

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