using SpaceshipGame.Game.Entities;

namespace SpaceshipGame.Game.Controllers
{
    internal class Movement
    {
        private char _direction;
        private readonly Spaceship _spaceship;

        public Movement(Spaceship spaceship)
        {
            _spaceship = spaceship;
        }

        public void Move(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    _direction = 'A';
                    break;
                case Keys.D:
                    _direction = 'D';
                    break;
            }
        }

        public void AutomaticMovement()
        {
            switch (_direction)
            {
                case 'A':
                    _spaceship.MoveLeft();
                    break;
                case 'D':
                    _spaceship.MoveRight();
                    break;
            }
        }
    }
}
