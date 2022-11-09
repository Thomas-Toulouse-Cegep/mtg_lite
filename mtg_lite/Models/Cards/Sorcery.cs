using mtg_lite.Models.Cards.Sorcerys;
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
        public Sorcery(string name, Mana manaCost, Bitmap picture) : base(name, manaCost, picture)
        {
        }

        public static Card SorceryFactory(string Type)
        {
            Card CardType = null;

            if (Type.ToLower().Equals("blightning"))
            {
                CardType = new Blightning("blightning", );
            }
            else if (Type.ToLower().Equals("chain_lightning"))
            {
                CardType = new ChainLightning("chain_lightning");
            }
            else if (Type.ToLower().Equals("clone_legion"))
            {
                CardType = new CloneLegion("clone_legion");
            }
            return CardType;
        }
    }
}
