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
            var shotsCopy = new List<Shot>(_manageShots.List());
            var asteroidsCopy = new List<Asteroid>(_manageAsteroids.List());
            var shotsToRemove = new List<Shot>();
            var asteroidsToRemove = new List<Asteroid>();

            foreach (var shot in shotsCopy)
            {
                foreach (var asteroid in asteroidsCopy)
                {
                    if (IsCollision(shot, asteroid))
                    {
                        IncreasePlacar();
                        shotsToRemove.Add(shot);
                        asteroidsToRemove.Add(asteroid);
                    }
                }
            }
            foreach (var shot in shotsToRemove)
            {
               _manageShots.List().Remove(shot);
            }
            foreach (var asteroid in asteroidsToRemove)
            {
                _manageAsteroids.List().Remove(asteroid);
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
            var asteroidsToRemove = new List<Asteroid>();

            foreach (var asteroid in asteroidsCopy)
            {
                if (IsCollision(_spaceship, asteroid))
                {
                    IncreaseCollision();
                    asteroidsToRemove.Add(asteroid);
                }
            }
            foreach (var asteroid in asteroidsToRemove)
            {
                _manageAsteroids.List().Remove(asteroid);
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
