﻿using mtg_lite.Models.Cards;
using mtg_lite.Models.Cards.Permanent;
using MTGO_lite.Models.Manas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Zones
{
    public static class HandManager
    {
        private static Dictionary<string, List<Card>> hands = new Dictionary<string, List<Card>>();

        static HandManager()
        {
            // hands.Add("librairieCard",hands.);
        }

        public static List<Card> GetCards(string handsName)
        {
            if (hands.ContainsKey("librairieCard"))
            {
                return hands["librairieCard"];
            }
            return new List<Card>();
        }

        /*public static List<Card> CreateList()
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
        }*/
    }
}