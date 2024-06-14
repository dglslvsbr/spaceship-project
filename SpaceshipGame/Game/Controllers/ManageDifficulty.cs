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
                AdjustSpaceshipSpeed(0.1f);
                AdjustShotsSpeed(0.1f);
                AdjustAsteroidsSpeed(0.1f);
                IncreaseAsteroidsQuantity(1);
                Difficulty += 100;
            }
        }

        private void AdjustSpaceshipSpeed(float increment)
        {
            _spaceship.Speed += increment;
        }

        private void AdjustShotsSpeed(float increment)
        {
            _manageShots.Speed += increment;
        }

        private void AdjustAsteroidsSpeed(float increment)
        {
            _manageAsteroids.Speed += increment;
        }

        private void IncreaseAsteroidsQuantity(int quantity)
        {
            _manageAsteroids.Quantity += quantity;
        }
    }
}
