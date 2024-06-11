using SpaceshipGame.Game.Entities;
using System.Reflection.Metadata.Ecma335;

namespace SpaceshipGame.Game.Controllers
{
    internal class ManageCollisions
    {
        private readonly Spaceship _spaceship;
        private readonly ManageShots _manageShots;
        private readonly ManageAsteroids _manageAsteroids;


        public ManageCollisions(Spaceship spaceship, ManageShots manageShots, ManageAsteroids manageAsteroids)
        {
            _spaceship = spaceship;
            _manageShots = manageShots;
            _manageAsteroids = manageAsteroids;

        }

        public void CheckCollisions()
        {
            RemoveShotAndAsteroid();
            CheckSpaceshipCollision();
        }

        private void RemoveShotAndAsteroid()
        {
            var shots = _manageShots.List();
            var asteroids = _manageAsteroids.List();
            for (int i = shots.Count - 1; i >=0; i--)
            {
                for (int j = asteroids.Count - 1; j >= 0; j--)
                {
                    if (IsCollision(shots[i], asteroids[j]))
                    {
                        shots.RemoveAt(i);
                        asteroids.RemoveAt(j);
                        break;
                    }
                }
            }
        }

        private void CheckSpaceshipCollision()
        {
            var asteroids = _manageAsteroids.List();
            for (int i = asteroids.Count - 1; i >= 0; i--)
            {
                if (IsCollision(_spaceship, asteroids[i]))
                {
                    asteroids.RemoveAt(i);
                }
            }
           
        }

        private bool IsCollision(Shot shot, Asteroid asteroid)
        {
            return shot.X + Shot.Size >= asteroid.X &&
                   shot.X <= asteroid.X + Asteroid.Size &&
                   shot.Y + Shot.Size >= asteroid.Y &&
                   shot.Y <= asteroid.Y + Asteroid.Size;
        }

        private bool IsCollision(Spaceship spaceship, Asteroid asteroid)
        {
            return spaceship.X + Spaceship.Size >= asteroid.X &&
                   spaceship.X <= asteroid.X + Asteroid.Size &&
                   spaceship.Y + Spaceship.Size >= asteroid.Y &&
                   spaceship.Y <= asteroid.Y + Asteroid.Size;
        }
      
    }
}
