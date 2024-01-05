using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2
{
    // Concrete class representing a composite shelf component.
    class Shelf : FurnitureComponent
    {
        // List to hold the child components.
        private List<FurnitureComponent> components = new List<FurnitureComponent>();

        // Method to add a component to the shelf.
        public void Add(FurnitureComponent component)
        {
            components.Add(component);
        }

        // Method to remove a component from the shelf.
        public void Remove(FurnitureComponent component)
        {
            components.Remove(component);
        }

        // Implementation of the abstract method to get the cost of the shelf.
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
