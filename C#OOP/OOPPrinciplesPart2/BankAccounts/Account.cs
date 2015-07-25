

namespace BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Account
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = 0.0m;
            this.InterestRate = interestRate;
        }

        public Account()
        {

        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }
           private set
            {
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
           protected set
            {
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
           private set
            {
                this.interestRate = value;
            }
        }

        public virtual decimal CalculateInterestAmount(int numberOfMonths)
        {
            if (numberOfMonths<0)
            {
                throw new ArgumentException("Invalid number of months!");
            }

            return numberOfMonths * this.InterestRate;
        }

    }
}
