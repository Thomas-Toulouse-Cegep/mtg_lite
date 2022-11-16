using mtg_lite.Models.Cards.Permanent;
using MTGO_lite.Models.Manas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Cards
{
    public class Permanents : Card
    {
        private bool isPermanent = true;

        public Permanents(string name, Mana manaCost, Bitmap picture) : base(name, manaCost, picture)
        {
        }

        public virtual bool Is_Permanent { get => isPermanent; }
    }
}