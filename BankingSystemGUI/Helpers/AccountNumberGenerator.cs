// Helpers/AccountNumberGenerator.cs
using System;

namespace BankingSystemGUI.Helpers
{
    public static class AccountNumberGenerator
    {
        private static readonly Random Random = new Random();

        public static string GenerateAccountNumber(string prefix)
        {
            // Generate a random 8-digit number
            int randomNumber = Random.Next(10000000, 99999999);
            
            // Combine prefix with random number
            return $"{prefix}{randomNumber}";
        }
    }
}