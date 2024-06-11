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
        private readonly ManageAsteroids _manageAsteroids;
        private readonly ManageShots _manageShots;
        private readonly ManageCollisions _manageCollisions;
        private readonly EndGame _endGame;

        private readonly System.Windows.Forms.Timer Timer;

        public GameScreen()
        {
            InitializeComponent();
            _spaceship = new(@"Images/48xNave-Espacial.ico", 225, 410, 2);
            _manageShots = new();
            _movement = new(_spaceship, _manageShots);
            _manageAsteroids = new();
            _manageCollisions = new(_spaceship, _manageShots, _manageAsteroids);
            _endGame = new(_spaceship, _manageAsteroids, this);

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

            // Asteroides
            foreach (var obj in _manageAsteroids.List())
            {
                e.Graphics.DrawImage(obj.Image, obj.X, obj.Y, Asteroid.Size, Asteroid.Size);
            }

            // Disparos
            foreach (var obj in _manageShots.List())
            {
                e.Graphics.DrawImage(obj.Image, obj.X, obj.Y, Shot.Size, Shot.Size);
            }
        }

        private void Time(object sender, EventArgs e)
        {
            Refresh();
            _movement.AutomaticMovement();
            _manageAsteroids.Movement();
            _manageShots.AutomaticShots();
            _manageCollisions.CheckCollisions();
            _endGame.CheckEndOfGame();
        }
    }
}
