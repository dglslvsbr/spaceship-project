namespace SpaceshipGame.Game.Entities
{
    internal class Asteroid
    {
        private Image _image;
        private float _x;
        private float _y;
        private const int _size = 48;

        public Asteroid(string path, float x, float y)
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
    }
}
