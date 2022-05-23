using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_lab3
{
    /// <summary>
    /// Autobus passengers.
    /// </summary>
    class AutobusPassengers : IPassengers
    {
        /// <summary>
        /// Maximal count of passengers.
        /// </summary>
        public int MaxCount => 30;

        /// <summary>
        /// Total count of passengers.
        /// </summary>
        public int TotalCount { 
            get 
            {
                return ChildCount + AdultCount + PreferentailCount;
            }
            set
            {
                TotalCount = ChildCount + AdultCount + PreferentailCount;
            } 
        }

        /// <summary>
        /// Count of children in autobus.
        /// </summary>
        public int ChildCount { get; set; }

        /// <summary>
        /// Count of adult in autobus.
        /// </summary>
        public int AdultCount { get; set; }

        /// <summary>
        /// Count of preferential in autobus.
        /// </summary>
        public int PreferentailCount { get; set; }
    }
}
