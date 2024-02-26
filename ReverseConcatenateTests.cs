using NUnit.Framework;

using System;
using System.Linq;

namespace TestApp.UnitTests;

public class ReverseConcatenateTests
{
    // TODO: finish the test
    [Test]
    public void Test_ReverseAndConcatenateStrings_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish the test
    [Test]
    public void Test_ReverseAndConcatenateStrings_SingleString_ReturnsSameString()
    {
        // Arrange
        string[] input = new[] { "alabala" };
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(result, Is.EqualTo("alabala"));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_MultipleStrings_ReturnsReversedConcatenatedString()
    {
        // Arrange
        string[] input = new[] { "alabala", "123", "abc" };
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(result, Is.EqualTo("abc123alabala"));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_NullInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = null;

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_WhitespaceInput_ReturnsConcatenatedString()
    {
        // Arrange
        string[] input = new[] { " ", "   ", "  " };
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(result, Is.EqualTo("      "));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_LargeInput_ReturnsReversedConcatenatedString()
    {
        // Arrange
        string[] input = new[] { "alabala", "123", "abc", "alabala", "123", "abc", "alabala", "123", "abc" };
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(result, Is.EqualTo("abc123alabalaabc123alabalaabc123alabala"));
    }
}
