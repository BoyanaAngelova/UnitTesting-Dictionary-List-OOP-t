﻿using NUnit.Framework;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

  
    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new() { "", "", "" };
        // Act
        string result = CountCharacters.Count(input);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        //Arrange
        List<string> input = new() { "a" };
        //Act
        string result = CountCharacters.Count(input);
        //Assert
        Assert.That(result, Is.EqualTo("a -> 1"));
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {

        //Arrange
        List<string> input = new() { "aa", "aabb", "ccc" };
        StringBuilder sb = new();
        sb.AppendLine("a -> 4");
        sb.AppendLine("b -> 2");
        sb.AppendLine("c -> 3");
        string expected = sb.ToString().Trim();
        //Act
        string result = CountCharacters.Count(input);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        //Arrange
        List<string> input = new() { "aa", "aabbcc%", };
        StringBuilder sb = new();
        sb.AppendLine("a -> 4");
        sb.AppendLine("b -> 2");
        sb.AppendLine("c -> 2");
        sb.AppendLine("% -> 1");
       


        string expected = sb.ToString().Trim();
        //Act
        string result = CountCharacters.Count(input);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
