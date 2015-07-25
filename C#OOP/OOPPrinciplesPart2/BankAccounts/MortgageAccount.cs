using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer customer, decimal interestRate)
            : base(customer, interestRate)
        {
        }

        public override decimal CalculateInterestAmount(int numberOfMonths)
        {
            if ((this.Customer is IndividualCustomer) && (numberOfMonths <= 6))
            {
                return 0.0M;
            }
            else if (this.Customer is CompanyCustomer && numberOfMonths <= 12)
            {
                return 0.5M;
            }
            else
            {
                return base.CalculateInterestAmount(numberOfMonths);
            }
        }

        public void DepositAmount(decimal amount)
        {
            this.Balance += amount;
        }
    }
}
