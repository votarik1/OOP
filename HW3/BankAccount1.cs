using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    //Этот класс относится только к 1 пункту д/з
    class BankAccount1
    {
        private int _id;
        private decimal _balance;
        private AccountTypes _accountType;

        public int Id { get { return _id; } set {_id = value;} }
        public decimal Balance { get {return _balance;} set {_balance = value;} }
        public AccountTypes AccountType { get { return _accountType ; } set { _accountType = value; } }


        public int GetId()
        {
            return Id;
        }
        public void SetId(int id)
        {
            Id=id;
        }
        public decimal GetBalance()
        {
            return Balance;
        }
        public void SetBalance(decimal balance)
        {
            Balance = balance;
        }
        public AccountTypes GetAccountType()
        {
            return AccountType;
        }
        public void SetAccountType(AccountTypes accountType)
        {
            AccountType = accountType;
        }



        public void Print()
        { 
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Balance: {Balance}");
            Console.WriteLine($"AccountType: {AccountType}");
        }
    }
}
