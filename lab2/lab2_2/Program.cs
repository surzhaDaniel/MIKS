using System;
using System.Collections.Generic;
using lab2_2.Builders;
using lab2_2.Directors;

namespace lab2_2
{
    // Main program class
    class Program
    {
        static void Main()
        {
            // Use the director to create automobiles
            IAutomobileDirector director = new AutomobileDirector();

            IAutomobileBuilder basicBuilder = new BasicAutomobileBuilder();
            director.ConstructBasicAutomobile(basicBuilder);
            Automobile basicAutomobile = basicBuilder.GetAutomobile();
            Console.WriteLine("Basic Automobile Configuration:");
            basicAutomobile.ShowConfiguration();

            Console.WriteLine("\n--------------------------\n");

            IAutomobileBuilder luxuryBuilder = new LuxuryAutomobileBuilder();
            director.ConstructLuxuryAutomobile(luxuryBuilder);
            Automobile luxuryAutomobile = luxuryBuilder.GetAutomobile();
            Console.WriteLine("Luxury Automobile Configuration:");
            luxuryAutomobile.ShowConfiguration();

            Console.WriteLine("\n--------------------------\n");

            IAutomobileBuilder sportsCarBuilder = new SportsCarBuilder();
            director.ConstructSportsCar(sportsCarBuilder);
            Automobile sportsCar = sportsCarBuilder.GetAutomobile();
            Console.WriteLine("Sports Car Configuration:");
            sportsCar.ShowConfiguration();

            Console.WriteLine("\n--------------------------\n");

            IAutomobileBuilder suvBuilder = new SUVBuilder();
            director.ConstructSUV(suvBuilder);
            Automobile suv = suvBuilder.GetAutomobile();
            Console.WriteLine("SUV Configuration:");
            suv.ShowConfiguration();
        }
    }
}
