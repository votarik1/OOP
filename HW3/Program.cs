using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myBankAccount = new BankAccount(500000,AccountTypes.Super_Mega_Premium_Gold);
            BankAccount notMyBankAccount = new BankAccount(500000);
            myBankAccount.TopUp(notMyBankAccount, 25000);
            myBankAccount.Print();
            notMyBankAccount.Print();
        }
    }
}
