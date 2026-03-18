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
            if (amount < 0)
                return;

            if (!IsAlive)
                return;

            Health -= amount;

            if (Health < 0)
                Health = 0;
        }

        public void Heal(int amount) {
            if (amount < 0)
                return;

            if (!IsAlive)
                return;

            Health += amount;

            if (Health > 100)
                Health = 100;
        }
        public void AddScore(int points) {
            if (points < 0)
                throw new System.ArgumentException("Score cannot be negative");

            Score += points;
        }
        public void LoseLife() {
            if (Lives <= 0)
                return;

            Lives--;

            if (Lives > 0)
            {
                Health = 100;
            }
            else
            {
                Health = 0;
            }
        }
    }
}