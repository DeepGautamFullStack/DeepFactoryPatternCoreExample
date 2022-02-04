using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFactoryPatternCoreExample
{
    public class MoneyBack : CreditCard
    {
        public int GetAnnualCharges()
        {
            return 500;
        }

        public string GetCardType()
        {
            return "MoneyBack";
        }

        public int GetCreditLimit()
        {
            return 15000;
        }
    }
}
