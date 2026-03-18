using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace SpaceDefender.Core
{
    public class Enemy
    {
        public int Health { get; private set; } = 100;
        public int PointValue { get; private set; } = 10;

        public bool IsAlive => Health > 0;

        public void TakeDamage(int amount)
        {
            if (amount < 0)
                throw new System.ArgumentException("Damage cannot be negative");

            if (!IsAlive)
                return;

            Health -= amount;

            if (Health < 0)
                Health = 0;
        }

        public int GetReward()
        {
            if (!IsAlive)
                return 0;

            return PointValue;
        }
    }
}