using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    //Этот класс получился после выполнения всех пунктов д/з
    class BankAccount2
    {
        private static int _nextId = 0;
        private int _id;
        private decimal _balance;
        private AccountTypes _accountType;

        public BankAccount2():this(0, AccountTypes.Standart) { }
        public BankAccount2(decimal balance) : this(balance, AccountTypes.Standart) { }
        public BankAccount2(AccountTypes accountType):this (0,accountType) { }
        public BankAccount2(decimal balance, AccountTypes accountType)
        {
            Id = _nextId;
            _nextId++;
            Balance = balance;
            AccountType = accountType;
        }

        public int Id { get { return _id; } set { _id = value; } }
        public decimal Balance { get { return _balance; } set { _balance = value; } }
        public AccountTypes AccountType { get { return _accountType; } set { _accountType = value; } }

        public void Print()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Balance: {Balance}");
            Console.WriteLine($"AccountType: {AccountType}");
        }
        public bool PutInto(decimal money)
        {
            Balance += money;
            return true;
        }
        public bool GetFrom(decimal money)
        {
            if (Balance>=money)
            {
                Balance -= money;
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
