using SpaceshipGame.Game.Entities;
using SpaceshipGame.Game.Views;

namespace SpaceshipGame.Game.Controllers
{
    internal class ManageAsteroids
    {
        private readonly List<Asteroid> _asteroids = new();
        private int _quantidade = 5;

        public ManageAsteroids()
        {
        }

        public List<Asteroid> List() => _asteroids;

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
                _asteroids.Add(new Asteroid(@"Images/48xAsteroide.ico", x, y, 1));
            }
        }

        private bool IsPositionValid(int x, int y)
        {
            foreach (var asteroid in _asteroids)
            {
                if (asteroid.X + Asteroid.Size >= x && asteroid.X <= x + Asteroid.Size &&
                    asteroid.Y + Asteroid.Size >= y && asteroid.Y <= y + Asteroid.Size)
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
                obj.Y++;
            }
            NewAsteroids();
            Remove();
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
            for (int i = 0; i < _asteroids.Count; i++)
            {
                if (_asteroids[i].Y > 510)
                {
                    _asteroids.RemoveAt(i);
                }
            }
        }
    }
}
