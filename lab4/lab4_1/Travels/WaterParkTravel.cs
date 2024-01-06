// Concrete implementation of the ITravelStrategy interface for organizing water park trips.
namespace lab4_1.Travels
{
    class WaterParkTravel : ITravelStrategy
    {
        public void OrganizeTravel()
        {
            Console.WriteLine("Organizing WATER PARK trip");
        }
    }
}