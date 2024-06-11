using SpaceshipGame.Game.Views;

namespace SpaceshipGame.Game.Entities
{
    internal class Spaceship
    {
        private Image _image;
        private float _x;
        private float _y;
        private const int _size = 48;
        private float _speed;

        public Spaceship(string path, float x, float y, float speed)
        {
            try
            {
                _image = Image.FromFile(path);
            }
            catch (IOException e)
            {
                throw new IOException("Erro ao carregar imagem: " + e.Message, e);
            }
            X = x;
            Y = y;
            Speed = speed;
        }

        public Image Image
        {
            get => _image;
            set
            {
                try
                {
                    _image = value;
                }
                catch (ArgumentException e)
                {
                    throw new ArgumentException("Erro ao alterar imagem: " + e.Message, e);
                }
            }
        }

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
                else
                {
                    throw new ArgumentException("A velocidade deve estar entre 1 e 5.");
                }
            }
        }

        public void MoveLeft() => X -= Speed;
        public void MoveRight() => X += Speed;
    }
}
