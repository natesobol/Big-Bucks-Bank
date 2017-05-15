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

    public partial class actionForm : Form
    {
        int choice = 0;

        public actionForm()
        {
            InitializeComponent();
        }

        private void actionForm_Load(object sender, EventArgs e)
        {
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            switch (choice)
            {
                case 1:
                    DepositMoneyForm dForm = new DepositMoneyForm();
                    dForm.Show();
                    break;
                case 2:
                    WithdrawMoneyForm wForm = new WithdrawMoneyForm();
                    wForm.Show();
                    break;
                case 3:
                    BankBalanceForm bForm = new BankBalanceForm();
                    bForm.Show();
                    break;
                case 4:
                    TransferMoneyForm tForm = new TransferMoneyForm();
                    tForm.Show();
                    break;
                case 5:
                    System.Windows.Forms.DialogResult close;
                    close = MessageBox.Show("Are you sure you want to exit?", "quit", MessageBoxButtons.YesNo, MessageBoxIcon.
                        Question);

                    if (close == System.Windows.Forms.DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                    break;
            }
        }

        private void depositRadio_CheckedChanged(object sender, EventArgs e)
        {
            if(depositRado.Checked == true)
            {
                choice = 1;
            }
        }

        private void withdrawRadio_CheckedChanged(object sender, EventArgs e)
        {
            if(withdrawRadio.Checked == true)
            {
                choice = 2;
            }
        }

        private void balanceRadio_CheckedChanged(object sender, EventArgs e)
        {
            if(balanceRadio.Checked == true)
            {
                choice = 3;
            }
        }

        private void transferRadio_CheckedChanged(object sender, EventArgs e)
        {
            if(transferRadio.Checked == true)
            {
                choice = 4;
            }
        }

        private void exitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (exitRadioButton.Checked == true)
            {
                choice = 5;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult close;
            close = MessageBox.Show("Are you sure you want to exit?", "quit", MessageBoxButtons.YesNo, MessageBoxIcon.
                Question);

            if (close == System.Windows.Forms.DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
