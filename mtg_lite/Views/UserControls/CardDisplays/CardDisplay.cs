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
            card.TappedChanged += Card_TappedChanged;
        }

        private void ChangeCard(Card? newCard)
        {
            card = newCard;

            InitDisplay();
        }

        /// <summary>
        /// event handler pour changer si tapped ou non
        /// </summary>
        /// <param name="sender">la carte qui est tapped</param>
        /// <param name="e">E</param>
        private void Card_TappedChanged(object? sender, bool e)
        {
            sender = card.Picture;
        }

        private void InitDisplay()
        {
            if (card is null) { return; }
            var image = new Bitmap(card.Picture);
            picCard.Image = image;
        }

        /// <summary>
        /// va faire l'affichage de la carte
        /// </summary>
        /// <param name="sender">la carte cliquer dans le battlefield</param>
        /// <param name="e">E</param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (card is null) { return; }
            CardClicked?.Invoke(this, card);
            ChangeCard(card);
        }
    }
}