using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_2.FinantialMonitors
{
    // Concrete handler for Regular Employee in the chain.
    class RegularEmployee : FinancialMonitor
    {
        // Constructor sets the threshold for the Regular Employee
        public RegularEmployee()
        {
            threshold = 5000;
        }

        // Implements the operation processing for Regular Employee
        public override void ProcessOperation(double amount, string clientType)
        {
            if (amount <= threshold)
            {
                Console.WriteLine($"Regular Employee approved the operation of ${amount} for {clientType} client.");
            }
            else if (successor != null)
            {
                successor.ProcessOperation(amount, clientType);
            }
        }
    }
}
