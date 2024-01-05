// Concrete implementation of the ITravelStrategy interface for organizing theater trips.
namespace lab4_1.Travels
{
    class TheaterTravel : ITravelStrategy
    {
        public void OrganizeTravel()
        {
            Console.WriteLine("Organizing THEATER trip");
        }
    }
}
