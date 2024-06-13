using SpaceshipGame.Game.Entities;

namespace SpaceshipGame.Game.Controllers
{
    internal class ManageShots
    {
        private readonly List<Shot> _shots = new();
        private float _speed = 2;
        private int _placar;

        public ManageShots()
        {
        }

        public List<Shot> List() => _shots;

        public float Speed
        {
            get => _speed;
            set
            {
                if (value >= 1 && value <= 5)
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

        public void AutomaticShots()
        {
            foreach (var obj in _shots)
            {
                obj.Y -= _speed;
            }
            RemoveShot();
        }

        private void RemoveShot()
        {
            _shots.RemoveAll(x => x.Y < 0);
        }
    }
}
