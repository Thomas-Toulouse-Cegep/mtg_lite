﻿using mtg_lite.Models.Cards;
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
            //Les pool de mana pour les test se trouve en debut code

            if (card.Tapped)
            {
                //MessageBox.Show("Is tapped."); //test message

                if (card.IsPermanent)
                {
                    //  MessageBox.Show("Is permanent."); //test message
                }
                else
                {
                    //====> sorcery <====\\
                    // MessageBox.Show("Is not permanent."); //test message
                }
            }
            else
            {
                //dit si la carte est Tapped
                MessageBox.Show("Is not tapped.");
                //Fait une action en fonction du type de la carte
                switch (card.Type)
                {
                    //Creatures
                    case "Creatures":
                        //action pour Creature
                        manaPool.Pay(card.ManaCost);
                        //verification action
                        /*  MessageBox.Show(testMana.Black.ToString());
                          MessageBox.Show(testMana.Blue.ToString());
                          MessageBox.Show(testMana.Colorless.ToString());
                          MessageBox.Show(testMana.Green.ToString());
                          MessageBox.Show(testMana.Red.ToString());
                          MessageBox.Show(testMana.White.ToString());*/
                        //dit le type
                        /*    MessageBox.Show("Is Creature.");*/
                        break;
                    //Land
                    case "Land":
                        //action pour Land
                        testMana.Add(card.ManaCost);
                        //verification action
                        /*  MessageBox.Show(testMana.Black.ToString());
                          MessageBox.Show(testMana.Blue.ToString());
                          MessageBox.Show(testMana.Colorless.ToString());
                          MessageBox.Show(testMana.Green.ToString());
                          MessageBox.Show(testMana.Red.ToString());
                          MessageBox.Show(testMana.White.ToString());*/
                        //dit le type
                        //MessageBox.Show("Is Land.");
                        break;
                    //Sorcery
                    case "Sorery":
                        //dit le type
                        //   MessageBox.Show("Is Sorcery.");
                        break;
                }
            }

            // MessageBox.Show(card.Name); //test message
        }
    }
}