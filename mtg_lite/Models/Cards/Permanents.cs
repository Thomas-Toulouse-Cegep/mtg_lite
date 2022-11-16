using mtg_lite.Models.Cards.Permanent;
using MTGO_lite.Models.Manas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Cards
{
    public class Permanents : Card
    {
        public override bool IsPermanent => true;

        public Permanents(string name, Mana manaCost, Bitmap picture) : base(name, manaCost, picture)
        {
            
        }
    }
}