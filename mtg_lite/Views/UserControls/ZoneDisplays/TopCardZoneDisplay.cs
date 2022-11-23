using mtg_lite.Models.Zones;

namespace mtg_lite.Views.UserControls.ZoneDisplays
{
    public partial class TopCardZoneDisplay : UserControl
    {
        private Zone? zone;

        public Zone? Zone { get => zone; set => ChangeZone(value); }

        public TopCardZoneDisplay()
        {
            InitializeComponent();
        }

        private void ChangeZone(Zone? newZone)
        {
            Unsubscribe();
            zone = newZone;
            DisplayZone();
            Subscribe();
        }

        private void DisplayZone()
        {
            if (zone is null) { return; }
            lblZoneName.Text = zone.ToString();
            cardDisplay.Card = zone.TopCard;
        }

        private void Unsubscribe()
        {
            if (zone is null) { return; }
            zone.CardsChanged -= Zone_CardsChanged;
        }

        private void Subscribe()
        {
            if (zone is null) { return; }
            zone.CardsChanged += Zone_CardsChanged;
        }

        private void Zone_CardsChanged(object? sender, List<Models.Cards.Card> e)
        {
            DisplayZone();
        }

        private void cardDisplay_CardClicked(object sender, Models.Cards.Card card)
        {
            try
            {
                zone.Cardclick(card);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Zone_CardAdded(object? sender, Models.Cards.Card e)
        {
            zone.AddCard(e);
        }

        private void cardDisplay_Load(object sender, EventArgs e)
        {
        }

        private void TopCardZoneDisplay_Load(object sender, EventArgs e)
        {
        }
    }
}