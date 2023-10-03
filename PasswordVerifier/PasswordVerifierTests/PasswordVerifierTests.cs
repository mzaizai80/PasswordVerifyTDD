using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordVerifier;
using System;

namespace PasswordVerifier.Tests
{
    [TestClass]
    public class PasswordVerifierTests
    {
        [TestMethod]
        public void Verify_PasswordIsValid_ReturnsTrue()
        {
            // Arrange
            var passwordVerifier = new PasswordVerifierEngine();

            // Act
            bool result = passwordVerifier.Verify("ValidPassword123");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Verify_PasswordIsNull_ThrowsArgumentException()
        {
            // Arrange
            var passwordVerifier = new PasswordVerifierEngine();

            // Act
            passwordVerifier.Verify(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Verify_PasswordIsTooShort_ThrowsArgumentException()
        {
            // Arrange
            var passwordVerifier = new PasswordVerifierEngine();

            // Act
            passwordVerifier.Verify("Short");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Verify_PasswordDoesNotContainUpperCase_ThrowsArgumentException()
        {
            // Arrange
            var passwordVerifier = new PasswordVerifierEngine();

            // Act
            passwordVerifier.Verify("nouppercase123");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Verify_PasswordDoesNotContainLowerCase_ThrowsArgumentException()
        {
            // Arrange
            var passwordVerifier = new PasswordVerifierEngine();

            // Act
            passwordVerifier.Verify("NOLOWERCASE123");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Verify_PasswordDoesNotContainNumber_ThrowsArgumentException()
        {
            // Arrange
            var passwordVerifier = new PasswordVerifierEngine();

            // Act
            passwordVerifier.Verify("NoNumberLowercase");
        }
    }
}




//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using PasswordVerifier;

//namespace PasswordVerifierTests
//{
//    [TestClass]
//    public class PasswordVerifierTests
//    {
//        [TestMethod]
//        public void Test()
//        {
//            // Arrange



//            // Act

//            // Assert

//        }
//    }
//}
