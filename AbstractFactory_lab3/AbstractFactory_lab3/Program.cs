using System;

namespace AbstractFactory_lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new TaxiFactory();

            Client client = new Client(factory);
            client.AddPassengers(1,3);
            Console.WriteLine(client.IsReady());

            factory = new AutobusFactory();
            client = new Client(factory);
            client.AddPassengers(14, 15, 2);
            Console.WriteLine(client.IsReady());
        }
    }
}
