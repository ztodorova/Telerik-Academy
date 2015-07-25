using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class DepositAccount : Account, IWithdrawable, IDepositable
    {
        public DepositAccount(Customer customer, decimal interestRate) : base(customer, interestRate)
        {

        }

        public override decimal CalculateInterestAmount(int numberOfMonths)
        {
            if ((this.Balance > 0) && (this.Balance < 1000))
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

        public void WithdrawAmount(decimal amount)
        {
            if((this.Balance<=0) || ((this.Balance - amount) < 0))
            {
                throw new InvalidOperationException("Not enough balance!");
            }
            this.Balance -= amount;
        }

        
    }
}
