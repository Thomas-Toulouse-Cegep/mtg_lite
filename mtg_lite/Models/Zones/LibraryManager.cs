using mtg_lite.Models.Cards;
using mtg_lite.Models.Cards.Permanent;

namespace mtg_lite.Models.Zones
{
    public static class LibraryManager
    {
        private static Dictionary<string, List<Card>> libraries = new Dictionary<string, List<Card>>();

        static LibraryManager()
        {
            libraries.Add("librairieCard", CreateList());
        }

        public static List<Card> GetCards(string libraryName)
        {
            if (libraries.ContainsKey("librairieCard"))
            {
                return libraries["librairieCard"];
            }
            return new List<Card>();
        }

        /// <summary>
        /// start deck creations
        /// </summary>
        /// <returns>return a list for the deck</returns>
        public static List<Card> CreateList()
        {
            List<Card> list = new List<Card>();

            list.Add(Sorcery.SorceryFactory("blightning"));
            list.Add(Sorcery.SorceryFactory("chain_lightning"));
            list.Add(Sorcery.SorceryFactory("clone_legion"));

            list.Add(Creatures.CreatureFactory("alpha_myr"));
            list.Add(Creatures.CreatureFactory("barony_vampire"));
            list.Add(Creatures.CreatureFactory("fusion_elemental"));

            list.Add(Land.LandFactory("forest"));
            list.Add(Land.LandFactory("island"));
            list.Add(Land.LandFactory("mountain"));
            list.Add(Land.LandFactory("swamp"));
            list.Add(Land.LandFactory("plains"));

            return list;
        }
    }
}