using System;

namespace PasswordVerifier
{
    class Program
    {
        static void Main(string[] args)
        {
            var passwordVerifier = new PasswordVerifierEngine();

            while (true)
            {
                Console.WriteLine("Please enter a Password");
                var userInputPassword = Console.ReadLine();

                try
                {
                    passwordVerifier.Verify(userInputPassword);
                    Console.WriteLine("Password accepted");
                    break; // Exit the loop when a valid password is provided
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Password rejected: " + ex.Message);
                }
            }
        }
    }
}