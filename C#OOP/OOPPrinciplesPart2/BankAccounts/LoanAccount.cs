using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class LoanAccount : Account, IDepositable
    {
        public LoanAccount(Customer customer, decimal interestRate)
            : base(customer, interestRate)
        {

        }

        public override decimal CalculateInterestAmount(int numberOfMonths)
        { 
            if ((this.Customer is IndividualCustomer) && (numberOfMonths <= 3))
            {
                return 0.0M; 
            }
            else if (this.Customer is CompanyCustomer && numberOfMonths <= 2)
            {
                return 0.0M;
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
