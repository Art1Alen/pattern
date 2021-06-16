namespace Asteroids.Prototype
{
    internal sealed class Hp
    {
        public float MaxHP;
        public float CurrentHP;

        public override string ToString()
        {
            return $"MaxHP {MaxHP} CurrentHP {CurrentHP}";
        }
    }
}