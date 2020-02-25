using System.Collections.Generic;

namespace CarRace.Console
{
    class Program
    {
        /// <summary>
        /// Entry point of our program. Creates one race instance and uses that.
        /// </summary>
        /// <param name="args">Commandline arguments passed to the program. It is unused!</param>
        static void Main(string[] args)
        {
            Race race = new Race();
            CreateVehicles(race);
            
            race.SimulateRace();
            race.PrintRaceResults();
            System.Console.ReadKey();
        }

        /// <summary>
        /// Creates all the vehicles that will be part of the given race.
        /// </summary>
        /// <param name="race">A <see cref="Race"/> instance.</param>
        private static void CreateVehicles(Race race)
        {
            race.Cars.Add(new Car());
            race.Cars.Add(new Car());
            race.Cars.Add(new Car());
            race.Cars.Add(new Car());
            race.Cars.Add(new Car());
            race.Cars.Add(new Car());
            race.Cars.Add(new Car());
            race.Cars.Add(new Car());
            race.Cars.Add(new Car());
            race.Cars.Add(new Car());
            
            race.Trucks.Add(new Truck());
            race.Trucks.Add(new Truck());
            race.Trucks.Add(new Truck());
            race.Trucks.Add(new Truck());
            race.Trucks.Add(new Truck());
            race.Trucks.Add(new Truck());
            race.Trucks.Add(new Truck());
            race.Trucks.Add(new Truck());
            race.Trucks.Add(new Truck());
            race.Trucks.Add(new Truck());
            
            race.Motorcycles.Add(new Motorcycle());
            race.Motorcycles.Add(new Motorcycle());
            race.Motorcycles.Add(new Motorcycle());
            race.Motorcycles.Add(new Motorcycle());
            race.Motorcycles.Add(new Motorcycle());
            race.Motorcycles.Add(new Motorcycle());
            race.Motorcycles.Add(new Motorcycle());
            race.Motorcycles.Add(new Motorcycle());
            race.Motorcycles.Add(new Motorcycle());
            race.Motorcycles.Add(new Motorcycle());
        }
    }

}
