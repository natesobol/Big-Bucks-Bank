using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBucksBank
{
    public partial class WithdrawMoneyForm : Form
    {
        public WithdrawMoneyForm()
        {
            InitializeComponent();
        }

        private void rbChecking_CheckedChanged(object sender, EventArgs e)
        {
            checkedMessage("Checking", LoginScreen.getLoginAccount().CheckingAmount.ToString("c"));
        }

        private void rbSavings_CheckedChanged(object sender, EventArgs e)
        {

            checkedMessage("Savings", LoginScreen.getLoginAccount().SavingsAmount.ToString("c"));
                
        }

        private void checkedMessage(string accountType, string amount)
        {
            rtbMessage.Text = accountType + " Account" + "\nAmount: " + amount;
        }

        private void withdrawalMsg(string accountType, decimal amountWithdrawn, decimal newAcctAmount)
        {
            rtbMessage.Text =
                "Withdrawl Complete\n" +
                "Withdrawn:\t" + amountWithdrawn.ToString("c") + "\n" +
                accountType + " Balance:\n" + newAcctAmount.ToString("c");
        }

        private void withdrawlButton_Click(object sender, EventArgs e)
        {
            decimal withdrawal = 0m;
            if (rbChecking.Checked)
            {
                if (isValidWithdrawal())
                {
                    withdrawal = Convert.ToDecimal(tbAmount.Text);
                    decimal result = withdrawalProcess(withdrawal, LoginScreen.getLoginAccount().CheckingAmount);
                    withdrawalMsg("Checking", withdrawal, result);
                    LoginScreen.getLoginAccount().CheckingAmount = result;
                }
                else
                {
                    errorMessage("Invalid Number");
                }
            }
            else if(rbSavings.Checked){ 
                if (isValidWithdrawal())
                {
                    withdrawal = Convert.ToDecimal(tbAmount.Text);
                    decimal result = withdrawalProcess(withdrawal, LoginScreen.getLoginAccount().SavingsAmount);
                    withdrawalMsg("Savings", withdrawal, result);
                    LoginScreen.getLoginAccount().SavingsAmount = result;
                }
                else
                {
                    errorMessage("Invalid Number");
                }
            }
            else
            {
                errorMessage("Choose an account");
            }
        }

        private decimal withdrawalProcess(decimal withdrawal, decimal fromAccount)
        {
                if (LoginScreen.IsInRange(withdrawal, 0.00m, fromAccount))
                {
                    return Math.Round((fromAccount -= withdrawal), 2, MidpointRounding.AwayFromZero);
                }
                else
                {
                    errorMessage("Cannot withdraw that number");
                    return fromAccount;
                }
        }

        private void errorMessage(string text)
        {
            //Error message
            System.Windows.Forms.DialogResult close;
            close = MessageBox.Show(text, LoginScreen.Title);
        }

        private bool isValidWithdrawal()
        {
            string temp = tbAmount.Text;
            return LoginScreen.IsPresent(temp) &&
                   LoginScreen.IsDecimal(temp);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult close;
            close = MessageBox.Show("Are you sure you want to close window?", "Exiting", MessageBoxButtons.YesNo, MessageBoxIcon.
                Question);

            if (close == System.Windows.Forms.DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
