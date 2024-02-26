using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();
        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[] {"apple 5.97 1", "banana 3.75 1",  "orange 1.98 1"};
        //Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 5.97{Environment.NewLine}banana -> 3.75{Environment.NewLine}orange -> 1.98"));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[] { "apple 0.50 1", "banana 0.75000000 2", "banana 0.75000000 3", "orange 0.989999 2", "apple 1.999 2" };
        string result = Orders.Order(input);

        Assert.That(result, Is.EqualTo($"apple -> 6.00{Environment.NewLine}banana -> 3.75{Environment.NewLine}orange -> 1.98"));
    }
    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[] { "apple 2.00 4.5", "banana 3.00 2.5", "orange 1.00 3.5", };
        string result = Orders.Order(input);

        Assert.That(result, Is.EqualTo($"apple -> 9.00{Environment.NewLine}banana -> 7.50{Environment.NewLine}orange -> 3.50"));
    }

}