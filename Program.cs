using System;
using System.Collections.Generic;
namespace Lists_Justin_palmer
{
    internal class Program
    {
        static void Main(string[] args)
        { // List names in a liust containing stirng values "CS:GO" Halo 3 Borderlands 3 Fifa 22 Minecraft 
            List<string> games = new List<string> {

                "CS:GO",
                "Halo 3",
                "Borderlands 3",
                "Fifa 22",
                "Minecraft"
            };
            // Other Games Tiny Tina's Wonderlands Farcry 3
            string[] otherGames = new string[]
            {
             "Tiny Tina's Wonderlands",
             "Farcry 3"
            };
            // Foreach loop 
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }
             // \n block in games in list add range sequential elements 
            Console.WriteLine($"\nGame in list; {games.Count}");

            games.AddRange(otherGames);

            Console.WriteLine($"\nGame in list; {games.Count}");

            if (games.Contains("Halo"))
            {
                Console.WriteLine("\nMASTER CHIEF IS IN THE HOUSE !!");
            }
            else
            {
                games.Add("Halo");
            }
            // if the list method is returns true if it's argument exists in the list otherwise false 
            int myInt = 6;

            if (myInt < games.Count)
            {
                games.RemoveAt(myInt);
            }
            else
            {
                Console.WriteLine("\nGame not found!");
            }

            Console.WriteLine("\nAll games in the list:'");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            games.Sort();

            Console.WriteLine("\nSorted game list:");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }
            string[] newList = new string[games.Count];

            games.CopyTo(newList);

            games.Clear();

            Console.WriteLine("\nNew List:");
            foreach(string game in newList)
            {
                Console.WriteLine(game);
            }
        }
    }


}