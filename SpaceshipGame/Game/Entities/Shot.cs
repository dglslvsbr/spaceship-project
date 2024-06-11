namespace SpaceshipGame.Game.Entities
{
    internal class Shot
    {
        private Image _image;
        private float _x;
        private float _y;
        private const int _size = 5;
        private float _speed;

        public Shot(string path, float x, float y, float speed)
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
            set => _x = value;
        }

        public float Y
        {
            get => _y;
            set => _y = value;
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
    }
}
