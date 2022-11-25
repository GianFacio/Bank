using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bank
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Welcome bank name
            Console.WriteLine("--------Bank of Programming--------");

            // First account
            // First and last name with initial balance is inserted and presented for the bank account
            var checkingAccount = new BankAccount("Gian Facio", 1000);

            // Investment account both individual and corporate 
            var investmentIndividualAccount = new BankAccount("Gian Facio", 3000);
            var investmentCorporateAccount = new BankAccount("Gian Facio", 100000);

            // Welcome message with owner name and unique bank account number
            Console.WriteLine($"Welcome {checkingAccount.Owner}. Account number {checkingAccount.Number}");

            // Each of the account balances
            Console.WriteLine($"Checking balance: ${checkingAccount.Balance}");
            Console.WriteLine($"Investment[Individual] balance: ${investmentIndividualAccount.Balance}");
            Console.WriteLine($"Investment[Corporate] balance: ${investmentIndividualAccount.Balance}\n");


            // Withdrawal from bank account and for what it's going out to
            checkingAccount.MakeWithdrawal(120, DateTime.Now, "Gas Bill");

            // Deposit to bank account and where it came from
            checkingAccount.MakeDeposit(500, DateTime.Now, "Work Paycheck");

            // History of the transactions of account
            Console.WriteLine("Checking Account");
            Console.WriteLine(checkingAccount.GetAccountHistory());

            // Investment account 
            Console.WriteLine("Investment[Individual] Account");
            // Investment growth to bank account and where it came from
            investmentIndividualAccount.MakeDeposit(4000, DateTime.Now, "Apple Stock Dividence");
            Console.WriteLine(investmentIndividualAccount.GetAccountHistory());

            // Investment account 
            Console.WriteLine("Investment[Corporate] Account");
            // Investment growth to bank account and where it came from
            investmentCorporateAccount.MakeTransfer(4000, DateTime.Now, "Solar Panel Foundation [Transfer]");
            Console.WriteLine(investmentCorporateAccount.GetAccountHistory());

            // Balances of all  accounts after transactions
            Console.WriteLine($"\nChecking account balance: ${checkingAccount.Balance}");
            Console.WriteLine($"Investment[Individual] account balance: ${investmentIndividualAccount.Balance}");
            Console.WriteLine($"Investment[Corporate] account balance: ${investmentCorporateAccount.Balance}\n");


            // Welcome bank name
            Console.WriteLine("--------Bank of Programming--------");

            // Second account
            // First and last name with initial balance is inserted and presented for the bank account
            var checkingAccount1 = new BankAccount("Emma Reeder", 1000000);

            // Investment account both individual and corporate 
            var investmentIndividualAccount1 = new BankAccount("Emma Reeder", 90000);
            var investmentCorporateAccount1 = new BankAccount("Emma Reeder", 7000000);

            // Welcome message with owner name and unique bank account number
            Console.WriteLine($"Welcome {checkingAccount1.Owner}. Account number {checkingAccount1.Number}");

            // Each of the account balances
            Console.WriteLine($"Checking balance: ${checkingAccount1.Balance}");
            Console.WriteLine($"Investment[Individual] balance: ${investmentIndividualAccount1.Balance}");
            Console.WriteLine($"Investment[Corporate] balance: ${investmentCorporateAccount1.Balance}\n");


            // Withdrawal from bank account and for what it's going out to
            checkingAccount1.MakeWithdrawal(200, DateTime.Now, "Electric Bill");
            checkingAccount1.MakeWithdrawal(560, DateTime.Now, "Car Insurance");
            checkingAccount1.MakeTransfer(2000, DateTime.Now, "Lease Transfer");

            // Deposit to bank account and where it came from
            checkingAccount1.MakeDeposit(50000, DateTime.Now, "Microsoft Paycheck");

            // History of the transactions of account
            Console.WriteLine("Checking Account");
            Console.WriteLine(checkingAccount1.GetAccountHistory());

            // Investment account 
            Console.WriteLine("Investment[Individual] Account");

            // Investment growth to bank account and where it came from
            investmentIndividualAccount1.MakeDeposit(4000, DateTime.Now, "Microsoft Stock Dividence");
            investmentIndividualAccount1.MakeDeposit(7000, DateTime.Now, "Marketing Agency Investment");
            Console.WriteLine(investmentIndividualAccount1.GetAccountHistory());

            // Investment account 
            Console.WriteLine("Investment[Corporate] Account");
            // Investment growth to bank account and where it came from
            investmentCorporateAccount1.MakeDeposit(870000, DateTime.Now, "Water Foundation");
            Console.WriteLine(investmentCorporateAccount1.GetAccountHistory());

            // Balances of all  accounts after transactions
            Console.WriteLine($"\nChecking account balance: ${checkingAccount1.Balance}");
            Console.WriteLine($"Investment[Individual] account balance: ${investmentIndividualAccount1.Balance}");
            Console.WriteLine($"Investment[Corporate] account balance: ${investmentCorporateAccount1.Balance}");
        }
    }
}

