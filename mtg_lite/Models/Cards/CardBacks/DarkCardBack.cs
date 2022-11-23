using MTGO_lite.Models.Manas;

namespace mtg_lite.Models.Cards.CardBacks
{
    public class DarkCardBack : Card
    {
        public DarkCardBack() : base("Dark Card Back", "Card Back", new Mana(), Resource.card_back_dark)
        {
        }
    }
}