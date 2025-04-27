// Services/AuthService.cs
using System;
using BankingSystemGUI.Helpers;
using BankingSystemGUI.Models;

namespace BankingSystemGUI.Services
{
    public class AuthService
    {
        private readonly FileService _fileService;

        public AuthService()
        {
            _fileService = new FileService();
        }

        public BankAccount Login(string username, string password)
        {
            try
            {
                // Get user from file
                var user = _fileService.GetUserByUsername(username);
                
                if (user == null)
                {
                    return null; // User not found
                }

                // Verify password
                bool isPasswordValid = PasswordHelper.VerifyPassword(password, user.Password);
                
                if (!isPasswordValid)
                {
                    return null; // Invalid password
                }

                // Get bank account information
                var bankAccount = _fileService.GetBankAccountByUsername(username);
                
                return bankAccount;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Login error: {ex.Message}");
                return null;
            }
        }

        public bool Register(string username, string password, string firstName, string lastName)
        {
            try
            {
                // Check if username already exists
                var existingUser = _fileService.GetUserByUsername(username);
                
                if (existingUser != null)
                {
                    return false; // Username already exists
                }

                // Create password hash
                string passwordHash = PasswordHelper.HashPassword(password);

                // Create new user
                var user = new User
                {
                    Username = username,
                    Password = passwordHash,
                    FirstName = firstName,
                    LastName = lastName
                };

                // Generate account numbers using the helper class
                string checkingAccountNumber = AccountNumberGenerator.GenerateAccountNumber("CHK");
                string savingsAccountNumber = AccountNumberGenerator.GenerateAccountNumber("SAV");

                // Create bank account
                var bankAccount = new BankAccount
                {
                    Username = username,
                    FirstName = firstName,
                    LastName = lastName,
                    CheckingAccountNumber = checkingAccountNumber,
                    CheckingBalance = 0,
                    SavingsAccountNumber = savingsAccountNumber,
                    SavingsBalance = 0
                };

                // Save user and bank account to files
                _fileService.SaveUser(user);
                _fileService.SaveBankAccount(bankAccount);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Registration error: {ex.Message}");
                return false;
            }
        }
    }
}