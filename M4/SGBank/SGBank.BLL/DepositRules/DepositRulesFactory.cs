using SGBank.Models;
using SGBank.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGBank.BLL.DepositRules
{
    public class DepositRulesFactory
    {
        public static IDeposit Create(AccountType type)
        {
            switch (type)
            {
                case AccountType.Free:
                    return new FreeAccountDepositRule();
                //    break;
                //case AccountType.Basic:
                //    break;
                //case AccountType.Premium:
                //    break;
                //default:
                //    break;
            }

            throw new Exception("Account type is not the supported!");
        }
    }
}
