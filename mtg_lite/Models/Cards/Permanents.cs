using MTGO_lite.Models.Manas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Cards
{
    internal class Permanents : Card
    {
        public Permanents(string name, Mana manaCost, Bitmap picture) : base(name, manaCost, picture)
        {
        }

        /*public static Card FactoryPermanent()
        {
        }*/
    }
}