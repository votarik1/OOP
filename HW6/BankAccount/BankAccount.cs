using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public sealed class BankAccount
    {
        private static int _nextId = 0;
        private int _id;
        private decimal _balance;
        private AccountTypes _accountType;

        public BankAccount() : this(0, AccountTypes.Standart) { }
        public BankAccount(decimal balance) : this(balance, AccountTypes.Standart) { }
        public BankAccount(AccountTypes accountType) : this(0, accountType) { }
        public BankAccount(decimal balance, AccountTypes accountType)
        {
            Id = _nextId;
            _nextId++;
            Balance = balance;
            AccountType = accountType;
        }

        public int Id { get { return _id; } set { _id = value; } }
        public decimal Balance { get { return _balance; } set { _balance = value; } }
        public AccountTypes AccountType { get { return _accountType; } set { _accountType = value; } }

        public static bool operator ==(BankAccount a, BankAccount b)
        {
            if (a is null|| b is null)
            {
                if (a is null && b is null )
                {
                    return true;
                }
                return false;
            }
            if (a.Id==b.Id&& a.Balance==b.Balance && a.AccountType==b.AccountType)
            {
                return true;
            }
            return false;
        
        }

        public static bool operator !=(BankAccount a, BankAccount b) => !(a == b);

        public override bool Equals(object obj)
        {
            try
            {
                return this == (BankAccount)obj; // если obj не приведётся или там null вернётся false
            }
            catch (Exception)
            {
                return false;
            }
        }


        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Id: {Id}");
            output.AppendLine($"Balance: {Balance}");
            output.AppendLine($"AccountType: {AccountType}");
            return output.ToString();
        }

        public bool PutInto(decimal money)
        {
            Balance += money;
            return true;
        }
        public bool GetFrom(decimal money)
        {
            if (Balance >= money)
            {
                Balance -= money;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool TopUp(BankAccount DebitAccount, decimal money)
        {
            if (DebitAccount.GetFrom(money))
            {
                return PutInto(money);
            }
            return false;
        }
    }
}

