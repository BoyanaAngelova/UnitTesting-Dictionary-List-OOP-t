using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class GroupingTests
{
    
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> input = new() { };

        // Act
        string result = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new List<int>() { 2, 4, 5, 7 };
        //Act 
        string result = Grouping.GroupNumbers(input);
        //Assert
        Assert.That(result, Is.EqualTo($"Even numbers: 2, 4{Environment.NewLine}Odd numbers: 5, 7"));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        //Arrange
        List<int> input = new List<int> { 2, 4, 6 };
        //Act
        string result = Grouping.GroupNumbers(input);
        //Assert
        Assert.That(result, Is.EqualTo("Even numbers: 2, 4, 6"));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        //Arrange
        List<int> input = new List<int> { 1, 3, 5 };
        //Act
        string result = Grouping.GroupNumbers(input);
        //Assert
        Assert.That(result, Is.EqualTo("Odd numbers: 1, 3, 5"));

    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        //Arrange
        List<int> input = new List<int> { -2, -4, -6, -7, -9};
        //Act
        string result = Grouping.GroupNumbers(input);
        //Assert
        Assert.That(result, Is.EqualTo($"Even numbers: -2, -4, -6{Environment.NewLine}Odd numbers: -7, -9"));
    }
}
