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
    /*public void TakeDamage_WhenDamageIsNegative_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => _player.TakeDamage(-10));
    }*/
    public void TakeDamage_WithNegativeAmount_DoesNotChangeHealth()
    {
        int initialHealth = _player.Health;

        _player.TakeDamage(-10);

        Assert.AreEqual(initialHealth, _player.Health);
    }

    // RED: - Heal normal
    [Test]
    //public void Heal_Normal_IncreaseHealth()
    public void Heal_WhenHealthBelow100_IncreasesHealth()
    {
        _player.TakeDamage(50);

        _player.Heal(30);

        Assert.AreEqual(80, _player.Health);
    }

    // RED: Heal exceeds max
    [Test]
    /*public void Heal_WhenHealExceedsHealth_SetsHealthToOneHundred()
    {
        _player.TakeDamage(30);
        _player.Heal(50);
        Assert.AreEqual(100, _player.Health);
    }*/
    public void Heal_WhenAlreadyFullHealth_DoesNotExceed100()
    {
        int initialHealth = _player.Health;

        _player.Heal(50);

        Assert.AreEqual(initialHealth, _player.Health);
    }

    // RED: IsAlive
    [Test]
    public void IsAlive_WhenHealthAboveZero_ReturnsTrue()
    {
        _player.TakeDamage(20);

        bool alive = _player.IsAlive;

        Assert.IsTrue(alive);
    }

    [Test]
    /* public void IsAlive_HealthEqualsZero_ReturnsFalse()
     {
         _player.TakeDamage(100);
         Assert.IsFalse(_player.IsAlive);
     }*/
    public void IsAlive_WhenHealthIsZero_ReturnsFalse()
    {
        _player.TakeDamage(100);

        bool alive = _player.IsAlive;

        Assert.IsFalse(alive);
    }

    // RED: LoseLife
    [Test]
    public void LoseLife_WhenLivesExceedsZero_ReducesLives()
    {
        _player.LoseLife();
        Assert.AreEqual(2, _player.Lives);
    }

    [Test]
    /*public void LoseLife_WhenLivesEqualsZero_IsAliveIsFalse()
    {
        _player.LoseLife();
        _player.LoseLife();
        _player.LoseLife();
        Assert.IsFalse(_player.IsAlive);
    }*/
    public void LoseLife_WhenLastLife_IsAliveReturnsFalse()
    {
        _player.LoseLife();
        _player.LoseLife();
        _player.LoseLife();

        bool alive = _player.IsAlive;

        Assert.IsFalse(alive);
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

    //Tests bonus
    [Test]
    public void Heal_WhenPlayerIsDead_DoesNotRestoreHealth()
    {
        _player.TakeDamage(100);
        _player.Heal(50);
        Assert.AreEqual(0, _player.Health);
    }
}