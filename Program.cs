using System;
using System.Diagnostics;

namespace DeepFactoryPatternCoreExample
{
    //Factory pattern example by Deep Gautam -DeepGautamFullStack
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();


            // Without Factory Design pattern implementation -Start
            stopwatch.Start();
                            Console.Write("Without Factory Design Pattern Implementation");
                            string cardType = "MoneyBack";
                            CreditCard cardDetails = null;

                            if (cardType=="MoneyBack")
                            {
                                cardDetails = new MoneyBack();
                            }
                            else if (cardType == "Titanium")
                            {
                                cardDetails = new Titanium();
                            }
                            else if (cardType == "Platinum")
                            {
                                cardDetails = new Platinum();
                            }

                            if (cardDetails != null)
                            {
                                Console.WriteLine("CardType : " + cardDetails.GetCardType());
                                Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
                                Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharges());
                            }
                            else
                            {
                                Console.Write("Invalid Card Type");
                            }
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
            // Without Factory Design pattern implementation -End




            //Factory Design pattern implementation -Start
            stopwatch.Start();
                                Console.Write("Factory Design Pattern Implementation");
                                CreditCard cardDetailsFactory = CreditCardFactory.GetCreditCard("MoneyBack");

                                if (cardDetails != null)
                                {
                                    Console.WriteLine("CardType : " + cardDetailsFactory.GetCardType());
                                    Console.WriteLine("CreditLimit : " + cardDetailsFactory.GetCreditLimit());
                                    Console.WriteLine("AnnualCharge :" + cardDetailsFactory.GetAnnualCharges());
                                }
                                else
                                {
                                    Console.Write("Invalid Card Type");
                                }

            stopwatch.Stop();
            Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);

            //Factory Design pattern implementation -End

            Console.ReadLine();
        }
    }
}
