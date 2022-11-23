using mtg_lite.Controllers;

namespace mtg_lite
{
    public partial class FormGame : Form
    {
        private Controller controller;

        public FormGame()
        {
            InitializeComponent();
            controller = new Controller();
            InitZonesDisplay();
            manaPoolDisplay.ManaPool = controller.Player.ManaPool;
        }

        private void InitZonesDisplay()
        {
            libraryDisplay.Zone = controller.Player.Library;
            graveyardDisplay.Zone = controller.Player.Graveyard;
            handDisplay.Hand = controller.Player.Hand;
            battlefieldDisplay.Battlefield = controller.Player.Battlefield;
        }

        private void libraryDisplay_Load(object sender, EventArgs e)
        {
        }

        private void handDisplay_Load(object sender, EventArgs e)
        {
        }

        private void battlefieldDisplay_Load(object sender, EventArgs e)
        {
        }

        private void graveyardDisplay_Load(object sender, EventArgs e)
        {
        }
    }
}