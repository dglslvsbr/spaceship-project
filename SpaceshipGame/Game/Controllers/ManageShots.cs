using SpaceshipGame.Game.Entities;

namespace SpaceshipGame.Game.Controllers
{
    internal class ManageShots
    {
        private readonly List<Shot> _shots = new();

        public ManageShots()
        {
        }

        public List<Shot> List() => _shots;

        public void AutomaticShots()
        {
            foreach (var obj in _shots)
            {
                obj.Y -= obj.Speed;
            }
            Remove();
        }

        private void Remove()
        {
            for (int i = 0; i < _shots.Count; i++)
            {
                if (_shots[i].Y < 0)
                {
                    _shots.RemoveAt(i);
                }
            }
        }
    }
}
