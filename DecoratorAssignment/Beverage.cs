using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorAssignment
{
    // Abstract base class for beverages
    public abstract class Beverage
    {
        // Protected field to hold the description of the beverage
        protected string description = "Unknown Beverage";

        // Virtual method to get the description of the beverage
        public virtual string GetDescription()
        {
            return description;
        }

        // Abstract method to get the cost of the beverage (to be implemented by subclasses)
        public abstract decimal Cost();
    }
}
