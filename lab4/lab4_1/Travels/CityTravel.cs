// Concrete implementation of the ITravelStrategy interface for organizing city tours.
namespace lab4_1.Travels
{
    public class CityTravel : ITravelStrategy
    {
        public void OrganizeTravel()
        {
            Console.WriteLine("Organizing CITY tour");
        }
    }
}
