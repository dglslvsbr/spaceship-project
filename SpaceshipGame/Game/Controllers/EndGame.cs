using SpaceshipGame.Game.Entities;
using SpaceshipGame.Game.Views;

namespace SpaceshipGame.Game.Controllers
{
    internal class EndGame
    {
        private readonly Spaceship _spaceship;
        private readonly ManageAsteroids _manageAsteroids;
        private readonly GameScreen _gameScreen;

        public EndGame(Spaceship spaceship, ManageAsteroids manageAsteroids, GameScreen gameScreen)
        {
            _spaceship = spaceship;
            _manageAsteroids = manageAsteroids;
            _gameScreen = gameScreen;
        }

        public void CheckEndOfGame()
        {
            if (_spaceship.Collisions >= 5 || _manageAsteroids.AsteroidPassed >= 5)
            {
                _gameScreen.Close();
            }
        }
    }
}
