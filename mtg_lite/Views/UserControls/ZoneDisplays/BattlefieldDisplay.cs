﻿using mtg_lite.Models.Cards;
using mtg_lite.Models.Cards.Permanent;
using mtg_lite.Models.Zones;
using mtg_lite.Views.UserControls.CardDisplays;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace mtg_lite.Views.UserControls.ZoneDisplays
{
    public partial class BattlefieldDisplay : UserControl
    {
        private Zone? battlefield;

        public Zone? Battlefield { get => battlefield; set => ChangeBattlefield(value); }

        public BattlefieldDisplay()
        {
            InitializeComponent();
        }

        private void ChangeBattlefield(Zone? newBattlefield)
        {
            BattlefieldUnsubscribe();
            battlefield = newBattlefield;
            DisplayBattlefield();
            BattlefieldSubscribe();
        }

        private void DisplayBattlefield()
        {
            if (battlefield is null) { return; }
            grpBattlefield.Text = battlefield.ToString();
            creaturesDisplay.Cards = battlefield.Cards;
        }

        private void BattlefieldUnsubscribe()
        {
            if (battlefield is null) { return; }
            battlefield.CardsChanged -= Battlefield_CardsChanged;
        }

        private void BattlefieldSubscribe()
        {
            if (battlefield is null) { return; }
            battlefield.CardsChanged += Battlefield_CardsChanged;
        }

        private void Battlefield_CardsChanged(object? sender, List<Models.Cards.Card> cards)
        {
            DisplayBattlefield();
        }

        private void cardsDisplay_CardClicked(object sender, Models.Cards.Card card)
        {
            try
            {
                if (card.GetType().ToString() == "Creatures")
                {
                    battlefield.Cardclick(card);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("i");
            }
        }

        private void creaturesDisplay_Load(object sender, EventArgs e)
        {
        }

        private void landsDisplay_Load(object sender, EventArgs e)
        {
        }
    }
}