using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
       //Arrange
       string[] input=Array.Empty<string>();
        //Act
        string result = Orders.Order(input);
       //Assert
       Assert.That(result,Is.EqualTo(string.Empty));
    }

   
    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input =
        {
            "apple 2.99 2",
            "apple 2.99 1",
            "banana 1.25 1",
            "banana 1.25 2",
            "orange 1.99 2"
        };

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 8.97{Environment.NewLine}banana -> 3.75{Environment.NewLine}orange -> 3.98"));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input =
        {
            "apple 3.00 2",
            "banana 1.00 1",
            "banana 1.00 2",
            "orange 1.00 2"
        };

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 6.00{Environment.NewLine}banana -> 3.00{Environment.NewLine}orange -> 2.00"));
    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input =
        {
            "apple 3.00 2.5",
            "banana 1.00 1.3",
            "orange 1.00 0.2"
        };

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 7.50{Environment.NewLine}banana -> 1.30{Environment.NewLine}orange -> 0.20"));
    }
}

