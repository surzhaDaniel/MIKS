using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_2.FinantialMonitors
{
    // The FinancialMonitor class defines the common structure for handling operation verification requests
    abstract class FinancialMonitor
    {
        protected FinancialMonitor successor;
        protected double threshold;

        // Sets the next sucessor in the chain
        public void SetSuccessor(FinancialMonitor successor)
        {
            this.successor = successor;
        }

        // Abstract method for processing operation requests
        public abstract void ProcessOperation(double amount, string clientType);
    }
}
