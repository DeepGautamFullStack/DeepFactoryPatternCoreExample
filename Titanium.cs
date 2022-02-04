using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFactoryPatternCoreExample
{
    public class Titanium : CreditCard
    {
        public int GetAnnualCharges()
        {
            return 1500;
        }

        public string GetCardType()
        {
            return "Titanium";
        }

        public int GetCreditLimit()
        {
            return 20000;
        }
    }
}
