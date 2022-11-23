using MTGO_lite.Models.Manas;

namespace mtg_lite.Views.UserControls.ManaDisplays
{
    public partial class ManaPoolDisplay : UserControl
    {
        private Mana? manaPool;

        public Mana? ManaPool { get => manaPool; set => ChangeManaPool(value); }

        public ManaPoolDisplay()
        {
            InitializeComponent();
        }

        private void ChangeManaPool(Mana? newManaPool)
        {
            this.manaPool = newManaPool;
            DisplayManaPool();
        }

        private void DisplayManaPool()
        {
            if (manaPool is null) { return; }
            foreach (var mana in manaPool.ManaColors)
            {
                var manaColorDisplay = new ManaColorDisplay();
                manaColorDisplay.ManaColor = mana.Value;
                flowLayoutPanel.Controls.Add(manaColorDisplay);
            }
        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}