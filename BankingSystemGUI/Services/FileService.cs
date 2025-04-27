using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using BankingSystemGUI.Models;

namespace BankingSystemGUI.Services
{
    public class FileService
    {
        private readonly string _accountLoginsPath;
        private readonly string _bankInfoPath;

        public FileService()
        {
            // Create the Data directory if it doesn't exist
            string dataDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            if (!Directory.Exists(dataDirectory))
            {
                Directory.CreateDirectory(dataDirectory);
            }

            _accountLoginsPath = Path.Combine(dataDirectory, "AccountLogins.xml");
            _bankInfoPath = Path.Combine(dataDirectory, "BankInfo.xml");

            // Create files if they don't exist
            if (!File.Exists(_accountLoginsPath))
                CreateEmptyUserXml();

            if (!File.Exists(_bankInfoPath))
                CreateEmptyBankAccountXml();
        }

        #region XML Structure Classes
        
        [XmlRoot("Users")]
        public class UserCollection
        {
            [XmlElement("User")]
            public List<User> Users { get; set; } = new List<User>();
        }

        [XmlRoot("BankAccounts")]
        public class BankAccountCollection
        {
            [XmlElement("BankAccount")]
            public List<BankAccount> BankAccounts { get; set; } = new List<BankAccount>();
        }
        
        #endregion

        #region Helper Methods for XML Creation
        
        private void CreateEmptyUserXml()
        {
            var userCollection = new UserCollection();
            XmlSerializer serializer = new XmlSerializer(typeof(UserCollection));
            using (var writer = new StreamWriter(_accountLoginsPath))
            {
                serializer.Serialize(writer, userCollection);
            }
        }

        private void CreateEmptyBankAccountXml()
        {
            var bankAccountCollection = new BankAccountCollection();
            XmlSerializer serializer = new XmlSerializer(typeof(BankAccountCollection));
            using (var writer = new StreamWriter(_bankInfoPath))
            {
                serializer.Serialize(writer, bankAccountCollection);
            }
        }
        
        #endregion

        public List<User> ReadUserAccounts()
        {
            try
            {
                if (!File.Exists(_accountLoginsPath) || new FileInfo(_accountLoginsPath).Length == 0)
                {
                    return new List<User>();
                }

                XmlSerializer serializer = new XmlSerializer(typeof(UserCollection));
                using (var reader = new StreamReader(_accountLoginsPath))
                {
                    var userCollection = (UserCollection)serializer.Deserialize(reader);
                    return userCollection.Users;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading user accounts: {ex.Message}");
                return new List<User>();
            }
        }

        public bool IsUsernameTaken(string username)
        {
            var users = ReadUserAccounts();
            return users.Any(user => user.Username.ToLower() == username.ToLower());
        }

        public void SaveUser(User user)
        {
            try
            {
                var users = ReadUserAccounts();
                
                // Check if user already exists, if so, update it
                var existingUser = users.FirstOrDefault(u => u.Username.ToLower() == user.Username.ToLower());
                if (existingUser != null)
                {
                    users.Remove(existingUser);
                }
                
                users.Add(user);
                
                var userCollection = new UserCollection { Users = users };
                XmlSerializer serializer = new XmlSerializer(typeof(UserCollection));
                
                using (var writer = new StreamWriter(_accountLoginsPath))
                {
                    serializer.Serialize(writer, userCollection);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving user: {ex.Message}");
            }
        }

        public void SaveBankAccount(BankAccount account)
        {
            try
            {
                var accounts = GetAllBankAccounts();
                
                // Check if account already exists, if so, update it
                var existingAccount = accounts.FirstOrDefault(a => 
                    a.FirstName == account.FirstName && 
                    a.LastName == account.LastName);
                    
                if (existingAccount != null)
                {
                    accounts.Remove(existingAccount);
                }
                
                accounts.Add(account);
                
                var bankAccountCollection = new BankAccountCollection { BankAccounts = accounts };
                XmlSerializer serializer = new XmlSerializer(typeof(BankAccountCollection));
                
                using (var writer = new StreamWriter(_bankInfoPath))
                {
                    serializer.Serialize(writer, bankAccountCollection);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving bank account: {ex.Message}");
            }
        }

        public List<BankAccount> GetAllBankAccounts()
        {
            try
            {
                if (!File.Exists(_bankInfoPath) || new FileInfo(_bankInfoPath).Length == 0)
                {
                    return new List<BankAccount>();
                }

                XmlSerializer serializer = new XmlSerializer(typeof(BankAccountCollection));
                using (var reader = new StreamReader(_bankInfoPath))
                {
                    var bankAccountCollection = (BankAccountCollection)serializer.Deserialize(reader);
                    return bankAccountCollection.BankAccounts;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading bank accounts: {ex.Message}");
                return new List<BankAccount>();
            }
        }

        public BankAccount GetBankAccount(string firstName, string lastName)
        {
            var accounts = GetAllBankAccounts();
            return accounts.FirstOrDefault(a => 
                a.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) && 
                a.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase));
        }

        public User GetUserByUsername(string username)
        {
            var users = ReadUserAccounts();
            return users.FirstOrDefault(user => 
                user.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
        }

        public BankAccount GetBankAccountByUsername(string username)
        {
            var user = GetUserByUsername(username);
            if (user != null)
            {
                return GetBankAccount(user.FirstName, user.LastName);
            }
            return null;
        }
    }
}