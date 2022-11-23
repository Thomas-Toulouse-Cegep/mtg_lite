using mtg_lite.Models.Cards;

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