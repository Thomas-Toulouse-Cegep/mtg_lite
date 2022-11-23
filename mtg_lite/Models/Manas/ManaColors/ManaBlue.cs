using mtg_lite;

namespace MTGO_lite.Models.Manas.ManaColors
{
    public class ManaBlue : ManaColor
    {
        public static string Name = "Blue";

        public override string ColorName => Name;
        public override Bitmap Icon => Resource.blue_mana;

        public ManaBlue(int quantity) : base(quantity)
        {
        }
    }
}