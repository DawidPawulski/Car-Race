Main
 static main(String[]) // The entry point of our program.

Race
 simulateRace() // simulates the race by
                // - calling moveForAnHour() on every vehicle 50 times
                // - setting whether its raining
 printRaceResults() // prints each vehicle's name, distance traveled ant type.
 boolean isThereABrokenTruck() // returns true if there is a broken truck on track

Weather
 setRaining() // 30% chance of rain.
 boolean isRaining() // is it raining currently.

Car // If there is a broken down Truck on the track, then limit the max speed of cars to 75 km/h.
 normalSpeed // the normal speed of the car. Set to a random number in the constructor between 80-110km/h.
 name // Make a list from the words here: http://www.fantasynamegenerators.com/car-names.php and pick 2 randomly for each instance.
 distanceTraveled // holds the summarized distance traveled in the race.
 prepareForLap(Race race) // setup the actual speed used for the current lap
 moveForAnHour() // The vehicle travels for an hour. It increases the distance traveled. Call this from the Race::simulateRace() only!

Motorcycle // speed is 100km/h. If it rains, travels with 5-50km/h slower (randomly). Doesn't care about trucks.
 motorcycleNumber // The number of the instance created. Used for its name.
 name // Are called "Motorcycle 1", "Motorcycle 2", "Motorcycle 3",... Unique.
 distanceTraveled // holds the summarized distance traveled in the race.
 prepareForLap(Race race) // setup the actual speed used for the current lap
 moveForAnHour() // The vehicle travels for an hour. It increases the distance traveled. Call this from the Race::simulateRace() only!

Truck // speed: 100km/h. 5% chance of breaking down for 2 turns.
 name // Truck drivers are boring. They call all their trucks a random number between 0 and 1000.
 breakdownTurnsLeft // holds how long its still broken down.
 distanceTraveled // holds the summarized distance traveled in the race.
 prepareForLap(Race race) // setup the actual speed used for the current lap
 moveForAnHour() // The vehicle travels for an hour. It increases the distance traveled. Call this from the Race::simulateRace() only!