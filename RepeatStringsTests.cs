using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class RepeatStringsTests
{
    [Test]
    public void Test_Repeat_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        // Act
        string result = RepeatStrings.Repeat(input);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_Repeat_SingleInputString_ReturnsRepeatedString()
    {
        // Arrange
        string[] input = new [] {"baba"};

        // Act
        string result = RepeatStrings.Repeat(input);

        // Assert
        Assert.That(result, Is.EqualTo("babababababababa"));
    }

    [Test]
    public void Test_Repeat_MultipleInputStrings_ReturnsConcatenatedRepeatedStrings()
    {
        // Arrange
        string[] input = new[] { "baba", "ba","ba", "baba" };

        // Act
        string result = RepeatStrings.Repeat(input);

        // Assert
        Assert.That(result, Is.EqualTo("babababababababababababababababababababa"));
    }
}
