using SpaceshipGame.Game.Entities;

namespace SpaceshipGame.Game.Controllers
{
    internal class Movement
    {
        private char _direction;
        private readonly Spaceship _spaceship;
        private readonly ManageShots _manageShots;

        public Movement(Spaceship spaceship, ManageShots manageShots)
        {
            _spaceship = spaceship;
            _manageShots = manageShots;
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
                case Keys.W:
                    var list = _manageShots.List();
                    list.Add(new Shot(@"Images/32xBala.png", _spaceship.X + 21, _spaceship.Y, 2));
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
