# Car race

Your task will be to simulate a race.  You will need to create 10
cars, 10 trucks, 10 motorcycles, and race them for 50 hours.  After
simulating the race print the results.

As a guideline here are the classes you will need to create and some
of their functions/properties.  Note that this is just a skeleton, feel
free to add more methods/variables.  But you must implement the ones
described here!

```csharp
  Program
   public static void Main(String[]) // The entry point of our program.
  
  Race
   SimulateRace() // simulates the race by
                  // - calling MoveForAnHour() on every vehicle 50 times
                  // - setting whether its raining
   PrintRaceResults() // prints each vehicle's name, distance traveled ant type.
   boolean IsThereABrokenTruck() // returns true if there is a broken truck on track

  Weather
   boolean Raining // property which gives back is it raining or not. 30% chance of rain

  Car // If there is a broken down Truck on the track, then limit the max speed of cars to 75 km/h.
   NormalSpeed // the normal speed of the car. Set to a random number in the constructor between 80-110km/h.
   Name // Make a list from the words here: http://www.fantasynamegenerators.com/car-names.php and pick 2 randomly for each instance.
   DistanceTraveled // holds the summarized distance traveled in the race.
   PrepareForLap(Race race) // setup the actual speed used for the current lap
   MoveForAnHour() // The vehicle travels for an hour. It increases the distance traveled. Call this from the Race::SimulateRace() only!

  Motorcycle // speed is 100km/h. If it rains, travels with 5-50km/h slower (randomly). Doesn't care about trucks.
   MotorcycleNumber // The number of the instance created. Used for its name.
   Name // Are called "Motorcycle 1", "Motorcycle 2", "Motorcycle 3",... Unique.
   DistanceTraveled // holds the summarized distance traveled in the race.
   PrepareForLap(Race race) // setup the actual speed used for the current lap
   MoveForAnHour() // The vehicle travels for an hour. It increases the distance traveled. Call this from the Race::SimulateRace() only!
  
  Truck // speed: 100km/h. 5% chance of breaking down for 2 turns.
   // Truck drivers are boring. They call all their trucks a random number between 0 and 1000.
   BreakdownTurnsLeft // holds how long its still broken down.
   DistanceTraveled // holds the summarized distance traveled in the race.
   PrepareForLap(Race race) // setup the actual speed used for the current lap
   MoveForAnHour() // The vehicle travels for an hour. It increases the distance traveled. Call this from the Race::SimulateRace() only!
```

## Hints

> Have you noticed that Car, Motorcycle and Truck share some similarities? Use inheritance to abstract away common parts.<br />
> Use the built-in Random class to generate random numbers. Implement a util class around it, if you find it useful.

## Static code analyzer for the sake of style guideline

> <span style="color: red">WATCH OUT!</span> The project contains static code analyzer, named [StyleCop](https://github.com/StyleCop/StyleCop), which prevents you to successfully build your project in case of any violation of <br />
> * naming
> * commenting
> * other style convention and guidance!