using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_2.FinantialMonitors
{
    // Concrete handler for Deputy Manager in the chain
    class DeputyManager : FinancialMonitor
    {
        // Constructor sets the threshold for the Deputy Manager
        public DeputyManager()
        {
            threshold = 25000;
        }

        // Implements the operation processing for Deputy Manager
        public override void ProcessOperation(double amount, string clientType)
        {
            if (amount <= threshold)
            {
                Console.WriteLine($"Deputy Manager approved the operation of ${amount} for {clientType} client.");
            }
            else if (successor != null)
            {
                successor.ProcessOperation(amount, clientType);
            }
        }
    }
}
