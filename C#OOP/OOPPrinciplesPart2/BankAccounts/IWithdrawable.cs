﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public interface IWithdrawable
    {
        void WithdrawAmount(decimal amount);
    }
}
