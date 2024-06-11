using SpaceshipGame.Game.Entities;

namespace SpaceshipGame.Game.Views
{
    public partial class GameScreen : Form
    {
        public const int MapWidth = 500;
        public const int MapHeight = 500;

        public GameScreen()
        {
            InitializeComponent();
            Spaceship spaceship = new(@"Images/48xNaved-Esdpacial.ico", 100, 100, 1f);
        }
    }
}
