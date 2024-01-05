using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2
{
    // Concrete class representing a composite cabinet component.
    class Cabinet : FurnitureComponent
    {
        // List to hold the child components.
        private List<FurnitureComponent> components = new List<FurnitureComponent>();

        // Method to add a component to the cabinet.
        public void Add(FurnitureComponent component)
        {
            components.Add(component);
        }

        // Method to remove a component from the cabinet.
        public void Remove(FurnitureComponent component)
        {
            components.Remove(component);
        }

        // Implementation of the abstract method to get the cost of the cabinet.
        public override int GetCost()
        {
            int totalCost = 0;
            foreach (var component in components)
            {
                totalCost += component.GetCost();
            }
            return totalCost;
        }
    }
}
