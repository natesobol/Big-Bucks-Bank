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
    public partial class TransferMoneyForm : Form
    {
        private decimal checkingBalance;
        private decimal savingsBalance;

        public TransferMoneyForm()
        {
            InitializeComponent();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (fromCheckingRadio.Checked)
            {
                if (toSavingsRadio.Checked)
                {
                    transferProcess(checkingBalance, savingsBalance, "Checking", "Savings");
                }
                else
                {
                    MessageBox.Show("Please choose a different internal account", LoginScreen.Title);
                }
            }else if (fromSavingsRadio.Checked)
            {
                if (toCheckingRadio.Checked)
                {
                    transferProcess(savingsBalance, checkingBalance, "Savings", "Checking");
                }
                else
                {
                    MessageBox.Show("Please choose a different internal account", LoginScreen.Title);
                }
            }
            else
            {
                MessageBox.Show("Please choose an account to transfer from", LoginScreen.Title);
            }
        }

        private void TransferForm_Load(object sender, EventArgs e)
        {
            checkingBalance = LoginScreen.getLoginAccount().CheckingAmount;
            savingsBalance = LoginScreen.getLoginAccount().SavingsAmount;

        }

        private void transCompleteMsg(string from, string to, decimal amountTransferred)
        {
            rtbMessage.Text = "Transfer Successful\n" + "From:\t" + from + "\n" + "To:\t" + to + "\n" + "Amount:\t" + amountTransferred.ToString("c") + "\n" + LoginScreen.getLoginAccount().printSummary();
        }

        private bool isValidTransfer(decimal max)
        {
            string temp = transferTextBox.Text;
            return LoginScreen.IsPresent(temp) &&
                   LoginScreen.IsDecimal(temp) &&
                   LoginScreen.IsInRange(Convert.ToDecimal(temp), 0.00m, max);
        }

        private void transferProcess(decimal amount1, decimal amount2, string from, string to)
        {
            if (isValidTransfer(amount1))
            {
                decimal transferAmount = Convert.ToDecimal(transferTextBox.Text);
                transferAmounts(transferAmount, amount1, amount2);
                transCompleteMsg(from, to, transferAmount);
            }
            else
            {
                MessageBox.Show("Cannot transfer that much money", LoginScreen.Title);
            }
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

        private void transferAmounts(decimal amount, decimal from, decimal to)
        {
            from -= amount;
            to += amount;
            if (fromCheckingRadio.Checked)
            {
                LoginScreen.getLoginAccount().CheckingAmount = from;
                LoginScreen.getLoginAccount().SavingsAmount = to;
            }
            else
            {
                LoginScreen.getLoginAccount().CheckingAmount = to;
                LoginScreen.getLoginAccount().SavingsAmount = from;
            }
        }

    }
}
