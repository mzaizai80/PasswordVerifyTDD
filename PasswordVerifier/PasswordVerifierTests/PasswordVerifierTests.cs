using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordVerifier;

namespace PasswordVerifierTests
{
    [TestClass]
    public class PasswordVerifierTests
    {
        [TestMethod]
        public void TestPasswordShouldBeLargerThan8chars()
        {
            var passwordVerifier = new PasswordVerifierEngine();

            var passwordVerified = passwordVerifier.Verify("qwer1234");
        }
    }
}
