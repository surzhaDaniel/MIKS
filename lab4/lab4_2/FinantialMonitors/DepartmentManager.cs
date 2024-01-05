using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_2.FinantialMonitors
{
    // Concrete handler for Department Manager in the chain
    class DepartmentManager : FinancialMonitor
    {
        // Constructor sets the threshold for the Department Manager
        public DepartmentManager()
        {
            threshold = 100000;
        }

        // Implements the operation processing for Department Manager
        public override void ProcessOperation(double amount, string clientType)
        {
            if (amount <= threshold)
            {
                Console.WriteLine($"Department Manager approved the operation of ${amount} for {clientType} client.");
            }
            else
            {
                Console.WriteLine($"Operation of ${amount} for {clientType} client requires further investigation.");
            }
        }
    }
}
