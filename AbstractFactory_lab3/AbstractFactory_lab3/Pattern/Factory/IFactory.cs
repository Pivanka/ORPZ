using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_lab3
{
    /// <summary>
    /// Abstract factory of creating products.
    /// </summary>
    public interface IFactory
    {
        IPassengers CreatePassengers();

        IDriver CreateDriver();
    }
}
