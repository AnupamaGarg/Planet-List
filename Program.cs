using System;
using System.Collections.Generic;

namespace planets_and_spaceShips
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};


            // Add() Jupiter and Saturn at the end of the list.
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            planetList.ForEach(planet=>Console.WriteLine(planet));

            Console.WriteLine("-------------");






            // Create another List that contains that last two planet of our solar system.

            List<string> lastPlanets = new List<string>(){
                 "Uranus","Neptune"
            };


            // Combine the two lists by using AddRange().

            planetList.AddRange(lastPlanets);
            planetList.ForEach(planet=>Console.WriteLine(planet));

            Console.WriteLine("-------------");



            // Use Insert() to add Earth, and Venus in the correct order.
                 planetList.Insert(1 ,"Venus");
                  planetList.Insert(2 ,"Earth");
                  
                  planetList.ForEach(planet=>Console.WriteLine(planet));
                  Console.WriteLine("-------------");



            // Use Add() again to add Pluto to the end of the list.
          

               planetList.Add("Pluto");
               planetList.ForEach(planet=>Console.WriteLine(planet));
               Console.WriteLine("-------------");




            // Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets
            //  into a new list called rockyPlanets.
            //  The rocky planets will remain in the original planets list.
            List<string> rockyPlanets = new List<string>();
            rockyPlanets = planetList.GetRange(0,4);
            // string[] rockyPlanets = planetList.GetRange(0,4).ToArray();
            foreach(string planet in rockyPlanets){
                Console.WriteLine($"Rocky Planets: {planet}");
            }

             Console.WriteLine("-------------");


                planetList.Remove("Pluto");

            
            planetList.ForEach(planet=>Console.WriteLine(planet));
            
                  Console.WriteLine("-------------");


             
            // Being good amateur astronomers, we know that Pluto is now a dwarf planet, 
            // so use the Remove() method to eliminate it from the end of planetList.
         
        }
    }
}
