using MTGO_lite.Models.Manas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Cards
{
    internal class Sorcery : Card
    {
        private bool isPermanent1 = false;

        public Sorcery(string name, string type, Mana manaCost, Bitmap picture) : base(name, type, manaCost, picture)
        {
        }

        public bool IsPermanent1 { get => isPermanent1; }

        public static Card SorceryFactory(string Type)
        {
            Card CardType = null;

            if (Type.ToLower().Equals("blightning"))
            {
                Mana manaBlightning = new Mana(1, 0, 0, 1, 1, 1);
                CardType = new Sorcery("blightning", "Sorcery", manaBlightning, Resource.blightning);
            }
            else if (Type.ToLower().Equals("chain_lightning"))
            {
                Mana manaChainLightning = new Mana(0, 0, 0, 1, 0, 0);
                CardType = new Sorcery("chain_lightning", "Sorcery", manaChainLightning, Resource.chain_lightning);
            }
            else if (Type.ToLower().Equals("clone_legion"))
            {
                Mana manaCloneLegion = new Mana(0, 2, 0, 0, 0, 7);
                CardType = new Sorcery("clone_legion", "Sorcery", manaCloneLegion, Resource.clone_legion);
            }
            return CardType;
        }
    }
}