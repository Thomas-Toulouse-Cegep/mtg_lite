using MTGO_lite.Models.Manas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Cards.Permanent
{
    internal class Creatures : Permanents
    {
        public Creatures(string name, string type, Mana manaCost, Bitmap picture) : base(name, type, manaCost, picture)
        {
        }

        public static Card CreatureFactory(string Type)
        {
            Card CardType = null;

            switch (Type)
            {
                case "alpha_myr":
                    Mana manaAlphaMyr = new Mana(0, 0, 0, 0, 0, 2);
                    CardType = new Creatures("alpha_myr", "Creatures", manaAlphaMyr, Resource.alpha_myr);
                    break;
                case "barony_vampire":
                    Mana manaBaronyVampire = new Mana(1, 0, 0, 0, 0, 2);
                    CardType = new Creatures("barony_vampire", "Creatures", manaBaronyVampire, Resource.barony_vampire);
                    break;
                case "fusion_elemental":
                    Mana manaFusionElemental = new Mana(1, 1, 1, 1, 1, 0);
                    CardType = new Creatures("fusion_elemental", "Creatures", manaFusionElemental, Resource.fusion_elemental);
                    break;
            }

            return CardType;
        }
    }
}