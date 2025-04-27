// Models/BankAccount.cs
using System;
using System.Xml.Serialization;

namespace BankingSystemGUI.Models
{
    public class BankAccount
    {
        [XmlElement("FirstName")]
        public string FirstName { get; set; }
        
        [XmlElement("LastName")]
        public string LastName { get; set; }
        
        [XmlElement("CheckingAccountNumber")]
        public string CheckingAccountNumber { get; set; }
        
        [XmlElement("CheckingBalance")]
        public decimal CheckingBalance { get; set; }
        
        [XmlElement("SavingsAccountNumber")]
        public string SavingsAccountNumber { get; set; }
        
        [XmlElement("SavingsBalance")]
        public decimal SavingsBalance { get; set; }
        
        [XmlElement("Username")]
        public string Username { get; set; }

        public BankAccount() { }

        public BankAccount(string firstName, string lastName, string checkingAccountNumber,
                       decimal checkingBalance, string savingsAccountNumber, decimal savingsBalance)
        {
            FirstName = firstName;
            LastName = lastName;
            CheckingAccountNumber = checkingAccountNumber;
            CheckingBalance = checkingBalance;
            SavingsAccountNumber = savingsAccountNumber;
            SavingsBalance = savingsBalance;
        }
    }
}