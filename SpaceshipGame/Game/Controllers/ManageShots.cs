using SpaceshipGame.Game.Entities;

namespace SpaceshipGame.Game.Controllers
{
    internal class ManageShots
    {
        private readonly List<Shot> _shots = new();
        private readonly Spaceship _spaceship;
        private bool _holdDown = true;
        private float _speed = 2;
        private int _placar;

        public ManageShots(Spaceship spaceship)
        {
            _spaceship = spaceship;
        }

        public List<Shot> List() => _shots;

        public void Add(Shot shot)
        {
            _shots.Add(shot);
        }

        public float Speed
        {
            get => _speed;
            set
            {
                if (value >= 1)
                {
                    _speed = value;
                }
            }
        }

        public int Placar
        {
            get => _placar;
            set
            {
                if (value > 0)
                {
                    _placar = value;
                }
            }
        }

        public void Shoot(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    if (_holdDown)
                    {
                        _holdDown = false;
                        Add(new Shot(@"Images/32xBala.png", _spaceship.X + 21, _spaceship.Y));
                    }
                    break;
            }
        }

        public void KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    _holdDown = true;
                    break;
            }
        }

        public void AutomaticShots()
        {
            for (int i = 0; i < _shots.Count; i++)
            {
                _shots[i].Y -= Speed;
            }
            _shots.RemoveAll(x => x.Y < 0);
        }
    }
}
