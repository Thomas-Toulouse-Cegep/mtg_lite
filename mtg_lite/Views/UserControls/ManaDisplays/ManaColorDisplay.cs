using mtg_lite.Models.Zones;
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
            ManaColorUnsubscribe();
            manaColor = newManaColor;
            ManaColorSubscribe();
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
        
        private void ManaColorSubscribe()
        {
            if (manaColor is null) { return; }
            manaColor.QuantityChanged += ManaColor_QuantityChanged;
            manaColor.QuantityChangedInt += ManaColor_QuantityChangedInt;
        }

        private void ManaColorUnsubscribe()
        {
            if (manaColor is null) { return; }

            manaColor.QuantityChanged -= ManaColor_QuantityChanged;
            manaColor.QuantityChangedInt -= ManaColor_QuantityChangedInt;
        }

        private void ManaColor_QuantityChanged(object? sender, ManaColor manaColor)
        {
            DisplayManaColor();
        }

        private void ManaColor_QuantityChangedInt(object? sender, int quantity)
        {
            DisplayManaColor();
        }
    }
}