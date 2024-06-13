namespace SpaceshipGame.Game.Entities
{
    internal class Shot
    {
        private readonly Image _image;
        private float _x;
        private float _y;
        private const int _size = 5;

        public Shot(string path, float x, float y)
        {
            _image = Image.FromFile(path);
            X = x;
            Y = y;
        }

        public Image Image => _image;

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
