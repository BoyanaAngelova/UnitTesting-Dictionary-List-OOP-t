using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;
using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Reflection;

namespace TestApp.UnitTests;

public class ExceptionTests
{
    private Exceptions _exceptions = null!;

    [SetUp]
    public void SetUp()
    {
        this._exceptions = new();
    }

   //1
    [Test]
    public void Test_Reverse_ValidString_ReturnsReversedString()
    {
        // Arrange
        string input = "hello";
        string expected = "olleh";

        // Act
        string result = this._exceptions.ArgumentNullReverse(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Reverse_NullString_ThrowsArgumentNullException()
    {
        // Arrange
        string input = null;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentNullReverse(input), Throws.ArgumentNullException);
    }
    //2
    [Test]
    public void Test_CalculateDiscount_ValidInput_ReturnsDiscountedPrice()
    {
        //Arrange
        decimal totalPrice = 100.0m;
        decimal discount = 10.0m;
        //Act
        decimal result = this._exceptions.ArgumentCalculateDiscount(totalPrice, discount);

        //Assett
        Assert.That(result, Is.EqualTo(90.00m));
    }

    // TODO: finish test
    [Test]
    public void Test_CalculateDiscount_NegativeDiscount_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 100.0m;
        decimal discount = -10.0m;
        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }

    // TODO: finish test
    [Test]
    public void Test_CalculateDiscount_DiscountOver100_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 100.0m;
        decimal discount = 110.0m;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }
//3
    [Test]
    public void Test_GetElement_ValidIndex_ReturnsElement()
    {
        //Arrange
        int[] array = new[] { 1, 2, 3 };
        int index = 1;
        //Act
        int result = this._exceptions.IndexOutOfRangeGetElement(array, index);
        //Assert
        Assert.That(result, Is.EqualTo(2));
        
    }

    // TODO: finish test
    [Test]
    public void Test_GetElement_IndexLessThanZero_ThrowsIndexOutOfRangeException()
    {
        //Arrange
        int[] array = new[] { 1, 2, 3 };
        int index = -1;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    // TODO: finish test
    [Test]
    public void Test_GetElement_IndexEqualToArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElement_IndexGreaterThanArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length + 2;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }
//4
    [Test]
    public void Test_PerformSecureOperation_UserLoggedIn_ReturnsUserLoggedInMessage()
    {
        //Arrange
        bool isLogegdIn = true;


        //Act
        string result = this._exceptions.InvalidOperationPerformSecureOperation(isLogegdIn);

        //Assert
        Assert.That(result, Is.EqualTo("User logged in."));

    }

    [Test]
    public void Test_PerformSecureOperation_UserNotLoggedIn_ThrowsInvalidOperationException()
    {
        //Arrange
        bool isLogegdIn = false;

        //Act & Assert
        Assert.That(() => this._exceptions.InvalidOperationPerformSecureOperation(isLogegdIn), Throws.InstanceOf<InvalidOperationException>());
    }
