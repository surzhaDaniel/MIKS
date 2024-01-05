// Concrete implementation of the ITravelStrategy interface for organizing winery trips.
namespace lab4_1.Travels
{
    class WineryTravel : ITravelStrategy
    {
        public void OrganizeTravel()
        {
            Console.WriteLine("Organizing WINERY trip");
        }
    }
}