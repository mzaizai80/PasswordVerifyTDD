using System;
using System.Linq;
using System.Text;

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

            if (isLongEnough && hasUpperCase && hasLowerCase && hasNumber)
            {
                return true;
            }

            StringBuilder message = new StringBuilder("Password should meet the following conditions: ");

            if (!isLongEnough)
                message.Append("length > 8, ");
            if (!hasUpperCase)
                message.Append("at least one uppercase letter, ");
            if (!hasLowerCase)
                message.Append("at least one lowercase letter, ");
            if (!hasNumber)
                message.Append("at least one number, ");

            throw new ArgumentException(message.ToString().TrimEnd(',', ' '));
        }

    }

}