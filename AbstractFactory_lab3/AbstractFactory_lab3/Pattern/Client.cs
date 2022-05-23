using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_lab3
{
    /// <summary>
    /// Transport client.
    /// Here are the main components without which the vehicle will not go and
    /// implementation of their interaction.
    /// This does not use specific implementations, but basic interfaces,
    /// which allows you to dynamically configure the components of the vehicle.
    /// Configuration is performed by transfer to the factory designer.
    /// It is important to understand that this class is in fact already a client of the abstract factory.
    /// An abstract factory does not have to return a single object. It returns individual components,
    /// which can both come together (as here),
    /// and just interact with each other.
    /// But an abstract factory guarantees that these components will
    /// correctly compatible and properly interact with each other.
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Driver of the vehicle.
        /// </summary>
        IDriver driver { get; set; }

        /// <summary>
        /// Passengers of the vehicle.
        /// </summary>
        IPassengers passengers { get; set; }

        /// <summary>
		/// Create vehicle with driver and passengers.
		/// </summary>
		/// <param name="f"> Factory determinig what vehicle will be. </param>
        public Client(IFactory f)
        {
            driver = f.CreateDriver();
            passengers = f.CreatePassengers();
        }

        /// <summary>
        /// Adding passengers.
        /// </summary>
        /// <param name="children"> Count of children`s seats. </param>
        /// <param name="adult"> Count of adult`s seats. </param>
        /// <param name="prefential"> Count of prefential`s seats. </param>
        public void AddPassengers(int children, int adult, int prefential = 0)
        {
            int sum = children + adult + prefential;
            if (sum <= passengers.MaxCount)
            {
                passengers.AdultCount = adult;
                passengers.ChildCount = children;
                passengers.PreferentailCount = prefential;
            }
            else
            {
                Console.WriteLine("Passengers cannot join to auto becuase count overrun maximal size! Add again.");
            }
        }
        /// <summary>
        /// Ready to move.
        /// </summary>
        /// <returns> Is ready to go?. </returns>
        public bool IsReady()
        {
            bool isReady = false;
            if (passengers.TotalCount != 0)
            {
                isReady = true;
            }
            return isReady;
        }
    }
}
