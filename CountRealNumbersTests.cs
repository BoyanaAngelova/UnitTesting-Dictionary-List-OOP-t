using NUnit.Framework;

using System;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    // TODO: finish test
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        int[] nums = Array.Empty<int>();
        // Act
        string result = CountRealNumbers.Count(nums);
        // Assert
        Assert.That(result, Is.EqualTo(""));
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        
            // Arrange
            int[] nums = new int[] { 1 };
            // Act
            string result = CountRealNumbers.Count(nums);
            // Assert
            Assert.That(result, Is.EqualTo("1 -> 1"));
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        //Arrange
        int[] nums = new int[] { 1, 2, 3, 3, 3, 4, 4 };
       //Act
        string result = CountRealNumbers.Count(nums);
        //Assert
        Assert.That(result, Is.EqualTo("1 -> 1\r\n2 -> 1\r\n3 -> 3\r\n4 -> 2"));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        //Arrange
        int[] nums = new int[] { -1, -2, -3, };
        //Act
        string result = CountRealNumbers.Count(nums);
        //Assert
        Assert.That(result, Is.EqualTo("-3 -> 1\r\n-2 -> 1\r\n-1 -> 1"));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        //Arrange
        int[] nums = new int[] { 0, 0, 0, 0, 0 };
        //Act
        string result = CountRealNumbers.Count(nums);
        //Assert
        Assert.That(result, Is.EqualTo("0 -> 5"));
    }
}
