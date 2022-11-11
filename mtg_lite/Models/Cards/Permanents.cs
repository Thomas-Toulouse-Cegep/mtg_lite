using mtg_lite.Models.Cards.Permanent;
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
        private bool isPermanent1 = true;

        public Permanents(string name, Mana manaCost, Bitmap picture) : base(name, manaCost, picture)
        {

        }

        public bool IsPermanent1 { get => isPermanent1; }
    }
}
