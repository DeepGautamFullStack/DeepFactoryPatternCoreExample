using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFactoryPatternCoreExample
{
    public class Platinum : CreditCard
    {
        public int  GetAnnualCharges()
        {
            return 3500;
        }

        public string GetCardType()
        {
            return "Platinum Plus"; ;
        }

        public int GetCreditLimit()
        {
            return 35000;
        }
    }
}
