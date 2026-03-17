using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    public interface ITransport
    {
        void Deliver();
    }

    public class Car : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Delivering by car");
        }
    }

    public class Bike : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Delivering by bike");
        }
    }

    public class Bus : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Delivering by bus");
        }
    }

    public class TransportFactory
    {
        public ITransport CreateTransport(string type)
        {
            return type.ToLower() switch
            {
                "car" => new Car(),
                "bike" => new Bike(),
                "bus" => new Bus(),
                _ => throw new ArgumentException("Invalid transport type")
            };
        }
    }

    public class FactoryPattern
    {
        //public static void Main(string[] args)
        //{
        //    TransportFactory factory = new TransportFactory();
        //    ITransport transport1 = factory.CreateTransport("car");
        //    ITransport transport2 = factory.CreateTransport("bike");
        //    ITransport transport3 = factory.CreateTransport("bus");
        //    transport1.Deliver();
        //    transport2.Deliver();
        //    transport3.Deliver();
        //}
    }
}
