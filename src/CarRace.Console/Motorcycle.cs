using System;

namespace CarRace.Console
{
    /// <summary>
    /// speed is 100km/h. If it rains, travels with 5-50km/h slower (randomly). Doesn't care about trucks.
    /// </summary>
    public class Motorcycle : Vehicle
    {
        
        private readonly Random _random = new Random();
        
        /// <summary>
        /// The number of the instance created. Used for its name.
        /// </summary>
        /// <returns></returns>
        private static int MotorcycleNumber { get; set; } = 1;

        /// <summary>
        /// Are called "Motorcycle 1", "Motorcycle 2", "Motorcycle 3",... Unique.
        /// </summary>
        private string Name { get; set; }
        
        /// <summary>
        /// holds the summarized distance traveled in the race.
        /// </summary>
        private int DistanceTraveled { get; set; }
        
        private int LapSpeed { get; set; }


        
        /// <summary>
        /// Setting speed of the motorcycle
        /// </summary>
        /// <param name="isRaining"></param>
        private void SetSpeed(bool isRaining)
        {
            int slowerSpeed = _random.Next(5, 51);
            LapSpeed = isRaining ? 100 - slowerSpeed : 100;
        }
        
        /// <summary>
        /// Getting name of the motorcycle
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return Name;
        }

        private void SetName()
        {
            Name = $"Motorcycle {MotorcycleNumber}";
        }
        
        /// <summary>
        /// Constructor for the motorcycle instance.
        /// Setting new name
        /// </summary>
        public Motorcycle()
        {
            SetName();
            MotorcycleNumber += 1;
        }
        
        private void SetDistanceTraveled(int lapDistance)
        {
            DistanceTraveled += lapDistance;
        }
        
        /// <summary>
        /// get traveled distance
        /// </summary>
        /// <returns></returns>
        public int GetDistanceTraveled()
        {
            return DistanceTraveled;
        }

        /// <summary>
        /// setup the actual speed used for the current lap
        /// </summary>
        /// <param name="race"></param>
        /// <returns></returns>
        public override void PrepareForLap(Race race)
        {
            SetSpeed(race.IsRaining());
        }

        /// <summary>
        /// The vehicle travels for an hour. It increases the distance traveled.
        /// Call this from the Race::simulateRace() only!
        /// </summary>
        public override void MoveForAnHour()
        {
            SetDistanceTraveled(LapSpeed);
        }
    }
}