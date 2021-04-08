using System;

namespace DesignPatternsConsole.ChainOfResp
{
    public class ATM
    {
        private TwoThousandHandler twoThousandHandler = new TwoThousandHandler();
        private FiveHundredHandler fiveHundredHandler = new FiveHundredHandler();
        private TwoHundredHandler twoHundredHandler = new TwoHundredHandler();
        private HundredHandler hundredHandler = new HundredHandler();

        public ATM()
        {
            // Prepare the chain of Handlers
            twoThousandHandler.nextHandler(fiveHundredHandler);
            fiveHundredHandler.nextHandler(twoHundredHandler);
            twoHundredHandler.nextHandler(hundredHandler);
        }
        public void withdraw(long requestedAmount)
        {
            twoThousandHandler.dispatchRs(requestedAmount);
        }
    }

    public class Tester
    {
        public static void Run(string[] args)
        {
            ATM atm = new ATM();
            Console.WriteLine("\n Requested Amount 4600");
            atm.withdraw(4600);
            Console.WriteLine("\n Requested Amount 1900");
            atm.withdraw(1900);
            Console.WriteLine("\n Requested Amount 600");
            atm.withdraw(600);
            Console.Read();
        }
    }
}