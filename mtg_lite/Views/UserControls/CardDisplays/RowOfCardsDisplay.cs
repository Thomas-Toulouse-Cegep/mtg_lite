using mtg_lite.Models.Cards;

namespace mtg_lite.Views.UserControls.CardDisplays
{
    public partial class RowOfCardsDisplay : UserControl
    {
        private List<Card>? cards;

        public List<Card>? Cards { get => cards; set => ChangeCards(value); }

        public event EventHandler<Card>? CardClicked;

        public RowOfCardsDisplay()
        {
            InitializeComponent();
        }

        private void ChangeCards(List<Card>? newCards)
        {
            cards = newCards;
            InitCards();
        }

        private void InitCards()
        {
            if (cards is null) { return; }
            flowLayoutPanel.Controls.Clear();
            foreach (var card in cards)
            {
                InitACard(card);
            }
        }

        private void InitACard(Card card)
        {
            var cardDisplay = new CardDisplay(card);
            cardDisplay.CardClicked += CardDisplay_CardClicked;
            flowLayoutPanel.Controls.Add(cardDisplay);
        }

        private void CardDisplay_CardClicked(object? sender, Card card)
        {
            CardClicked?.Invoke(this, card);
        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}