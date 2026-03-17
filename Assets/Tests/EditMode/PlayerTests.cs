using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using SpaceDefender.Core;
using System;

// Assets/Tests/EditMode/PlayerTests.cs

[TestFixture]
public class PlayerTests
{
    private Player _player;

    [SetUp]
    public void SetUp()
    {
        _player = new Player();   // Arrange — initialisation
    }

    // RED: — test normal TakeDamage
    [Test]
    public void TakeDamage_Normal_ReducesHealth()
    {
        int damage = 20;

        _player.TakeDamage(damage);

        Assert.AreEqual(80, _player.Health);
    }

    // RED: — test TakeDamage exceeds the health
    [Test]
    public void TakeDamage_WhenDamageExceedsHealth_SetsHealthToZero()
    {
        int damage = 200;

        _player.TakeDamage(damage);

        Assert.AreEqual(0, _player.Health);
    }

    // RED: — test TakeDamage is negative (error)
    [Test]
    public void TakeDamage_WhenDamageIsNegative_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => _player.TakeDamage(-10));
    }

    // RED: - Heal normal
    [Test]
    public void Heal_Normal_IncreaseHealth()
    {
        _player.TakeDamage(50);
        _player.Heal(30);
        Assert.AreEqual(80, _player.Health);
    }

    // RED: Heal exceeds max
    [Test]
    public void Heal_WhenHealExceedsHealth_SetsHealthToOneHundred()
    {
        _player.Heal(50);
        Assert.AreEqual(100, _player.Health);
    }

    // RED: IsAlive
    [Test]
    public void IsAlive_WhenHealthAboveZero_ReturnsTrue()
    {
        Assert.IsTrue(_player.IsAlive);
    }

    [Test]
    public void IsAlive_HealthEqualsZero_ReturnsFalse()
    {
        _player.TakeDamage(100);
        Assert.IsFalse(_player.IsAlive);
    }

    // RED: LoseLife
    [Test]
    public void LoseLife_WhenLivesExceedsZero_ReducesLives()
    {
        _player.LoseLife();
        Assert.AreEqual(2, _player.Lives);
    }

    [Test]
    public void LoseLife_WhenLivesEqualsZero_IsAliveIsFalse()
    {
        _player.LoseLife();
        _player.LoseLife();
        _player.LoseLife();
        Assert.IsFalse(_player.IsAlive);
    }

    // RED: AddScore
    [Test]
    public void AddScore_PointsArePositives_IncreaseScore()
    {
        _player.AddScore(50);
        Assert.AreEqual(50, _player.Score);
    }

    [Test]
    public void AddScore_PointsAreNegatives_DoesNotChangeScore()
    {
        Assert.Throws<ArgumentException>(() => _player.AddScore(-10));
    }
}