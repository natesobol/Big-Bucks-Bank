// Programmer: Nate Sobol
// Title: Big Bucks Bank
// Last Modifed: 3/11/17

using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigBucksBank
{
    static class MainProg
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginScreen());
        }
    }
}
