using MTGO_lite.Models.Manas;

namespace mtg_lite.Models.Cards
{
    internal class Sorcery : Card
    {
        private bool isPermanent1 = false;

        public Sorcery(string name, string type, Mana manaCost, Bitmap picture) : base(name, type, manaCost, picture)
        {
        }

        public bool IsPermanent1 { get => isPermanent1; }

        /// <summary>
        /// create card (Sorcery)
        /// </summary>
        /// <param name="Type">determine card type</param>
        /// <returns>return  the card type</returns>
        public static Card SorceryFactory(string Type)
        {
            Card CardType = null;

            switch (Type)
            {
                case "blightning":
                    Mana manaBlightning = new Mana(1, 0, 0, 1, 1, 1);
                    CardType = new Sorcery("blightning", "Sorcery", manaBlightning, Resource.blightning);
                    break;

                case "chain_lightning":
                    Mana manaChainLightning = new Mana(0, 0, 0, 1, 0, 0);
                    CardType = new Sorcery("chain_lightning", "Sorcery", manaChainLightning, Resource.chain_lightning);
                    break;

                case "clone_legion":
                    Mana manaCloneLegion = new Mana(0, 2, 0, 0, 0, 7);
                    CardType = new Sorcery("clone_legion", "Sorcery", manaCloneLegion, Resource.clone_legion);
                    break;
            }

            return CardType;
        }
    }
}