namespace Asteroids
{
    public sealed class Asteroid : Enemy
    {
        private float _speed;
        public void DependencyInjectHealth(Health hp, float speed)
        {
            Health = hp;
            _speed = speed;
        }
    }
}

