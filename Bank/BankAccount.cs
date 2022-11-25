using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Bank
{
	public class BankAccount
	{
        public string Number { get; }

        public string Owner { get; set; }

        public decimal Balance
        {
            get
            {
                decimal balance = 0;

                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }

        }

        // Bank account numbers. This will increase as new accounts are made
        private static int accountNumberSeed = 1000;

        private List<Transaction> allTransactions = new List<Transaction>();

        // Bank account owner name and initial balance
        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;

            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");

            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

        }

        // Depsoit if statment with amount, date, and note of transaction
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Deposit must be positive");
            }

            var deposit = new Transaction(+amount, date, note);
            allTransactions.Add(deposit);
        }

        // Withdrawal if statment with amount, date, and note of transaction
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("No sufficient funds for this withdrawal");
            }

            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        // Transfer if statment with amount, date, and note of transaction
        public void MakeTransfer(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Transfer must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("No sufficient funds for this transfer");
            }

            var transfer = new Transaction(-amount, date, note);
            allTransactions.Add(transfer);
        }

        // History of account transactions
        public string GetAccountHistory()
        {
            var report = new StringBuilder();

            // Header
            report.AppendLine("Date\t\tAmmount\t\tNote");
            foreach (var item in allTransactions)
            {
                // Rows
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t\t{item.Notes}");
            }
            return report.ToString();
        }
    }
}