using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksBank
{
    class writeToFile
    {
        private const string path = @".\";
        private const string fileName = path + "BinaryAccountsAmounts.dat";

        public static void SaveAmounts(List<Login> accounts)
        {
            BinaryWriter outFile = new BinaryWriter(new FileStream(fileName, FileMode.Create, FileAccess.Write));
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            foreach (Login account in accounts)
            {
                outFile.Write(account.CheckingAmount);
                outFile.Write(account.SavingsAmount);
            }

            outFile.Close();
        }

        public static List<Login> GetAccountAmounts()
        {     
            List<Login> accountLists = new List<Login>();
            BinaryReader inFile = new BinaryReader(new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read));

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            while (inFile.PeekChar() != -1)
            {
                Login user = new Login();
                user.CheckingAmount = inFile.ReadDecimal();
                user.SavingsAmount = inFile.ReadDecimal();
                accountLists.Add(user);
            }

            inFile.Close();
            return accountLists;
        }
    }
}
