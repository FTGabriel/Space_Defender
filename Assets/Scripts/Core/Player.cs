using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace SpaceDefender.Core
{
    public class Player
    {
        public int Health { get; private set; } = 100;
        public int Lives { get; private set; } = 3;
        public int Score { get; private set; } = 0;
        public bool IsAlive => Health > 0 && Lives > 0;

        public void TakeDamage(int amount)
        {
            // TODO : implementer la logique
            // RAPPEL : Health ne peut pas etre negatif
        }

        public void Heal(int amount) {
            /* TODO : Health max = 100 */ 
            Health -= amount;

            if (Health < 0)
                Health = 0;
        }

        public void AddScore(int points) { /* TODO */ }
        public void LoseLife() { /* TODO */ }
    }
}