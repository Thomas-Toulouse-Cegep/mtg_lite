﻿using MTGO_lite.Models.Manas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Cards.Permanent
{
    internal class Creatures : Card
    {
        public Creatures(string name, Mana manaCost, Bitmap picture) : base(name, manaCost, picture)
        {
        }

        public static Card CreatureFactory(string Type)
        {
            Card CardType = null;

            if (Type.ToLower().Equals("alpha_myr"))
            {
                Mana manaAlphaMyr = new Mana(0, 0, 0, 0, 0, 2);
                CardType = new Creatures("alpha_myr", manaAlphaMyr, Resource.alpha_myr);
            }
            else if (Type.ToLower().Equals("barony_vampire"))
            {
                Mana manaBaronyVampire = new Mana(1, 0, 0, 0, 0, 2);
                CardType = new Creatures("barony_vampire", manaBaronyVampire, Resource.barony_vampire);
            }
            else if (Type.ToLower().Equals("fusion_elemental"))
            {
                Mana manaFusionElemental = new Mana(1, 1, 1, 1, 1, 0);
                CardType = new Creatures("fusion_elemental", manaFusionElemental, Resource.fusion_elemental);
            }
            return CardType;
        }
    }
}