using mtg_lite.Models.Cards;

namespace mtg_lite.Views.UserControls.CardDisplays
{
    public partial class CardDisplay : UserControl
    {
        private Card? card;

        public Card? Card { get => card; set => ChangeCard(value); }

        public event EventHandler<Card>? CardClicked;

        public CardDisplay()
        {
            InitializeComponent();
        }

        public CardDisplay(Card card) : this()
        {
            ChangeCard(card);
        }

        private void ChangeCard(Card? newCard)
        {
            card = newCard;
            InitDisplay();
        }

        private void InitDisplay()
        {
            if (card is null) { return; }
            var image = new Bitmap(card.Picture);
            picCard.Image = image;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (card is null) { return; }
            CardClicked?.Invoke(this, card);
        }
    }
}