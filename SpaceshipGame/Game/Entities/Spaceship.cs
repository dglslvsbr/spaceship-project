using SpaceshipGame.Game.Views;

namespace SpaceshipGame.Game.Entities
{
    internal class Spaceship
    {
        private readonly Image _image;
        private float _x;
        private float _y;
        private const int _size = 48;
        private float _speed = 2;
        private int _collisions;

        public Spaceship(string path, float x, float y)
        {   
            _image = Image.FromFile(path);
            X = x;
            Y = y;
        }

        public Image Image => _image;

        public float X
        {
            get => _x;
            set
            {
                if (value >= 0 && value <= GameScreen.MapWidth - Size - 15)
                {
                    _x = value;
                }
            }
        }

        public float Y
        {
            get => _y;
            set
            {
                if (value >= 0 && value <= GameScreen.MapHeight - Size - 15)
                {
                    _y = value;
                }
            }
        }

        public static int Size => _size;

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

        public int Collisions
        {
            get => _collisions;
            set
            {
                if (value <= 5)
                {
                    _collisions = value;
                }
            }
        }

        public void MoveLeft() => X -= Speed;
        public void MoveRight() => X += Speed;
    }
}
