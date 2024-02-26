using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    
    [TestCase("aba_mail@softuni.bg")]
    [TestCase("aba.mail@abv.bg")]
    [TestCase("aba+123@gmail.com")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

  
    [TestCase("blabla.blala.com")]
    [TestCase("bla%bla@%com")]
    [TestCase(" blaba@mail.domein")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}
