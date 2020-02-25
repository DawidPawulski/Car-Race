using System;

namespace CarRace.Console
{
    /// <summary>
    /// // If there is a broken down Truck on the track, then limit the max speed of cars to 75 km/h.
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// the normal speed of the car. Set to a random number in the constructor between 80-110km/h.
        /// </summary>
        /// <returns></returns>
        private int NormalSpeed { get; set; }
        
        private int LapSpeed { get; set; }

        /// <summary>
        /// Make a list from the words here: http://www.fantasynamegenerators.com/car-names.php and pick 2 randomly for each instance.
        /// </summary>
        private string Name { get; set; }
        
        /// <summary>
        /// holds the summarized distance traveled in the race.
        /// </summary>
        private int DistanceTraveled { get; set; }


        private void SetDistanceTraveled(int lapDistance)
        {
            DistanceTraveled += lapDistance;
        }
        
        public int GetDistanceTraveled()
        {
            return DistanceTraveled;
        }

        private void SetSpeed()
        {
            Random random = new Random();
            NormalSpeed = random.Next(80, 111);
        }

        private void SetName()
        {
            string[] possibleNames =
            {
                "Dragon", "Parallel", "Morale", "Blade", "Empyrean", "Mystery", "Deputy",
                "Dynamics", "Thunder", "Albatross"
            };
            
            Random random = new Random();
            int firstRandomNum = random.Next(0, 10);
            int secondRandomNum = random.Next(0, 10);
            while (secondRandomNum == firstRandomNum)
            {
                secondRandomNum = random.Next(0, 10);
            }

            Name = possibleNames[firstRandomNum] + " " + possibleNames[secondRandomNum];
        }

        public string GetName()
        {
            return Name;
        }
        
        
        public Car()
        {
            SetSpeed();
            SetName();
        }
        
        
        
        /// <summary>
        /// setup the actual speed used for the current lap
        /// </summary>
        /// <param name="race"></param>
        /// <returns></returns>
        public override void PrepareForLap(Race race)
        {
            LapSpeed = race.IsThereABrokenTruck() ? 75 : NormalSpeed;
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