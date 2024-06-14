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

        public void AutomaticShots()
        {
            for (int i = _shots.Count - 1; i >= 0; i--)
            {
                _shots[i].Y -= Speed;

                if (_shots[i].Y < 0)
                {
                    _shots.RemoveAt(i);
                }
            }
        }
    }
}
