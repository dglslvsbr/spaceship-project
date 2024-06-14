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
        private int Difficulty = 100;

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
            if (score > Difficulty)
            {
                _spaceship.Speed += 0.1f;
                _manageShots.Speed += 0.1f;
                _manageAsteroids.Speed += 0.1f;
                _manageAsteroids.Quantity += 1;
                Difficulty += 100;
            }
        }
    }
}
