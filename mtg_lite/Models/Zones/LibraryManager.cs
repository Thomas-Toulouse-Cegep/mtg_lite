using mtg_lite.Models.Cards;
using MTGO_lite.Models.Manas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Zones
{
    public static class LibraryManager
    {
        private static Dictionary<string, List<Card>> libraries = new Dictionary<string, List<Card>>();

        static LibraryManager()
        {
            //Players.Player player =
            //Zone zone = new Zone(GetCards,)
        }

        public static List<Card> GetCards(string libraryName)
        {
            if (libraries.ContainsKey(libraryName))
            {
                return libraries[libraryName];
            }
            return new List<Card>();
        }

        private static Random rng = new Random();

        public static void Shuffle()
        {
            int cardsInLibraries = libraries.Count;
            foreach (Card card in GetCards("s"))
            {
                rng.Next(cardsInLibraries);
            }
        }
    }
}