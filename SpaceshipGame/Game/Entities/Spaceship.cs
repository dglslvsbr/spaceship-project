﻿using SpaceshipGame.Game.Views;

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
                throw new("Erro ao carregar imagem: " + e);
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
                catch (IOException e)
                {
                    throw new("Erro ao carregar a imagem: " + e);
                }
            }
        }

        public float X
        {
            get => _x;
            set
            {
                if (value >= 0 && value <= GameScreen.MapWidth - Size)
                {
                    _x = value;
                }
                else
                {
                    throw new($"O valor deve estar entre 0 e {GameScreen.MapWidth}");
                }
            }
        }

        public float Y
        {
            get => _y;
            set
            {
                if (value >= 0 && value <= GameScreen.MapHeight - Size)
                {
                    _y = value;
                }
                else
                {
                    throw new ($"O valor deve estar entre 0 e {GameScreen.MapHeight}");
                }
            }
        }

        public static int Size => _size;

        public float Speed
        {
            get => _speed;
            set
            {
                if (value > 1 && value <= 5)
                {
                    _speed = value;
                }
                else
                {
                    throw new ("A velocidade deve estar entre 1 e 5.");
                }
            }
        }
    }
}