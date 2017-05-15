// Programmer: Nate Sobol
// Title: Big Bucks Bank
// Last Modifed: 3/11/17

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
    public partial class LoginScreen : Form
    {
        public delegate bool ChangeHandler(TextBox tb);
        private bool isLogged = false;
        const int ATTEMPT_LIM = 3;
        private List<Login> accounts;
        private static Login selectedAcc;
        int acctIndex;
        int attemptCounter = 0;

        

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            initPins();
            loadAccounts();
        }

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void loadAccounts()
        {
            string[] pinNums = { "1", "1234", "7777", "5000", "9000" };
            string[] checkingAccountNums = { "1", "74201-2256", "49323-3260", "99475-8973", "95873-1948" };
            string[] savingAccountNums = { "2", "85743-9845", "75894-6459", "80547-8739", "67983-0934" };
            string[] users = { "test", "natesobol", "Lucky_Smith", "JerrySeinfeld", "GeorgeCostanza" };

            accounts = writeToFile.GetAccountAmounts();
            if (accounts.Count == 0) { for (int k = 0; k < 5; k++) { accounts.Add(new Login()); } }
            int i = 0, j = 0, p = 0;
            foreach (Login account in accounts)
            {
                account.UserName = users[i];
                account.Pin = pinNums[i];
                account.CheckingAccount = checkingAccountNums[p++];
                account.SavingsAccount = savingAccountNums[j++]; i++;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!isLogged)
            {
                acctIndex = accountExists();
                if (acctIndex != -1)
                {
                    usernameTextBox.Focus();
                    if (isCorrectPin(acctIndex))
                    {
                        selectedAcc = accounts[acctIndex];
                        clearLog();
                        attemptCounter = 0;
                        actionForm diag = new actionForm();
                        diag.ShowDialog();
                        banklogTextBox.Text = accounts[acctIndex].printSummary();
                    }
                    else { invalidLogin(); }
                }

                else { invalidLogin(); }
            }

        }

        private int accountExists()
        {
            foreach (Login account in accounts)
            {
                if (account.UserName.Equals(usernameTextBox.Text))
                {
                    return accounts.IndexOf(account);
                }
            }
            return -1;
        }

        private bool isCorrectPin(int i)
        {
            if (accounts[i].Pin.Equals(pinTextBox.Text)){ return true; }
            else { return false; }
        }

        private void invalidLogin()
        {
            attemptCounter++;
            banklogTextBox.Text = "Out of Tries\n" + (ATTEMPT_LIM - attemptCounter) + " attempts left";
            clearLog();
            if (attemptCounter == ATTEMPT_LIM)
            {
                banklogTextBox.Text = "Login attempts exceeded!";
                clearLog();
                pinTextBox.Enabled = false;
                isLogged = true;
            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            if (isLogged)
            {
                pinTextBox.Enabled = true;
            }
        }

        private void clearLog()
        {
            usernameTextBox.Text = "";
            pinTextBox.Text = "";
            usernameTextBox.Focus();
        }

        public static Login getLoginAccount() { return selectedAcc; }

        private void initPins()
        {
            pinTextBox.Text = "";
            pinTextBox.PasswordChar = '*';
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult close;
            close = MessageBox.Show("Are you sure you want to exit?", "quit", MessageBoxButtons.YesNo, MessageBoxIcon.
                Question);

            if (close == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private static string title = "Entry Error";

        public static string Title
        {
            get { return title; }
            set { title = value; }
        }

        public static bool IsPresent(string text)
        {
            if (text.Equals(""))
            {
                return false;
            }
            return true;
        }

        public static bool IsDecimal(string text)
        {
            decimal number = 0m;
            if (Decimal.TryParse(text, out number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsInt32(string text)
        {
            int num = 0;
            if (Int32.TryParse(text, out num)) { return true; }
            else { return false; }
        }

        public static bool IsInRange(decimal amount, decimal low, decimal high)
        {

            if (amount < low || amount > high)
            { return false; }
            else { return true; }
        }

        public static bool isPositive(decimal i, decimal min)
        {
            if (i < min) { return false; }
            else { return true; }
        }

    }

    public class Login
    {
        private string user;
        private string pinNum;
        private decimal checkingBalance;
        private decimal savingBalance;
        private string checking;
        private string savings;

        public Login()
        {
            user = "";
            pinNum = "";
            checking = "------";
            savings = "------";
            checkingBalance = 0.00m;
            savingBalance = 0.00m;
        }

        public Login(String userName, String pin, string checkingNumber, string savingNumber, decimal checking, decimal savings)
        {
            this.user = userName;
            this.pinNum = pin;
            this.checkingBalance = checking;
            this.savingBalance = 0.00m;
            this.checking = checkingNumber;
            this.savings = savingNumber;
        }

        public string printSummary()
        {
            return
                "         Big Bucks Bank          \n" +
                "   Your Recipt - Thank You!      \n" +
                "---------------------------------\n" +
                "Username:           " + user + "\n" + "checking account #: " + checking + "\n" + "checking balance:   " + checkingBalance.ToString("c") + 
                "\n" + "savings account #:  " + savings + "\n" + "savings balance:    " + savingBalance.ToString("c");
        }

        // Getters/Setters
        public string UserName
        {
            get{ return user;}
            set { user = value; }
        }

        public string Pin
        {
            get { return pinNum; }
            set { pinNum = value; }
        }

        public decimal CheckingAmount
        {
            get { return checkingBalance; }
            set { checkingBalance = value;  }
        }

        public decimal SavingsAmount
        {
            get{ return savingBalance; }
            set { savingBalance = value; }
        }

        public string CheckingAccount
        {
            get { return checking; }
            set { checking = value; }
        }

        public string SavingsAccount
        {
            get { return savings; }
            set { savings = value; }
        }
    }
}
