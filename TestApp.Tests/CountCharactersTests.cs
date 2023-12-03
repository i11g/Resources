using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.IO;

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
        List<string> input=new() { };

        // Act
        string result= CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() {"c"};

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo("c -> 1"));
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {  
        //Arrange
        List<string> input = new List<string> { "text text text" };
        string expected = "t -> 6\r\ne -> 3\r\nx -> 3\r\n  -> 2";
        //Act
        string result=CountCharacters.Count(input);
        //Assert
        Assert.AreEqual(expected, result);

    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        //Arrange
        List<string> input = new List<string> { "@%&" };
        string expected = "@ -> 1\r\n% -> 1\r\n& -> 1";
        //Act
        string result = CountCharacters.Count(input);
        //Assert
        Assert.AreEqual(expected, result);

    }
}
