using SpaceshipGame.Game.Entities;

namespace SpaceshipGame.Game.Controllers
{
    internal class ManageCollisions
    {
        private readonly Spaceship _spaceship;
        private readonly ManageShots _manageShots;
        private readonly ManageAsteroids _manageAsteroids;
        private readonly Label _countCollision;
        private readonly Label _score;


        public ManageCollisions(Spaceship spaceship, ManageShots manageShots,
               ManageAsteroids manageAsteroids, Label countCollision, Label score)
        {
            _spaceship = spaceship;
            _manageShots = manageShots;
            _manageAsteroids = manageAsteroids;
            _countCollision = countCollision;
            _score = score;

        }

        public void CheckCollisions()
        {
            RemoveShotAndAsteroid();
            CheckSpaceshipCollision();
        }

        private void RemoveShotAndAsteroid()
        {
            var shots = new List<Shot>(_manageShots.List());
            var asteroids = new List<Asteroid>(_manageAsteroids.List());
            var indicesToRemove = new List<(int shotIndex, int asteroidIndex)>();

            for (int i = shots.Count - 1; i >= 0; i--)
            {
                for (int j = asteroids.Count - 1; j >= 0; j--)
                {
                    if (IsCollision(shots[i], asteroids[j]))
                    {
                        IncreasePlacar();
                        indicesToRemove.Add((i, j));
                    }
                }
            }
            foreach (var (shotIndex, asteroidIndex) in indicesToRemove)
            {
                _manageShots.List().RemoveAt(shotIndex);
                _manageAsteroids.List().RemoveAt(asteroidIndex);
            }
        }



        private void IncreasePlacar()
        {
            _manageShots.Placar += 10;
            _score.Text = _manageShots.Placar.ToString();
        }

        private void CheckSpaceshipCollision()
        {
            var asteroidsCopy = new List<Asteroid>(_manageAsteroids.List());
            var indicesToRemove = new List<int>();

            for (int i = asteroidsCopy.Count - 1; i >= 0; i--)
            {
                if (IsCollision(_spaceship, asteroidsCopy[i]))
                { 
                    IncreaseCollision();
                    indicesToRemove.Add(i);
                }
            }
            foreach (var index in indicesToRemove)
            {
                _manageAsteroids.List().RemoveAt(index);
            }
        }

        private void IncreaseCollision()
        {
            _spaceship.Collisions++;
            _countCollision.Text = _spaceship.Collisions.ToString();
        }

        private static bool IsCollision(Shot shot, Asteroid asteroid)
        {
            return shot.X + Shot.Size >= asteroid.X &&
                   shot.X <= asteroid.X + Asteroid.Size &&
                   shot.Y + Shot.Size >= asteroid.Y &&
                   shot.Y <= asteroid.Y + Asteroid.Size;
        }

        private static bool IsCollision(Spaceship spaceship, Asteroid asteroid)
        {
            return spaceship.X + Spaceship.Size >= asteroid.X &&
                   spaceship.X <= asteroid.X + Asteroid.Size &&
                   spaceship.Y + Spaceship.Size >= asteroid.Y &&
                   spaceship.Y <= asteroid.Y + Asteroid.Size;
        }
    }
}
