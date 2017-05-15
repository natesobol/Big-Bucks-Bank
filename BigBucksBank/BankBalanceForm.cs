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
    public partial class BankBalanceForm : Form
    {
        public BankBalanceForm()
        {
            InitializeComponent();
        }

        private void BankBalanceForm_Load(object sender, EventArgs e)
        {
            lblBalance.Text = LoginScreen.getLoginAccount().printSummary();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.DialogResult close;
            close = MessageBox.Show("Are you sure you want to EXIT?", "Exiting", MessageBoxButtons.YesNo, MessageBoxIcon.
                Question);

            if (close == System.Windows.Forms.DialogResult.Yes)
            {
                Close();
            }
        }
    }
}

   