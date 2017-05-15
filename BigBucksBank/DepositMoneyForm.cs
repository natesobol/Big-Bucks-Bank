using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksBank
{
    public partial class DepositMoneyForm : Form
    {
        public DepositMoneyForm()
        {
            InitializeComponent();
        }

        private void rbChecking_CheckedChanged(object sender, EventArgs e)
        {
            checkedMessage("checking", LoginScreen.getLoginAccount().CheckingAmount.ToString("c"));
        }

        private void rbSavings_CheckedChanged(object sender, EventArgs e)
        {
            checkedMessage("savings", LoginScreen.getLoginAccount().SavingsAmount.ToString("c"));
        }

        private void checkedMessage(string accountType, string amount)
        {
            recieptTextBox.Text = accountType + "\nAmount: " + amount;
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            decimal withdrawal = 0m;
            if (checkingRadio.Checked)
            {
                if (isValidDeposit())
                {
                    withdrawal = Convert.ToDecimal(depositAmount.Text);
                    decimal result = depositProcess(withdrawal, LoginScreen.getLoginAccount().CheckingAmount);
                    depositMsg("Checking", withdrawal, result);
                    LoginScreen.getLoginAccount().CheckingAmount = result;
                }
                else
                {
                    errorMessage("Invalid Entry");
                }
            }
            else if (savingsRadio.Checked)
            { 
                if (isValidDeposit())
                {
                    withdrawal = Convert.ToDecimal(depositAmount.Text);
                    decimal result = depositProcess(withdrawal, LoginScreen.getLoginAccount().SavingsAmount);
                    depositMsg("Savings", withdrawal, result);
                    LoginScreen.getLoginAccount().SavingsAmount = result;
                }
                else
                {
                    errorMessage("Invalid Entry");
                }
            }
            else
            {
                errorMessage("Please choose which account to deposit to");
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult close;
            close = MessageBox.Show("Are you sure you want to close window?", "quit", MessageBoxButtons.YesNo, MessageBoxIcon.
                Question);

            if (close == System.Windows.Forms.DialogResult.Yes)
            {
                Close();
            }
        }

        private void depositMsg(string accountType, decimal amtDeposited, decimal newAcctAmount)
        {
            recieptTextBox.Text = "transaction\n" +  "Deposited:\t" + amtDeposited.ToString("c") + "\n" + accountType + " Balance:\t" + newAcctAmount.ToString("c");
        }

        private decimal depositProcess(decimal deposit, decimal fromAccount)
        {
                return Math.Round((fromAccount += deposit), 2, MidpointRounding.AwayFromZero);
        }

        private void errorMessage(string text)
        {
            System.Windows.Forms.DialogResult close;
            close = MessageBox.Show(text, LoginScreen.Title);
        }

        private bool isValidDeposit()
        {
            string temp = depositAmount.Text;
            return LoginScreen.IsPresent(temp) &&
                   LoginScreen.IsDecimal(temp) &&
                   LoginScreen.isPositive(Convert.ToDecimal(temp), 0.00m);
        }
    }

    public static class InfoToFile
    {

        private const string file = "account balance.txt";

        public static void SaveAmounts(List<Login> accounts)
        {
            StreamWriter textOut = new StreamWriter(new FileStream(file, FileMode.Create, FileAccess.Write));

            foreach (Login account in accounts)
            {
                textOut.WriteLine(account.CheckingAmount + " " + account.SavingsAmount);
            }

            textOut.Close();
        }

        public static List<Login> GetAccountAmounts()
        {
            if (!File.Exists(file))
                File.Create(file);

            StreamReader textIn = new StreamReader(new FileStream(file, FileMode.OpenOrCreate, FileAccess.Read));
            List<Login> accounts = new List<Login>();

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split(' ');
                Login newAccount = new Login();
                newAccount.CheckingAmount = Convert.ToDecimal(columns[0]);
                newAccount.SavingsAmount = Convert.ToDecimal(columns[1]);
                accounts.Add(newAccount);
            }

            textIn.Close();
            return accounts;
        }
    }
}


