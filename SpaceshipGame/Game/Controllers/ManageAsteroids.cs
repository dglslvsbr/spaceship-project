﻿using System.Timers;
using SpaceshipGame.Game.Entities;
using SpaceshipGame.Game.Views;

namespace SpaceshipGame.Game.Controllers
{
    internal class ManageAsteroids
    {

        private readonly List<Asteroid> _asteroids = new();
        private readonly System.Timers.Timer _timer;
        private readonly Label _countAsteroid;
        private int _quantidade = 10;
        private float _speed = 1;
        private int _asteroidPassed;
        private int _generatedAsteroids;

        public ManageAsteroids(Label countAsteroid)
        {
            _countAsteroid = countAsteroid;
            _timer = new System.Timers.Timer(300);
            _timer.Elapsed += OnTimedEvent;
            _timer.AutoReset = true;
        }

        public List<Asteroid> List() => _asteroids;

        public void AddAsteroid(Asteroid asteroid)
        {
            _asteroids.Add(asteroid);
        }

        public int Quantity
        {
            get => _quantidade;
            set => _quantidade = value;
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

        public int AsteroidPassed => _asteroidPassed;

        public void Movement()
        {
            for (int i = 0; i < _asteroids.Count; i++)
            {
                _asteroids[i].Y += Speed;
                if (_asteroids[i].Y > 500)
                {
                    IncreaseCountAsteroid();
                }
            }
            _asteroids.RemoveAll(x => x.Y > 500);
            NewAsteroids();
        }

        private void IncreaseCountAsteroid()
        {
            _asteroidPassed++;
            _countAsteroid.Text = _asteroidPassed.ToString();
        }

        private void NewAsteroids()
        {
            if (_asteroids.Count == 0)
            {
                Generate();
            }
        }

        private void Generate()
        {
            _generatedAsteroids = 0;
            _timer.Start();
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            if (_generatedAsteroids < _quantidade)
            {
                Random random = new();
                int x;
                int y;
                do
                {
                    x = random.Next(GameScreen.MapWidth - Asteroid.Size);
                    y = random.Next(-100, -50);
                } while (IsPositionValid(x, y));

                AddAsteroid(new Asteroid(@"Images/48xAsteroide.ico", x, y));
                _generatedAsteroids++;
            }
            else
            {
                _timer.Stop();
            }
        }

        private bool IsPositionValid(int x, int y)
        {
            foreach (var obj in _asteroids)
            {
                if (obj.X + Asteroid.Size >= x &&
                    obj.X <= x + Asteroid.Size &&
                    obj.Y + Asteroid.Size >= y &&
                    obj.Y <= y + Asteroid.Size)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
