using lab4_1.Travels;
using System;

namespace lab4_1
{
    // Represents the main program entry point.
    class Program
    {
        static void Main(string[] args)
        {
            // Prompting the user to enter the number of people in each age group.
            Console.WriteLine("Enter amount of children: ");
            int amoutOfChildren = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount of teens: ");
            int amountOfTeens = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount of adults: ");
            int amountOfAdults = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount of seniors: ");
            int amountOfSeniors = Convert.ToInt32(Console.ReadLine());

            // Creating an instance of TravelOrganizer.
            TravelOrganizer travelOrganizer = new TravelOrganizer();

            // Setting the travel strategy based on the defined criteria.
            travelOrganizer.SetTravelStrategy(DefineTravel(amoutOfChildren, amountOfTeens, amountOfAdults, amountOfSeniors));

            // Organizing the travel based on the selected strategy.
            travelOrganizer.OrganizeTravel();
        }

        // Determines the appropriate travel strategy based on the number of people in each age group.
        static public ITravelStrategy DefineTravel(int amoutOfChildren, int amountOfTeens, int amountOfAdults, int amountOfSeniors)
        {
            // Checking for invalid input where the total number of people is zero or any negative values.
            if (amoutOfChildren < 0 || amountOfTeens < 0 || amountOfAdults < 0 || amountOfSeniors < 0 || (amoutOfChildren + amountOfTeens + amountOfAdults + amountOfSeniors) == 0)
            {
                return null; // Return null in case of invalid input.
            }
            // Selecting the appropriate strategy based on the maximum count in an age group.
            else if (amoutOfChildren > amountOfTeens && amoutOfChildren > amountOfAdults && amoutOfChildren > amountOfSeniors)
            {
                return new WaterParkTravel(); // Return WaterParkTravel strategy.
            }
            else if (amountOfTeens > amoutOfChildren && amountOfTeens > amountOfAdults && amountOfTeens > amountOfSeniors)
            {
                return new AmusementParkTravel(); // Return AmusementParkTravel strategy.
            }
            else if (amountOfAdults > amoutOfChildren && amountOfAdults > amountOfTeens && amountOfAdults > amountOfSeniors)
            {
                return new WineryTravel(); // Return WineryTravel strategy.
            }
            else if (amountOfSeniors > amoutOfChildren && amountOfSeniors > amountOfTeens && amountOfSeniors > amountOfAdults)
            {
                return new TheaterTravel(); // Return TheaterTravel strategy.
            }
            else
            {
                return new CityTravel(); // Return CityTravel strategy as a default option.
            }
        }
    }
}
