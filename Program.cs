using System;
using System.Collections.Generic;

namespace C_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
// Add() Jupiter and Saturn at the end of the list.
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            // planetList.ForEach(planet => Console.WriteLine(planet));

// Create another List that contains that last two planet of our solar system.
            List<string> lastTwo = new List<string>(){"Uranus", "Neptune"};
            // lastTwo.ForEach(planet => Console.WriteLine("Last two planets: " + planet));

// Combine the two lists by using AddRange()
            planetList.AddRange(lastTwo);
            // planetList.ForEach(planet => Console.WriteLine("The total planets are " + planet));

// Use Insert() to add Earth, and Venus in the correct order.
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            // planetList.ForEach(planet => Console.WriteLine(planet));

// Use Add() again to add Pluto to the end of the list.
             planetList.Add("Pluto");
            //  planetList.ForEach(planet => Console.WriteLine(planet));

// Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets. The rocky planets will remain in the original planets list.
            List<string> rockyPlanets = new List<string>(){};
            rockyPlanets = planetList.GetRange(0,4);
            // rockyPlanets.ForEach(planet => Console.WriteLine(planet));

// Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.
        planetList.RemoveRange(8,1);
        planetList.ForEach(planet => Console.WriteLine(planet));


 //--------------------------------------------------------------------------------------------------------
        Random random = new Random();
        List<int> numbers = new List<int> {
            random.Next(10),
            random.Next(10),
            random.Next(10),
            random.Next(10),
            random.Next(10),
        };


// Use a for loop to iterate over all numbers between 0 and numbers.Count - 1.
            for (int i= 0; i <= numbers.Count - 1; i++){
                // Console.WriteLine(i);

                if (numbers.Contains(i)){
                    Console.WriteLine($"Numbers list contains {i}");
                } else {
                    Console.WriteLine($"Numbers list does not contain {i}");
                }
            }
        }
    }
}