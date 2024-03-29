﻿using MTGO_lite.Models.Manas;

namespace mtg_lite.Models.Cards.Permanent
{
    internal class Land : Permanents
    {
        public Land(string name, string type, Mana manaCost, Bitmap picture) : base(name, type, manaCost, picture)
        {
        }

        /// <summary>
        /// generate card Land
        /// </summary>
        /// <param name="Type">the type of card</param>
        /// <returns>return the card type</returns>
        public static Card LandFactory(string Type)
        {
            Card CardType = null;

            switch (Type)
            {
                case "forest":
                    Mana manaForest = new Mana(0, 0, 1, 0, 0, 0);
                    CardType = new Land("forest", "Land", manaForest, Resource.forest);
                    break;

                case "island":
                    Mana manaIsland = new Mana(0, 1, 0, 0, 0, 0);
                    CardType = new Land("island", "Land", manaIsland, Resource.island);
                    break;

                case "mountain":
                    Mana manaMountain = new Mana(0, 0, 0, 1, 0, 0);
                    CardType = new Land("mountain", "Land", manaMountain, Resource.mountain);
                    break;

                case "swamp":
                    Mana manaSwamp = new Mana(1, 0, 0, 0, 0, 0);
                    CardType = new Land("swamp", "Land", manaSwamp, Resource.swamp);
                    break;

                case "plains":
                    Mana manaPlains = new Mana(0, 0, 0, 0, 1, 0);
                    CardType = new Land("plains", "Land", manaPlains, Resource.plains);
                    break;
            }

            return CardType;
        }
    }
}