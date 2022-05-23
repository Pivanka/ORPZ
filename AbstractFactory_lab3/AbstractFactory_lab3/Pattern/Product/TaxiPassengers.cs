using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_lab3
{
    /// <summary>
    /// Taxi passengers.
    /// </summary>
    class TaxiPassengers : IPassengers
    {
        /// <summary>
        /// Maximal count of passengers.
        /// </summary>
        public int MaxCount => 4;
        int childCount;

        /// <summary>
        /// Total count of passengers.
        /// </summary>
        public int TotalCount
        {
            get
            {
                return ChildCount + AdultCount;
            }
            set
            {
                TotalCount = ChildCount + AdultCount;
            }
        }

        /// <summary>
        /// Count of adult in taxi.
        /// </summary>
        public int AdultCount { get; set; }

        /// <summary>
        /// Count of children in taxi.
        /// </summary>
        public int ChildCount
        {
            get => childCount;
            set {
                HasCarSeat = true;
                childCount = value;
            } 
        }

        /// <summary>
        /// Count of preferential in taxi. 
        /// </summary>
        public int PreferentailCount { get; set; } = 0;

        /// <summary>
        /// THE PRESENCE OF A CHILD SEAT.
        /// </summary>
        public bool HasCarSeat = false;
    }
}
