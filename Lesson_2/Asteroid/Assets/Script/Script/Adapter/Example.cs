using UnityEngine;

namespace Asteroids.Bridge
{
    internal sealed class Example1 : MonoBehaviour
    {
        private void Start()
        {
            var enemy = new Enemy(new MagicalAttack(), new Infantry());
        }
    }
}

