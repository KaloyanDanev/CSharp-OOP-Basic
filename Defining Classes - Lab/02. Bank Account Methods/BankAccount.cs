using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

    public class BankAccount
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        public override string ToString()
        {
            return $"Account {Id}, balance {Balance}";
        }
    }
