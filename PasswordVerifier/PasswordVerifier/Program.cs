
using System;

namespace PasswordVerifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a Password");
            var userInputPassword = Console.ReadLine();
            var passwordVerifier = new PasswordVerifierEngine();

            try
            {
                passwordVerifier.Verify(userInputPassword);
                Console.WriteLine("Password accepted");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Password rejected: " + ex.Message);
            }
        }
    }
}


