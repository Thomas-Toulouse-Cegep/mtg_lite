using MTGO_lite.Models.Manas.ManaColors;

namespace mtg_lite.Views.UserControls.ManaDisplays
{
    public partial class ManaColorDisplay : UserControl
    {
        private ManaColor? manaColor;

        public ManaColor? ManaColor { get => manaColor; set => ChangeManaColor(value); }

        public ManaColorDisplay()
        {
            InitializeComponent();
        }

        private void ChangeManaColor(ManaColor? newManaColor)
        {
            manaColor = newManaColor;
            DisplayManaColor();
        }

        private void DisplayManaColor()
        {
            if (manaColor is null) { return; }
            picIcon.Image = manaColor.Icon;
            UpdateDisplayQuantity();
        }

        private void UpdateDisplayQuantity()
        {
            if (manaColor is null) { return; }
            lblQuantity.Text = manaColor.Quantity.ToString();
        }
    }
}