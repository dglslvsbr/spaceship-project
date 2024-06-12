using SpaceshipGame.Game.Entities;

namespace SpaceshipGame.Game.Controllers
{
    internal class ManageDifficulty
    {
        private readonly Spaceship _spaceship;
        private readonly ManageShots _manageShots;
        private readonly ManageAsteroids _manageAsteroids;
        private readonly Label _score;
        private int score;

        public ManageDifficulty(Spaceship spaceship, ManageShots manageShots, ManageAsteroids manageAsteroids, Label score)
        {
            _spaceship = spaceship;
            _manageShots = manageShots;
            _manageAsteroids = manageAsteroids;
            _score = score;
        }

        public void VerifyScore()
        {
            if (int.TryParse(_score.Text, out score))
            {
                UpdateDifficulty();
            }
        }

        private void UpdateDifficulty()
        {
            if (score > 2000)
            {
                _spaceship.Speed = 5f;
                _manageShots.Speed = 5f;
                _manageAsteroids.Speed = 2.4f;
                _manageAsteroids.Quantity = 17;
            }
            else if (score > 1000 && score < 2000)
            {
                _spaceship.Speed = 3.9f;
                _manageShots.Speed = 3.9f;
                _manageAsteroids.Speed = 2.2f;
                _manageAsteroids.Quantity = 16;
            }
            else if (score > 500 && score < 600)
            {
                _spaceship.Speed = 3.7f;
                _manageShots.Speed = 3.7f;
                _manageAsteroids.Speed = 2f;
                _manageAsteroids.Quantity = 15;
            }
            else if (score > 400 && score < 500)
            {
                _spaceship.Speed = 3.6f;
                _manageShots.Speed = 3.6f;
                _manageAsteroids.Speed = 1.8f;
                _manageAsteroids.Quantity = 14;
            }
            else if (score > 300 && score < 400)
            {
                _spaceship.Speed = 3.4f;
                _manageShots.Speed = 3.4f;
                _manageAsteroids.Speed = 1.6f;
                _manageAsteroids.Quantity = 13;
            }
            else if (score > 200 && score < 300)
            {
                _spaceship.Speed = 3.2f;
                _manageShots.Speed = 3.2f;
                _manageAsteroids.Speed = 1.4f;
                _manageAsteroids.Quantity = 12;
            }
            else if (score > 100 && score < 200)
            {
                _spaceship.Speed = 3f;
                _manageShots.Speed = 3f;
                _manageAsteroids.Speed = 1.2f;
                _manageAsteroids.Quantity = 11;
            }
        }
    }
}
