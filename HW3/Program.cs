using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {            
            BankAccount2[] bankAccounts = new BankAccount2[4]
                {
                new BankAccount2(),
                new BankAccount2(100_000),
                new BankAccount2(AccountTypes.Super_Mega_Premium),
                new BankAccount2(500_000, AccountTypes.Premium)
                };


            bankAccounts[0].PutInto(300_000);
            if (bankAccounts[1].GetFrom(200_000))
            {
                Console.WriteLine("Деньги списаны со счёта");
            }
            else
            {
                Console.WriteLine("Недостаточно средств для списания со счёта");
            }
            foreach (var item in bankAccounts)
            {
                item.Print();
            }
        }
    }
}
