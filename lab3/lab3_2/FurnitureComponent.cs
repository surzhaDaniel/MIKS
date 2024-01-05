using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2
{
    // Abstract base class representing a furniture component.
    abstract class FurnitureComponent
    {
        // Constructor for the base class.
        public FurnitureComponent() { }

        // Abstract method to get the cost of the component. Subclasses must implement this method.
        public abstract int GetCost();

        // Virtual method to add a component. 
        public virtual void Add(FurnitureComponent component)
        {
            throw new NotImplementedException();
        }

        // Virtual method to remove a component.
        public virtual void Remove(FurnitureComponent component)
        {
            throw new NotImplementedException();
        }
    }
}
