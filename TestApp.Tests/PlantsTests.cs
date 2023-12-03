using NUnit.Framework;

using System;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        //Arrange
        string[] input=Array.Empty<string>();
        //Act
        string result=Plants.GetFastestGrowing(input);
        //Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] plants = { "tulip" };

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo("Plants with 5 letters:\r\ntulip"));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        string[] plants = { "tulips", "orchidea", "mango" };
        string expected = "Plants with 5 letters:\r\nmango\r\nPlants with 6 letters:\r\ntulips\r\nPlants with 8 letters:\r\norchidea";

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] plants = { "Tulips", "oRchidea", "mANgo" };
        string expected = "Plants with 5 letters:\r\nmANgo\r\nPlants with 6 letters:\r\nTulips\r\nPlants with 8 letters:\r\noRchidea";

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
