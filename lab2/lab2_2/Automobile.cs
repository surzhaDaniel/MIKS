using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_2
{
    // Class representing an automobile
    public class Automobile
    {
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public string Headlights { get; set; }
        public string Wheels { get; set; }
        public List<string> SafetySystems { get; set; }
        public List<string> OptionalFeatures { get; set; }
        public Automobile()
        {
            SafetySystems = new List<string>();
            OptionalFeatures = new List<string>();
        }
        // Method to display the configuration of the automobile
        public void ShowConfiguration()
        {
            Console.WriteLine($"Engine: {Engine}");
            Console.WriteLine($"Transmission: {Transmission}");
            Console.WriteLine($"Headlights: {Headlights}");
            Console.WriteLine($"Wheels: {Wheels}");

            Console.WriteLine("Safety Systems:");
            foreach (var system in SafetySystems)
            {
                Console.WriteLine($"\t- {system}");
            }
            Console.WriteLine("Optional Features:");
            foreach (var feature in OptionalFeatures)
            {
                Console.WriteLine($"\t- {feature}");
            }
        }
    }
}
