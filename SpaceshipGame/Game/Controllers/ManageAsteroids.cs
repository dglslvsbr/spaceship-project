using SpaceshipGame.Game.Entities;
using SpaceshipGame.Game.Views;

namespace SpaceshipGame.Game.Controllers
{
    internal class ManageAsteroids
    {
        private readonly Label _countAsteroid;
        private readonly List<Asteroid> _asteroids = new();
        private int _quantidade = 10;
        private float _speed = 1;
        private int _asteroidPassed;

        public ManageAsteroids(Label countAsteroid)
        {
            _countAsteroid = countAsteroid;
        }

        public List<Asteroid> List() => _asteroids;

        public int Quantity
        {
            get => _quantidade;
            set => _quantidade = value;
        }

        public float Speed
        {
            get => _speed;
            set
            {
                if (value >= 1 && value <= 5)
                {
                    _speed = value;
                }
                else
                {
                    throw new ArgumentException("A velocidade deve estar entre 1 e 5.");
                }
            }
        }

        public int AsteroidPassed => _asteroidPassed;

        public void Generate()
        {
            Random random = new();
            int x;
            int y;
            for (int i = 0; i < _quantidade; i++)
            {
                x = -1;
                y = -1;
                while (IsPositionValid(x, y))
                {
                    x = random.Next(GameScreen.MapWidth - Asteroid.Size);
                    y = random.Next(-100, -50);
                }
                _asteroids.Add(new Asteroid(@"Images/48xAsteroide.ico", x, y));
            }
        }

        private bool IsPositionValid(int x, int y)
        {
            foreach (var asteroid in _asteroids)
            {
                if (asteroid.X == x && asteroid.Y == y)
                {
                    return true;
                }
            }
            return false;
        }

        public void Movement()
        {
            foreach (var obj in _asteroids)
            {
                obj.Y += _speed;
            }
            Remove();
            CheckIfTheAsteroidPassed();
            NewAsteroids();
        }

        private void NewAsteroids()
        {
            if (_asteroids.Count == 0)
            {
                Generate();
            }
        }

        private void Remove()
        {
            _asteroids.RemoveAll(x => x.Y > 510);
        }

        private void CheckIfTheAsteroidPassed()
        {
            for (int i = _asteroids.Count - 1; i >= 0; i--)
            {
                if (_asteroids[i].Y > 500)
                {
                    _asteroidPassed++;
                    _asteroids.RemoveAt(i);
                    _countAsteroid.Text = _asteroidPassed.ToString();
                }
            }
        }
    }
}
