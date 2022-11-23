using mtg_lite.Models.Cards;

namespace mtg_lite.Models.Zones
{
    public static class BattlefieldManager
    {
        private static Dictionary<string, List<Card>> battlefields = new Dictionary<string, List<Card>>();

        static BattlefieldManager()
        {
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="handsName">the name of the hand work like the library</param>
        /// <returns></returns>
        public static List<Card> GetCards(string handsName)
        {
            if (battlefields.ContainsKey("librairieCard"))
            {
                return battlefields["librairieCard"];
            }
            return new List<Card>();
        }
    }
}