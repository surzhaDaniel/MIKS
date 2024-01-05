using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2
{
    // Concrete class representing a simple box component.
    class Box : FurnitureComponent
    {
        private int materialCost;
        private int manufacturingCost;

        // Constructor to initialize material and manufacturing costs.
        public Box(int materialCost, int manufacturingCost)
        {
            this.materialCost = materialCost;
            this.manufacturingCost = manufacturingCost;
        }

        // Implementation of the abstract method to get the cost of the box.
        public override int GetCost()
        {
            return materialCost + manufacturingCost;
        }
    }
}
