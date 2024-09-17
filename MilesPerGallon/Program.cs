// See https://aka.ms/new-console-template for more information
using System;
namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args) 
        {
            // User will input the amount of miles they've driven
            Console.Write("How many miles have you driven? ");
            int milesDriven = int.Parse(Console.ReadLine());
            

            // User will input the amount of gas they have used
            Console.Write("How many gallons of gas have you used? ");
            int gallonsUsed = int.Parse(Console.ReadLine());
            
             
             // Calculation that will give final MPG result
             double mpg = milesDriven / gallonsUsed;


            //Final message displaying the calculated final result of mpg
            Console.WriteLine($"Your MPG(Miles Per Gallon) results are: {mpg}");
            
        }
    }
}