//5
    [Test]
    public void Test_ParseInt_ValidInput_ReturnsParsedInteger()
    {
        //Arrange
        string input = "2";
        //Act
        int result = this._exceptions.FormatExceptionParseInt(input);

        //Assert
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void Test_ParseInt_InvalidInput_ThrowsFormatException()
    {
        ///Arrange
        string input = "2, abc";

        //Act & Assert
        Assert.That(() => this._exceptions.FormatExceptionParseInt(input), Throws.InstanceOf<FormatException>());
        
    }
//6
    [Test]
    public void Test_FindValueByKey_KeyExistsInDictionary_ReturnsValue()
    {
        //Arrange
        Dictionary<string, int> dictionary = new()
        {
            ["first"] = 10,
            ["secong"] = 15,
            ["third"] = 20
        };
        string key = "secong";
        //Act
        int result = this._exceptions.KeyNotFoundFindValueByKey(dictionary, key);
        //Assert
        Assert.That(result, Is.EqualTo(15));
    }

    [Test]
    public void Test_FindValueByKey_KeyDoesNotExistInDictionary_ThrowsKeyNotFoundException()
    {
        // Arrange
        Dictionary<string, int> dictionary = new()
        {
            ["first"] = 10,
            ["third"] = 20
        };
        string key = "second";
        //Action & Assert
        Assert.That(() => this._exceptions.KeyNotFoundFindValueByKey(dictionary, key), Throws.InstanceOf<KeyNotFoundException>());
    }
//7
    [Test]
    public void Test_AddNumbers_NoOverflow_ReturnsSum()
    {
        // Arrange
        int a = 2;
        int b = 3;

        //Act
        int result = this._exceptions.OverflowAddNumbers(a, b);

        //Assert
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Test_AddNumbers_PositiveOverflow_ThrowsOverflowException()
    {
        // Arrange
        int a = int.MaxValue;
        int b = 1;

        //Act & Assert
        Assert.That(() => this._exceptions.OverflowAddNumbers(a, b), Throws.InstanceOf<OverflowException>());

    }

    [Test]
    public void Test_AddNumbers_NegativeOverflow_ThrowsOverflowException()
    {
        // Arrange
        int a = int.MinValue;
        int b = -1;

        //Act & Assert
        Assert.That(() => this._exceptions.OverflowAddNumbers(a, b), Throws.InstanceOf<OverflowException>());
    }

 //8
    [Test]
    public void Test_DivideNumbers_ValidDivision_ReturnsQuotient()
    {
        //Arrange
        int dividend = 20;
        int divisor = 2;
        //Act
        int result = this._exceptions.DivideByZeroDivideNumbers(dividend, divisor);
        //Assert
        Assert.That(result, Is.EqualTo(10));

    }

    [Test]
    public void Test_DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
    {
        //Arrange
        int dividend = 20;
        int divisor = 0;
        //Act
        //Assert
        Assert.That(() => this._exceptions.DivideByZeroDivideNumbers(dividend, divisor), Throws.InstanceOf<DivideByZeroException>());
       
    }
 //9
    [Test]
    public void Test_SumCollectionElements_ValidCollectionAndIndex_ReturnsSum()
    {
        // Arrange
        int[] collection = { 1, 2, 3};
        int index = 2;
            //Act
            int result = this._exceptions.SumCollectionElements(collection, index);

            //Assert
            Assert.That(result, Is.EqualTo(6));
    }

    [Test]
    public void Test_SumCollectionElements_NullCollection_ThrowsArgumentNullException()
    {
        // Arrange
        int[] collection = null;
        int index = 2;
        //Act & Assert
        Assert.That(() => this._exceptions.SumCollectionElements(collection, index), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_SumCollectionElements_IndexOutOfRange_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] collection = { 1, 2, 3 };
        int index = 5;
        //Act & Assert
        Assert.That(() => this._exceptions.SumCollectionElements(collection, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }
//10
    [Test]
    public void Test_GetElementAsNumber_ValidKey_ReturnsParsedNumber()
    {
        //Arrange
        Dictionary<string, string> dictionary = new()
        {
            ["first"] = "10",
            ["secong"] = "20",
            ["third"] = "30"
        };
        string key = "secong";
        //Act
        int result = this._exceptions.GetElementAsNumber(dictionary, key);
        //Assert
        Assert.That(result, Is.EqualTo(20));
    }

    [Test]
    public void Test_GetElementAsNumber_KeyNotFound_ThrowsKeyNotFoundException()
    {
        //Arrange
        Dictionary<string, string> dictionary = new()
        {
            ["first"] = "10",
            ["secong"] = "20",
            ["third"] = "30"
        };
        string key = "five";
        //Act
        //Assert
        Assert.That(() => this._exceptions.GetElementAsNumber(dictionary, key), Throws.InstanceOf<KeyNotFoundException>());
    }
        [Test]
    public void Test_GetElementAsNumber_InvalidFormat_ThrowsFormatException()
    {
        //Arrange
        Dictionary<string, string> dictionary = new()
        {
            ["first"] = "10aert",
            ["secong"] = "20e",
            ["third"] = "30koo"
        };
        string key = "first";
        //Act
        //Assert
        Assert.That(() => this._exceptions.GetElementAsNumber(dictionary, key), Throws.InstanceOf<FormatException>());
    }
}

