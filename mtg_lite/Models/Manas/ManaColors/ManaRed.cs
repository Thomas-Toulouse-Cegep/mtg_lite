using mtg_lite;

namespace MTGO_lite.Models.Manas.ManaColors
{
    public class ManaRed : ManaColor
    {
        public static string Name = "Red";

        public override string ColorName => Name;
        public override Bitmap Icon => Resource.red_mana;

        public ManaRed(int quantity) : base(quantity)
        {
        }
    }
}