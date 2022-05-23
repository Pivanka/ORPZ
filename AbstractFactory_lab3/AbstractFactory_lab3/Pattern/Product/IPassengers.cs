using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_lab3
{
    /// <summary>
    /// Vehicle passengers.
    /// </summary>
    public interface IPassengers
    {
        int MaxCount { get; }
        int TotalCount { get; set; }
        int ChildCount { get; set; }
        int AdultCount { get; set; }
        int PreferentailCount { get; set; }

    }
}
