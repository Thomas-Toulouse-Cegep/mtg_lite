using mtg_lite.Models.Zones;

namespace mtg_lite.Views.UserControls.ZoneDisplays
{
    public partial class BattlefieldDisplay : UserControl
    {
        private Battlefield? battlefield;

        public Battlefield? Battlefield { get => battlefield; set => ChangeBattlefield(value); }

        public BattlefieldDisplay()
        {
            InitializeComponent();
        }

        private void ChangeBattlefield(Battlefield? newBattlefield)
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
            creaturesDisplay.Cards = battlefield.returnCreatures();
            landsDisplay.Cards = battlefield.returnLand();
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
                battlefield.Cardclick(card);
            }
            catch (Exception)
            {
                MessageBox.Show("Card can't be play");
            }
        }

        private void creaturesDisplay_Load(object sender, EventArgs e)
        {
        }

        private void landsDisplay_Load(object sender, EventArgs e)
        {
        }

        private void grpBattlefield_Enter(object sender, EventArgs e)
        {
        }
    }
}