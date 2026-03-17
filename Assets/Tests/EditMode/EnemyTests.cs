using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using SpaceDefender.Core;

// Assets/Tests/EditMode/PlayerTests.cs

[TestFixture]
public class EnemyTests
{
    private Player _player;

    [SetUp]
    public void SetUp()
    {
        _player = new Player();   // Arrange — initialisation
    }

    // ??? ETAPE 1 : RED — ce test doit echouer ???????????
    [Test]
    public void TakeDamage_Normal_ReducesHealth()
    {
        int damage = 20;

        _player.TakeDamage(damage);

        Assert.AreEqual(80, _player.Health);
    }
}