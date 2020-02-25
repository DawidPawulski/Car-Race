using System;

namespace CarRace.Console
{
    /// <summary>
    /// speed: 100km/h. 5% chance of breaking down for 2 turns.
    /// </summary>
    public class Truck : Vehicle
    {
        private readonly Random _random = new Random();
        
        /// <summary>
        /// holds how long its still broken down.
        /// </summary>
        /// <returns></returns>
        private int BreakdownTurnsLeft { get; set; }

        /// <summary>
        /// Truck drivers are boring. They call all their trucks a random number between 0 and 1000.
        /// </summary>
        private string Name { get; set; }
        
        /// <summary>
        /// holds the summarized distance traveled in the race.
        /// </summary>
        private int DistanceTraveled { get; set; }

        /// <summary>
        /// return true if the truck get broken after a lap
        /// </summary>
        public bool IsBroken { get; set; } = false;
        
        private int LapSpeed { get; set; }

        /// <summary>
        /// constructor. Set new name for the truck
        /// </summary>
        public Truck()
        {
            SetName();
        }

        private void SetIsBroken()
        {
            int brakePercentage = _random.Next(0, 101);
            IsBroken = brakePercentage <= 5;
            BreakdownTurnsLeft = IsBroken ? 2 : 0;

        }
        
        private void SetName()
        {
            int truckNumber = _random.Next(0, 1001);
            Name = $"{truckNumber}";
        }
        
        public string GetName()
        {
            return Name;
        }
        
        private void SetLapSeed()
        {
            if (BreakdownTurnsLeft > 0)
            {
                LapSpeed = 0;
            }
            else
            {
                LapSpeed = 100;
            }
        }

        private void SetDistanceTraveled(int lapDistance)
        {
            DistanceTraveled += lapDistance;
        }
        
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
            SetLapSeed();
            SetIsBroken();
        }

        /// <summary>
        /// The vehicle travels for an hour. It increases the distance traveled.
        /// Call this from the Race::simulateRace() only!
        /// </summary>
        public override void MoveForAnHour()
        {
            SetDistanceTraveled(LapSpeed);
            BreakdownTurnsLeft -= 1;
        }
    }
}