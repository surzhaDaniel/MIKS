using lab4_2.FinantialMonitors;

namespace lab4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the chain of responsibility handlers
            FinancialMonitor regularEmployee = new RegularEmployee();
            FinancialMonitor deputyManager = new DeputyManager();
            FinancialMonitor departmentManager = new DepartmentManager();

            // Form the chain of responsibility
            regularEmployee.SetSuccessor(deputyManager);
            deputyManager.SetSuccessor(departmentManager);

            // Test the handling of operation verification requests
            regularEmployee.ProcessOperation(3000, "Individual");
            Console.WriteLine();
            regularEmployee.ProcessOperation(15000, "Individual Entrepreneur");
            Console.WriteLine();
            regularEmployee.ProcessOperation(50000, "Corporate Resident");
            Console.WriteLine();
            regularEmployee.ProcessOperation(200000, "Non-Resident");
        }
    }

}