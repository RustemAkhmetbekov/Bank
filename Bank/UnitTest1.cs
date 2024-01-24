using NUnit.Framework;

namespace Bank
{
    public class Tests
    {
        private CheckingAccount account;

        [SetUp]
        public void Setup()
        {
            account = new CheckingAccount(123456, "Test Owner", 1000);
        }

        [Test]
        public void MaxConsecutiveLettersReturnsCorrectValue()
        {
            // Arrange
            string input1 = "AAABBBCCCD";
            string input2 = "AABBCCDD";
            string input3 = "A";
            string input4 = "";

            // Act
            int result1 = account.MaxConsecutiveLetters(input1);
            int result2 = account.MaxConsecutiveLetters(input2);
            int result3 = account.MaxConsecutiveLetters(input3);
            int result4 = account.MaxConsecutiveLetters(input4);

            // Assert
            Assert.That(result1, Is.EqualTo(3)); // AAA, BBB, CCC
            Assert.That(result2, Is.EqualTo(2)); // AA, BB
            Assert.That(result3, Is.EqualTo(1)); // Single letter
            Assert.That(result4, Is.EqualTo(0)); // Empty string
        }

        [Test]
        public void MaxConsecutiveDigitsReturnsCorrectValue()
        {
            // Arrange
            string input1 = "123444555";
            string input2 = "11223344";
            string input3 = "1";
            string input4 = "";

            // Act
            int result1 = account.MaxConsecutiveDigits(input1);
            int result2 = account.MaxConsecutiveDigits(input2);
            int result3 = account.MaxConsecutiveDigits(input3);
            int result4 = account.MaxConsecutiveDigits(input4);

            // Assert
            Assert.That(result1, Is.EqualTo(3)); // 444, 555
            Assert.That(result2, Is.EqualTo(2)); // 11, 22
            Assert.That(result3, Is.EqualTo(1)); // Single digit
            Assert.That(result4, Is.EqualTo(0)); // Empty string
        }
    }
}