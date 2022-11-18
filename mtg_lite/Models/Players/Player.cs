using mtg_lite.Models.Cards;
using mtg_lite.Models.Zones;
using MTGO_lite.Models.Manas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Players
{
    public class Player
    {
        private Mana manaPool;
        private Battlefield battlefield;
        private Zone graveyard;
        private Zone hand;
        private Zone library;

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

        public void PlayCard(Card card)
        {
            if (card.Tapped)
            {
                MessageBox.Show("Is tapped."); //test message

                if (card.IsPermanent)
                {
                    MessageBox.Show("Is permanent."); //test message
                }
                else
                {
                    //====> sorcery <====\\
                    MessageBox.Show("Is not permanent."); //test message
                }
            }
            else
            {
                MessageBox.Show("Is not tapped."); //test message

                if (card.GetType().ToString() == "Creatures")
                {
                    MessageBox.Show("Is Creature."); //test message
                }
                else if (card.GetType().ToString() == "Land")
                {
                    MessageBox.Show("Is Land."); //test message
                }
                else if (card.GetType().ToString() == "Sorcery")
                {
                    MessageBox.Show("Is Sorcery."); //test message
                }
            }

            MessageBox.Show(card.Name); //test message
        }
    }
}