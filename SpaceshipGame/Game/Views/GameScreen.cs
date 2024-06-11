using SpaceshipGame.Game.Entities;

namespace SpaceshipGame.Game.Views
{
    public partial class GameScreen : Form
    {
        public const int MapWidth = 500;
        public const int MapHeight = 500;

        private readonly Spaceship _spaceship;

        public GameScreen()
        {
            InitializeComponent();
            _spaceship = new(@"Images/48xNave-Espacial.ico", 225, 410, 1);

            InitializeGame();
        }

        private void InitializeGame()
        {
            DoubleBuffered = true;
            Paint += DrawOnScreen;
        }

        private void DrawOnScreen(object sender, PaintEventArgs e)
        {
            // Nave
            e.Graphics.DrawImage(_spaceship.Image, _spaceship.X, _spaceship.Y, Spaceship.Size, Spaceship.Size);
        }
    }
}
