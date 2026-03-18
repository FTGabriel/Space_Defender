using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using SpaceDefender.Core;

// Assets/Tests/EditMode/EnemyTests.cs

[TestFixture]
public class EnemyTests
{
    private Enemy _enemy;

    [SetUp]
    public void SetUp()
    {
        _enemy = new Enemy();   // Arrange — initialisation
    }

    [Test]
    public void TakeDamage_WhenKilled_SetsIsAliveToFalse()
    {
        _enemy.TakeDamage(100);

        bool alive = _enemy.IsAlive;

        Assert.IsFalse(alive);
    }

    [Test]
    public void GetReward_WhenAlreadyDead_ReturnsZero()
    {
        _enemy.TakeDamage(100);

        int reward = _enemy.GetReward();

        Assert.AreEqual(0, reward);
    }

    //Tests bonus
    /*[Test]
    public void TakeDamage_WhenEnemyIsAlreadyDead_DoesNotChangeHealth()
    {
        _enemy.TakeDamage(100);

        _enemy.TakeDamage(50);

        Assert.AreEqual(0, _enemy.Health);
    }*/
}