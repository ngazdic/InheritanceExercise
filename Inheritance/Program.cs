using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

            var bird1 = new Bird();
            var reptile1 = new Reptiles();

            bird1.Age = 6;
            bird1.Name = "Hawk";
            bird1.Species = "Bird";
            bird1.Mammal = false;
            bird1.Migratory = false;
            bird1.Predators = true;
            bird1.FeatherColors = "Grey and white";
            bird1.Flyspeed = 120;



            reptile1.Age = 2;
            reptile1.Name = "Gecko";
            reptile1.Species = "Lizzard";
            reptile1.LifeExpectancy = 6;
            reptile1.LiveInWater = false;
            reptile1.Mammal = false;
            reptile1.NumberOfLegs = 4;
            reptile1.SkinColor = "Green";

            Console.WriteLine("ANIMALS");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Bird:");
            Console.WriteLine();
            Console.WriteLine($"Age:{bird1.Age}\nName:{bird1.Name}\n" +
                $"Species:{bird1.Species}\nMigratory:{bird1.Migratory}\nPredator? {bird1.Predators}\n" +
                $"Mammal? {bird1.Mammal}\nFeather Colors:{bird1.FeatherColors}\nFly Speed:{bird1.Flyspeed}");


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Lizzard:");
            Console.WriteLine();
            Console.WriteLine($"Age:{reptile1.Age}\nName:{reptile1.Name}\n" +
                $"Species:{reptile1.Species}\nLife Expectancy:{reptile1.LifeExpectancy}\nWater Animal? {reptile1.LiveInWater}\n" +
                $"Mammal? {reptile1.Mammal}\nNumber Of Legs:{reptile1.NumberOfLegs}\nSkin Color:{reptile1.SkinColor}");



            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
