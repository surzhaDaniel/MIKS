using lab4_1.Travels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_1
{
    // Responsible for organizing travels based on a selected strategy.
    class TravelOrganizer
    {
        private ITravelStrategy strategy;

        // Sets the travel strategy for the organizer.
        public void SetTravelStrategy(ITravelStrategy strategy)
        {
            this.strategy = strategy;
        }

        // Organizes the travel using the selected strategy.
        public void OrganizeTravel()
        {
            if (strategy is null)
            {
                Console.WriteLine("Organization failed\n");
                return;
            }
            Console.WriteLine("Preparation for travel's organization...");
            strategy.OrganizeTravel();
            Console.WriteLine("Organization completed\n");
        }
    }
}
