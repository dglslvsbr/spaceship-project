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
        private readonly ManageDifficulty _manageDifficulty;
        private readonly System.Windows.Forms.Timer _timer;

        public GameScreen()
        {
            InitializeComponent();
            _spaceship = new(@"Images/48xNave-Espacial.ico", 225, 410);
            _manageShots = new();
            _movement = new(_spaceship, _manageShots);
            _manageAsteroids = new(Count_Asteroids);
            _manageCollisions = new(_spaceship, _manageShots, _manageAsteroids, Count_Collision, Score);
            _endGame = new(_spaceship, _manageAsteroids, this);
            _manageDifficulty = new(_spaceship, _manageShots, _manageAsteroids, Score);

            _timer = new()
            {
                Interval = 10
            };
            _timer.Tick += Time;
            _timer.Start();

            InitializeEvents();
        }

        private void InitializeEvents()
        {
            DoubleBuffered = true;
            Paint += DrawOnScreen;
            KeyDown += _movement.Move;
            KeyUp += _movement.KeyUp;
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
            _manageDifficulty.VerifyScore();
        }
    }
}
