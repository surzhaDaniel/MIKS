using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1
{
    // Implementation of the fitness application with imperial system
    public class FitnessAppImperial
    {
        // Private fields to store user information in the imperial system
        private string username;
        private string password;
        private int age;
        private double height;
        private double weight;

        // Method to register a user in the imperial system, converting to metric
        public void RegisterUserWithTransferringFromImperialToMetric(string username, string password, int age, double height, double weight)
        {
            this.username = username;
            this.password = password;
            this.age = age;
            this.height = height * ImperialToMetricConstants.InchesToMeters;
            this.weight = weight * ImperialToMetricConstants.PoundsToKilograms;
        }

        // Method to display user data in the imperial system
        public void ShowUserDataImperialFormat()
        {
            Console.WriteLine($"User: {username}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height} in");
            Console.WriteLine($"Weight: {weight} lbs");
        }

        // Method to convert and synchronize user data with the database in the imperial system
        public void ConvertAndSyncDataWithDatabase()
        {
            Console.WriteLine($"User data is synchronized with the database, namely: {age}, {height} -> {height / ImperialToMetricConstants.InchesToMeters}, {weight} -> {weight / ImperialToMetricConstants.PoundsToKilograms}");
        }
    }
}
