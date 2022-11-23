using MTGO_lite.Models.Manas;

namespace mtg_lite.Models.Cards
{
    public class Permanents : Card
    {
        public Permanents(string name, string type, Mana manaCost, Bitmap picture) : base(name, type, manaCost, picture)
        {
        }

        public override bool IsPermanent => true;
    }
}