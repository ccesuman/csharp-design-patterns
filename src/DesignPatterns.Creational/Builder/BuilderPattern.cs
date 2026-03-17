using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class House
    {
        public string Foundation { get; set; } = string.Empty;
        public string Structure { get; set; } = string.Empty;
        public string Roof { get; set; } = string.Empty;
        public bool HasGarage { get; set; }
        public bool HasSwimmingPool { get; set; }
        public bool HasGarden { get; set; }
    }

    public class HouseBuilder
    {
        private House house = new();

        public HouseBuilder BuildFoundation(string foundation)
        {
            house.Foundation = foundation;
            return this;
        }

        public HouseBuilder BuildStructure(string structure)
        {
            house.Structure = structure;
            return this;
        }

        public HouseBuilder BuildRoof(string roof)
        {
            house.Roof = roof;
            return this;
        }

        public HouseBuilder AddGarage()
        {
            house.HasGarage = true;
            return this;
        }

        public HouseBuilder AddSwimmingPool()
        {
            house.HasSwimmingPool = true;
            return this;
        }

        public HouseBuilder AddGarden()
        {
            house.HasGarden = true;
            return this;
        }

        public House Build()
        {
            return house;
        }

    }
    public class BuilderPattern
    {
        //public static void Main(string[] args)
        //{
        //    HouseBuilder builder = new HouseBuilder();
        //    House house = builder.BuildFoundation("Concrete")
        //        .BuildStructure("Wood")
        //        .BuildRoof("Shingles")
        //        .AddGarage()
        //        .AddGarden()
        //        .Build();
        //    Console.WriteLine($"House built with foundation: {house.Foundation}, structure: {house.Structure}, roof: {house.Roof}, has garage: {house.HasGarage}, has swimming pool: {house.HasSwimmingPool}, has garden: {house.HasGarden}");
        //}
    }
}
