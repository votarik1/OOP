using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Text;

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
            Console.WriteLine(Reverse("Hello World"));
        }

        public static string Reverse(string input)
        {
            StringBuilder reverseString = new StringBuilder();
            for (int i = input.Length-1; i >= 0 ; i--)
            {
                reverseString.Append(input[i]);
            }
            return reverseString.ToString();
        }
    }
}
