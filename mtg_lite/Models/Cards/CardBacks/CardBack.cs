using MTGO_lite.Models.Manas;

namespace mtg_lite.Models.Cards.CardBacks
{
    public class CardBack : Card
    {
        public CardBack() : base("Card Back", "Card Back", new Mana(), Resource.card_back)
        {
        }
    }
}