using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using SpaceDefender.Core;

// Assets/Tests/EditMode/ScoreCalculatorTests.cs

[TestFixture]
public class ScoreCalculatorTests
{
    private ScoreCalculator _scoreCalculator;

    [SetUp]
    public void SetUp()
    {
        _scoreCalculator = new ScoreCalculator();
    }

    [Test]
    public void Calculate_WithZeroKills_ReturnsZero()
    {
        int kills = 0;
        int time = 60;

        int score = _scoreCalculator.Calculate(kills, time);

        Assert.AreEqual(0, score);
    }

    [Test]
    public void ApplyCombo_With3Kills_IncreasesMultiplier()
    {
        int kills = 3;

        _scoreCalculator.ApplyCombo(kills);

        int score = _scoreCalculator.Calculate(1, 60);

        Assert.Greater(score, 10);
    }

    [Test]
    public void ResetMultiplier_AfterCombo_SetsMultiplierToOne()
    {
        _scoreCalculator.ApplyCombo(3);

        _scoreCalculator.ResetMultiplier();
        int score = _scoreCalculator.Calculate(1, 60);

        Assert.AreEqual(10, score);
    }

    [Test]
    public void Calculate_AfterComboAndReset_UsesBaseMultiplier()
    {
        _scoreCalculator.ApplyCombo(3);
        _scoreCalculator.ResetMultiplier();

        int score = _scoreCalculator.Calculate(2, 60);

        Assert.AreEqual(20, score);
    }

    //Tests bonus
    /*[Test]
    public void Calculate_WhenTimeEqualsZero_ReturnsValidScore()
    {
        int kills = 5;
        int time = 0;

        int score = _scoreCalculator.Calculate(kills, time);

        Assert.AreEqual(0, score);
    }*/
}