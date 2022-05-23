using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_lab3
{
    /// <summary>
    /// Factory of taxi.
    /// Determining family of components.
    /// Contains factory methods.
    /// </summary>
    class TaxiFactory : IFactory  
    {
        public IDriver CreateDriver()
        {
            return new TaxiDriver();
        }

        public IPassengers CreatePassengers()
        {
            return new TaxiPassengers();
        }
    }
}
