using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace CarRace.Console
{
    /// <summary>
    /// This class is for simulating a full race with different vehicles and print race results ot the standard output.
    /// </summary>
    public class Race
    {
        Weather _weather = new Weather();
        public List<Car> Cars = new List<Car>();
        public List<Motorcycle> Motorcycles = new List<Motorcycle>();
        public List<Truck> Trucks = new List<Truck>();
        
        /// <summary>
        /// simulates the race by
        /// - calling MoveForAnHour() on every vehicle 50 times
        /// </summary>
        public void SimulateRace()
        {
            int lapNumber = 0;
            while (lapNumber < 50)
            {
                foreach (var car in Cars)
                {
                    car.PrepareForLap(this);
                    car.MoveForAnHour();
                }

                foreach (var motorcycle in Motorcycles)
                {
                    motorcycle.PrepareForLap(this);
                    motorcycle.MoveForAnHour();
                }

                foreach (var truck in Trucks)
                {
                    truck.PrepareForLap(this);
                    truck.MoveForAnHour();
                }

                lapNumber++;
            }
            
        }

        /// <summary>
        /// prints each vehicle's name, distance traveled ant type.
        /// </summary>
        public void PrintRaceResults()
        {
            System.Console.WriteLine("Cars:");
            foreach (var car in Cars)
            {
                System.Console.WriteLine($"{car.GetName()}: {car.GetDistanceTraveled()}");
            }

            System.Console.WriteLine();
            
            System.Console.WriteLine("Motorcycles");
            foreach (var motorcycle in Motorcycles)
            {
                
                System.Console.WriteLine($"{motorcycle.GetName()}: {motorcycle.GetDistanceTraveled()}");
            }

            System.Console.WriteLine();

            System.Console.WriteLine("Trucks:");
            foreach (var truck in Trucks)
            {
                System.Console.WriteLine($"{truck.GetName()}: {truck.GetDistanceTraveled()}");
            }
        }
        
        /// <summary>
        /// returns true if there is a broken truck on track
        /// </summary>
        /// <returns></returns>
        public bool IsThereABrokenTruck()
        {
            foreach (var truck in Trucks)
            {
                if (truck.IsBroken)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// setting if it is raining during lap
        /// </summary>
        /// <returns></returns>
        public bool IsRaining()
        {
            return _weather.GetRaining();
        }
    }
}