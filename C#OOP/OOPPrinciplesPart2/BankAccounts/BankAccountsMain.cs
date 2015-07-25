/*
 * Problem 2. Bank accounts

A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. Customers could be individuals or companies.
All accounts have customer, balance and interest rate (monthly based).
Deposit accounts are allowed to deposit and with draw money.
Loan and mortgage accounts can only deposit money.
All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.
Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
Deposit accounts have no interest if their balance is positive and less than 1000.
Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
Your task is to write a program to model the bank system by classes and interfaces.
You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.
 * */
namespace BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class BankAccountsMain
    {
        static void Main()
        {
            IndividualCustomer inCustomerPesho = new IndividualCustomer("Pesho");
            CompanyCustomer comCustomerGoshoOOD = new CompanyCustomer("Gosho OOD");

            DepositAccount peshoDepositAcc = new DepositAccount(inCustomerPesho,500m);
            LoanAccount goshoLoanAcc = new LoanAccount(comCustomerGoshoOOD, 600m);
            MortgageAccount goshoMorAcc = new MortgageAccount(comCustomerGoshoOOD,550m);


            Console.WriteLine("\tPesho acc info");
            Console.WriteLine();

            Console.WriteLine("Balance in the begining: {0}",peshoDepositAcc.Balance);
            peshoDepositAcc.DepositAmount(6000m);
            Console.WriteLine("Balance after deposit: {0}",peshoDepositAcc.Balance);
            peshoDepositAcc.WithdrawAmount(100m);
            Console.WriteLine("Balance after withdraw: {0}",peshoDepositAcc.Balance);
            Console.WriteLine("Interest Amount: " + peshoDepositAcc.CalculateInterestAmount(50));

            Console.WriteLine();
            Console.WriteLine(new string('-',30));
            Console.WriteLine();
            Console.WriteLine("\t Gosho loan acc info");
            Console.WriteLine();

            Console.WriteLine("Balance in the begining: {0}",goshoLoanAcc.Balance);
            goshoLoanAcc.DepositAmount(50000m);
            Console.WriteLine("Balance after deposit: {0}",goshoLoanAcc.Balance);
            Console.WriteLine("Interest Amount: " + goshoLoanAcc.CalculateInterestAmount(25));
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
            Console.WriteLine("\t Gosho Mortgage acc info");
            Console.WriteLine();

            Console.WriteLine("Balance in the begining: {0}",goshoMorAcc.Balance);
            goshoMorAcc.DepositAmount(50);
            Console.WriteLine("Balance after deposit: {0}",goshoMorAcc.Balance);
            Console.WriteLine("Interest Amount: " + goshoMorAcc.CalculateInterestAmount(5));

            






        }
    }
}
