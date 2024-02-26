using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class BankAccountTests
{
    [Test]
    public void Test_Constructor_InitialBalanceIsSet()
    {
        // Arrange
        double initialBalance = 200;
        //Act
        BankAccount account = new BankAccount(initialBalance);
        //Assert
        Assert.AreEqual(account.Balance, initialBalance);


    }

    [Test]
    public void Test_Deposit_PositiveAmount_IncreasesBalance()
    {
        //Arrange
        double initialBalance = 200;
        double amount = 20;
        double expected = 220;
        //Act
        BankAccount account = new BankAccount(initialBalance);
        account.Deposit (amount);
        //Assert
        Assert.AreEqual(expected, account.Balance);
    }

    [Test]
    public void Test_Deposit_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        double initialBalance = 200;
        double deposit = -50;
        BankAccount account = new BankAccount(initialBalance);
        //Act & Assert
        Assert.That(() => account.Deposit(deposit), Throws.ArgumentException);

    }

    [Test]
    public void Test_Withdraw_ValidAmount_DecreasesBalance()
    {
        // Arrange
        double initialBalance = 200;
        double withdrawAmount= 20;
        double expected = 180;
        BankAccount account = new BankAccount(initialBalance);
        //Act
        account.Withdraw(withdrawAmount);
        //Assert
        Assert.AreEqual(expected, account.Balance); ;
    }

    [Test]
    public void Test_Withdraw_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        double initialBalance = 200;
        double withdraw = -50;
        BankAccount account = new BankAccount(initialBalance);
        //Act & Assert
        Assert.That(() => account.Withdraw(withdraw), Throws.ArgumentException);

    }

    [Test]
    public void Test_Withdraw_AmountGreaterThanBalance_ThrowsArgumentException()
    {
        // Arrange
        double initialBalance = 200;
        double withdraw = -250;
        BankAccount account = new BankAccount(initialBalance);
        //Act & Assert
        Assert.That(() => account.Withdraw(withdraw), Throws.ArgumentException);
    }
}
