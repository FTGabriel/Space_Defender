using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace SpaceDefender.Core
{
    public class ScoreCalculator
    {
        private int _baseScore = 10;
        private float _multiplier = 1.0f;

        public int Calculate(int kills, int time)
        {
            if (time == 0)
                return 0;

            return (int)(kills * _baseScore * _multiplier);
        }

        public void ApplyCombo(int combo)
        {
            if (combo > 1)
                _multiplier += combo * 0.1f;
        }

        public void ResetMultiplier()
        {
            _multiplier = 1.0f;
        }
    }
}