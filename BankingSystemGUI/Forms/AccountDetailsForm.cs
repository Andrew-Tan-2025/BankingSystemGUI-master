using System;
using System.Windows.Forms;
using BankingSystemGUI.Models;

namespace BankingSystemGUI.Forms
{
    public partial class AccountDetailsForm : Form
    {
        private readonly BankAccount _bankAccount;

        public AccountDetailsForm(BankAccount bankAccount)
        {
            InitializeComponent();
            _bankAccount = bankAccount;
            LoadAccountDetails();
        }

        private void LoadAccountDetails()
        {
            lblWelcome.Text = $"Welcome, {_bankAccount.FirstName} {_bankAccount.LastName}!";
            lblCheckingNumber.Text = _bankAccount.CheckingAccountNumber;
            lblCheckingBalance.Text = $"${_bankAccount.CheckingBalance:0.00}";
            lblSavingsNumber.Text = _bankAccount.SavingsAccountNumber;
            lblSavingsBalance.Text = $"${_bankAccount.SavingsBalance:0.00}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            StockForm stockForm = new StockForm();
            stockForm.ShowDialog();
        }

        private void goTrans_Click(object sender, EventArgs e)
        {
            TransferForm transferForm = new TransferForm(_bankAccount);
            transferForm.ShowDialog();
        }
    }
}