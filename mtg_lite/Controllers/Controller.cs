using mtg_lite.Models.Players;

namespace mtg_lite.Controllers
{
    public class Controller

    {
        private Player player;

        public Player Player { get => player; }

        public Controller()
        {
            player = new Player("Red");
        }
    }
}