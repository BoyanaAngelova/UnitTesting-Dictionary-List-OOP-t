using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class NumberFrequencyTests
{
    [Test]
    public void Test_CountDigits_ZeroNumber_ReturnsEmptyDictionary()
    {
        // Arrange
        int number = 0;

        //
       Dictionary<int, int> result = NumberFrequency.CountDigits(number);
        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_CountDigits_SingleDigitNumber_ReturnsDictionaryWithSingleEntry()
    {
        // Arrange
        int number = 1;

        //Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);
        //Assert
        Assert.AreEqual(1, result.Count);


    }

    [Test]
    public void Test_CountDigits_MultipleDigitNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int number = 11111;

        //Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);
        //Assert
        Assert.AreEqual(1, result.Count);
        Assert.AreEqual(5, result[1]);

    }

    [Test]
    public void Test_CountDigits_NegativeNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int number = -11111;

        //Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);
        //Assert
        Assert.AreEqual(1, result.Count);
        Assert.IsTrue(result.ContainsKey(1));  
        Assert.AreEqual(5, result[1]);

    }
}
