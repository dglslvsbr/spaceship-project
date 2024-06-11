using Microsoft.VisualBasic;
using SpaceshipGame.Game.Controllers;
using SpaceshipGame.Game.Entities;

namespace SpaceshipGame.Game.Views
{
    public partial class GameScreen : Form
    {
        public const int MapWidth = 500;
        public const int MapHeight = 500;

        private readonly Spaceship _spaceship;
        private readonly Movement _movement;

        private readonly System.Windows.Forms.Timer Timer;

        public GameScreen()
        {
            InitializeComponent();
            _spaceship = new(@"Images/48xNave-Espacial.ico", 225, 410, 2);
            _movement = new(_spaceship);
            Timer = new()
            {
                Interval = 10
            };
            Timer.Tick += Time;
            Timer.Start();

            InitializeGame();
        }

        private void InitializeGame()
        {
            DoubleBuffered = true;
            Paint += DrawOnScreen;
            KeyDown += _movement.Move;
        }

        private void DrawOnScreen(object sender, PaintEventArgs e)
        {
            // Nave
            e.Graphics.DrawImage(_spaceship.Image, _spaceship.X, _spaceship.Y, Spaceship.Size, Spaceship.Size);
        }

        private void Time(object sender, EventArgs e)
        {
            Refresh();
            _movement.AutomaticMovement();
        }
    }
}
