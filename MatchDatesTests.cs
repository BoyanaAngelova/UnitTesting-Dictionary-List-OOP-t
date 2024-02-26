using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchDatesTests
{
    // TODO: finish the test
    [Test]
    public void Test_Match_ValidDate_ReturnsExpectedResult()
    {
        // Arrange
        string input = "31-Dec-2022 random text";
        string expected = "Day: 31, Month: Dec, Year: 2022";

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish the test
    [Test]
    public void Test_Match_NoMatch_ReturnsEmptyString()
    {
        // Arrange
        string input = "30/12/25";
        string expected = string.Empty;

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Match_MultipleMatches_ReturnsFirstMatch()
    {
        // Arrange
        string input = "12.Jan.2023 31-Dec-2023";
        string expected = "Day: 12, Month: Jan, Year: 2023";

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;
        string expected = string.Empty;

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Match_NullInput_ThrowsArgumentException()
    {
        string input = null;
        string expected = string.Empty;
        Assert.That(() => MatchDates.Match(input), Throws.ArgumentException);
    }
}
