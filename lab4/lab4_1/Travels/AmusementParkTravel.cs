// Concrete implementation of the ITravelStrategy interface for organizing amusement park trips.
namespace lab4_1.Travels
{
    class AmusementParkTravel : ITravelStrategy
    {
        public void OrganizeTravel()
        {
            Console.WriteLine("Organizing AMUSEMENT PARK trip");
        }
    }
}
