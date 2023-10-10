using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var eagle = new Bird();
            eagle.Name = "Eagle";
            eagle.HaveTeeth = false;
            eagle.SkinType = "feathers";
            eagle.CanFly = true;
            eagle.WingSpan = 6;
            eagle.EdibleByHumans = false;

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             * Creatively display the class member values 
             */

            var lizard = new Reptile();
            lizard.Name = "Gecko";
            lizard.HaveTeeth = true;
            lizard.SkinType = "scales";


            var zoo = new List<Animal>() { eagle, lizard };

            foreach (var animal in zoo)
            {
                Console.WriteLine($"This is a {animal.Name} and it has a {animal.SkinType}");

            }

        }




    }
}
