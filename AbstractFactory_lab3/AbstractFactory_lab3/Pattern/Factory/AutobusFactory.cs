using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_lab3
{
    /// <summary>
    /// Factory of autobus.
    /// Determining family of components.
    /// Contains factory methods.
    /// </summary>
    class AutobusFactory : IFactory
    {
        public IDriver CreateDriver()
        {
            return new AutobusDriver();
        }

        public IPassengers CreatePassengers()
        {
            return new AutobusPassengers();
        }
    }
}
