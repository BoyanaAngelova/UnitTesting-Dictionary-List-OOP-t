using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;

namespace TestApp.Tests;

public class MinerTests
{
    [Test]
    public void Test_Mine_WithEmptyInput_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();
        //Act
        string  result = Miner.Mine(input);
        //Assert
        Assert.That(result, Is.Empty);
    }

    
    [Test]
    public void Test_Mine_WithMixedCaseResources_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = new string[] { "Gold 8", "silveR 30" };

        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.That(result, Is.EqualTo($"gold -> 8{Environment.NewLine}silver -> 30"));
    }

    [Test]
    public void Test_Mine_WithDifferentResources_ShouldReturnResourceCounts()
    {
        // Arrange
        string[] input = { "gold 8", "silver 30", "cooper 100", "golD 10", "silver 10" };

        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.That(result, Is.EqualTo($"gold -> 18{Environment.NewLine}silver -> 40{ Environment.NewLine}cooper -> 100"));
    }
}
