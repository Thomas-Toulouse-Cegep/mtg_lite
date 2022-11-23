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

        private void Card_TappedChanged(object? sender, bool e)
        {
            sender = card.Picture;
            card.Picture.RotateFlip(RotateFlipType.Rotate180FlipNone);
            // card.Picture = sender;
            // card.Picture.Dispose();
            //object? value = card.Tapped;
            //  card.Tapped = e;
            //card.Picture = card.Picture;
            //card.Picture = card.Picture;
        }

        private void InitDisplay()
        {
            if (card is null) { return; }
            var image = new Bitmap(card.Picture);
            picCard.Image = image;
            card.TappedChanged += Card_TappedChanged;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (card is null) { return; }
            CardClicked?.Invoke(this, card);
            //card.TappedChanged += Card_TappedChanged;
        }
    }
}