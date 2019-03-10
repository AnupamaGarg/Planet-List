using System;
using System.Collections.Generic;

namespace planets_and_spaceShips
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };


            // Add() Jupiter and Saturn at the end of the list.
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            planetList.ForEach(planet => Console.WriteLine(planet));

            Console.WriteLine("------AddRange to add lastplanet list-------");






            // Create another List that contains that last two planet of our solar system.

            List<string> lastPlanets = new List<string>(){
                 "Uranus","Neptune"
            };


            // Combine the two lists by using AddRange().

            planetList.AddRange(lastPlanets);
            planetList.ForEach(planet => Console.WriteLine(planet));

            Console.WriteLine("-----insert Venus and Earth--------");



            // Use Insert() to add Earth, and Venus in the correct order.
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            planetList.ForEach(planet => Console.WriteLine(planet));
            Console.WriteLine("--------Add Pluto-----");



            // Use Add() again to add Pluto to the end of the list.


            planetList.Add("Pluto");
            planetList.ForEach(planet => Console.WriteLine(planet));
            Console.WriteLine("-----Rockey Planet List using GetRange methode--------");




            // Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets
            //  into a new list called rockyPlanets.
            //  The rocky planets will remain in the original planets list.
            List<string> rockyPlanets = new List<string>();
            rockyPlanets = planetList.GetRange(0, 4);
            // string[] rockyPlanets = planetList.GetRange(0,4).ToArray();
            foreach (string planet in rockyPlanets)
            {
                Console.WriteLine($"Rocky Planets: {planet}");
            }

            Console.WriteLine("-------Remove Pluto------");


            planetList.Remove("Pluto");


            planetList.ForEach(planet => Console.WriteLine(planet));

            Console.WriteLine("---- Random Numbers---------");



            // Being good amateur astronomers, we know that Pluto is now a dwarf planet, 
            // so use the Remove() method to eliminate it from the end of planetList.

            //////////////////////////////////////////////RANDOM NUMBERS////////////////////////////////////////////

            //    Use the following code to create a list of random numbers. Each number will be between 0 and 9.
            Random random = new Random();
            List<int> numbers = new List<int> {
                 random.Next(10),
                 random.Next(10),
                 random.Next(10),
                 random.Next(10),
                 random.Next(10),
                 };
   


             for(int i = 0; i < numbers.Count-1; i++){
              if(numbers.Contains(i)){
                  Console.WriteLine($"Number List contains {i}");
              } else
              {
                  Console.WriteLine($"Number List does not contains {i}");
              }
              };



            // Use a for loop to iterate over all numbers between 0 and numbers.Count - 1.
            // Inside the body of the for loop determine if the current loop index is contained inside of the numbers list. Print a message to the console indicating whether the index is in the list.



        }

       

       
    }
}
