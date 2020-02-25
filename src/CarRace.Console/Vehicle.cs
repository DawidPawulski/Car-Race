namespace CarRace.Console
{
    public abstract class Vehicle
    {
        /// <summary>
        /// setup the actual speed used for the current lap
        /// </summary>
        /// <param name="race"></param>
        /// <returns></returns>
        public abstract void PrepareForLap(Race race);

        /// <summary>
        /// The vehicle travels for an hour. It increases the distance traveled. Call
        /// </summary>
        public abstract void MoveForAnHour();

    }
}