﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Domain.Purses
{
    public class PurseUSD : Purse
    {
        public PurseUSD()
        {
            CurrencyCode = "USD";
        }
    }
}
