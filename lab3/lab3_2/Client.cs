using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2
{
    // Class representing a client that can print the cost of a furniture component.
    class Client
    {
        // Method to print the cost of a given furniture component.
        public void PrintCost(FurnitureComponent component)
        {
            Console.WriteLine($"Cost: {component.GetCost()}");
        }
    }
}
