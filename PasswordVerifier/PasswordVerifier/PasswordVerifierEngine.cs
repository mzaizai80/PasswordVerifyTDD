using System;
using System.Linq;

namespace PasswordVerifier
{
    public class PasswordVerifierEngine
    {
        public bool Verify(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Password cannot be null or empty.");

            bool isLongEnough = password.Length > 8;
            bool hasUpperCase = password.Any(char.IsUpper);
            bool hasLowerCase = password.Any(char.IsLower);
            bool hasNumber = password.Any(char.IsDigit);

            int conditionsMet = Convert.ToInt32(isLongEnough) +
                                Convert.ToInt32(hasUpperCase) +
                                Convert.ToInt32(hasLowerCase) +
                                Convert.ToInt32(hasNumber);

            if (conditionsMet < 3)
                throw new ArgumentException("Password should meet at least three conditions.");

            if (!hasNumber || !hasLowerCase || !hasUpperCase)
                throw new ArgumentException("Password should have at least one uppercase letter, one lowercase letter, and one number.");

            return true;
        }
    }

}