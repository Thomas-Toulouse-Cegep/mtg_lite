using mtg_lite;

namespace MTGO_lite.Models.Manas.ManaColors
{
    public class ManaWhite : ManaColor
    {
        public static string Name = "White";

        public override string ColorName => Name;
        public override Bitmap Icon => Resource.white_mana;

        public ManaWhite(int quantity) : base(quantity)
        {
        }
    }
}