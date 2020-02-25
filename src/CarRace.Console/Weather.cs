using System;

namespace CarRace.Console
{
    public class Weather
    {
        
        private readonly Random _random = new Random();
        
        private bool isRaining { get; set; }

        
        /// <summary>
        /// Function to get information if it raining or not
        /// </summary>
        /// <returns>true or false (boolean)</returns>
        public bool GetRaining()
        {
            isRaining = SetRaining();
            return isRaining;
        }

        private bool SetRaining()
        {
            int percentage = _random.Next(1, 101);
            return percentage <= 30;
        }
    }
}