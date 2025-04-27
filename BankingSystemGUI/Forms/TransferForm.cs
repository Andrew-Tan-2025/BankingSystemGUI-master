using BankingSystemGUI.Models;
using BankingSystemGUI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSystemGUI.Forms
{
    public partial class TransferForm : Form
    {
        private BankAccount _bankAccount;
        private FileService fileService;
        private int count;

        public TransferForm(BankAccount bankAccount)
        {
            InitializeComponent();
            _bankAccount = bankAccount;
            fileService = new FileService();
            count = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Goes back to AccountDetailsForm
            this.Hide();
            AccountDetailsForm accountDetailsForm = new AccountDetailsForm(_bankAccount);
            accountDetailsForm.ShowDialog();
            this.Close();
        }

        private void TransferFunc_Click(object sender, EventArgs e)
        {
            //Transfer funds function
            decimal amnt; //might add some assurance here
            string sndF = sndFrom.Text; //account received
            string sndT = sndTo.Text; //account sent

            //Check to see if transferring to same account
            if (sndF.Equals("Select account") || sndT.Equals("Select account"))
            {
                StatusMessage.Text = "Account not selected!";
            }
            else if (sndF.Equals(sndT))
            {
                StatusMessage.Text = "Please Select 2 different Accounts!";
            }
            else if (string.IsNullOrEmpty(FndTxt.Text))
            {
                //Check to see if any fund amount was given
                StatusMessage.Text = "Please enter an amount to transfer!";
            }
            else
            {
                //Call service to begin transfer
                amnt = Convert.ToDecimal(FndTxt.Text);
                //bool tmp = _depositService.updateTransfer(sndF, sndT, amnt);
                if (sndF == "Savings")
                {
                    if (_bankAccount.SavingsBalance <= amnt)
                    {
                        StatusMessage.Text = "Insufficient funds in account to transfer!";
                    } else
                    {
                        _bankAccount.SavingsBalance -= amnt;
                        _bankAccount.CheckingBalance += amnt;
                        StatusMessage.Text = "Funds Sent!";
                    }
                } else
                {
                    if (_bankAccount.CheckingBalance <= amnt)
                    {
                        StatusMessage.Text = "Insufficient funds in account to transfer!";
                    }
                    else
                    {
                        _bankAccount.CheckingBalance -= amnt;
                        _bankAccount.SavingsBalance += amnt;
                        StatusMessage.Text = "Funds Sent!";
                    }
                }

                //update bank account details
                fileService.SaveBankAccount(_bankAccount);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Transfer funds to Savings every 2 minuts(120000 ms)
            _bankAccount.SavingsBalance += 500;
            count++;
            fileService.SaveBankAccount(_bankAccount);
            DepositStatus.Text = "Successful deposits: "+count;
        }
    }
}
