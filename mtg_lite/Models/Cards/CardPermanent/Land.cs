using MTGO_lite.Models.Manas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Cards.Permanent
{
    internal class Land : Card
    {
        public Land(string name, Mana manaCost, Bitmap picture) : base(name, manaCost, picture)
        {
        }

        public static Card LandFactory(string Type)
        {
            Card CardType = null;

            if (Type.ToLower().Equals("forest"))
            {
                Mana manaForest = new Mana(0, 0, 1, 0, 0, 0);
                CardType = new Land("forest", manaForest, Resource.forest);
            }
            else if (Type.ToLower().Equals("island"))
            {
                Mana manaIsland = new Mana(0, 1, 0, 0, 0, 0);
                CardType = new Land("island", manaIsland, Resource.island);
            }
            else if (Type.ToLower().Equals("mountain"))
            {
                Mana manaMountain = new Mana(0, 0, 0, 1, 0, 0);
                CardType = new Land("mountain", manaMountain, Resource.mountain);
            }
            else if (Type.ToLower().Equals("swamp"))
            {
                Mana manaSwamp = new Mana(1, 0, 0, 0, 0, 0);
                CardType = new Land("swamp", manaSwamp, Resource.swamp);
            }
            else if (Type.ToLower().Equals("plains"))
            {
                Mana manaPlains = new Mana(0, 0, 0, 0, 1, 0);
                CardType = new Land("plains", manaPlains, Resource.plains);
            }
            return CardType;
        }
    }
}
