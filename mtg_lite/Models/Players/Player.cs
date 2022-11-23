using mtg_lite.Models.Cards;
using mtg_lite.Models.Zones;
using MTGO_lite.Models.Manas;

namespace mtg_lite.Models.Players
{
    public class Player
    {
        //pool de mana pour les tests
        private Mana testMana = new Mana(10, 10, 10, 10, 10, 0);

        private Mana manaPool;
        private Battlefield battlefield;
        private Zone graveyard;
        private Zone hand;
        private Zone library;

        ///
        public Mana ManaPool { get => manaPool; }

        public Battlefield Battlefield { get => battlefield; }
        public Zone Graveyard { get => graveyard; }
        public Zone Hand { get => hand; }
        public Zone Library { get => library; }

        public Player(string libraryName)
        {
            manaPool = new Mana();
            battlefield = new Battlefield(BattlefieldManager.GetCards(libraryName), this);
            graveyard = new Graveyard(GraveyardManager.GetCards(libraryName), this);
            hand = new Hand(HandManager.GetCards(libraryName), this);
            this.library = new Library(LibraryManager.GetCards(libraryName), this);
            Subscribe();
        }

        public void Subscribe()
        {
            library.CardRemoved += Library_CardRemoved;
            hand.CardRemoved += Hand_CardRemoved;
        }

        private void Hand_CardRemoved(object? sender, Card card)
        {
            PlayCard(card);
            if (card.Type == "Sorcery")
            {
                graveyard.AddCard(card);
            }
            battlefield.AddCard(card);
        }

        private void Library_CardRemoved(object? sender, Cards.Card card)
        {
            hand.AddCard(card);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="card"> the card  the player is playing</param>
        public void PlayCard(Card card)
        {
            //La pool de mana pour les test se trouve en debut code

            if (card.Tapped)
            {
                if (card.IsPermanent)
                {

                }
                else
                {
                    //====> sorcery <====\\
                }
            }
            else
            {
                switch (card.Type)
                {
                    case "Creatures":                       
                        manaPool.Pay(card.ManaCost);
                        break;
                        
                    case "Land":
                        manaPool.Add(card.ManaCost);
                        break;
                        
                    case "Sorcery":
                        manaPool.Pay(card.ManaCost);
                        break;
                }
            }
        }
    }
}