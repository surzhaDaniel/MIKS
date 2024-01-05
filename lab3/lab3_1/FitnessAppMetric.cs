using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1
{
    // Metric implementation of the fitness application
    public class FitnessAppMetric : IFitnessApp
    {
        // Private fields to store user information
        private string username;
        private string password;
        private int age;
        private double height;
        private double weight;

        // Method to register a user in the metric system
        public void RegisterUser(string username, string password, int age, double height, double weight)
        {
            this.username = username;
            this.password = password;
            this.age = age;
            this.height = height;
            this.weight = weight;
        }

        // Method to display user data in the metric system
        public void ShowUserData()
        {
            Console.WriteLine($"User: {username}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height} cm");
            Console.WriteLine($"Weight: {weight} kg");
        }

        // Method to synchronize user data with the database in the metric system
        public void SyncDataWithDatabase()
        {
            Console.WriteLine($"User data is synchronized with the database, namely: {age}, {height}, {weight}");
        }
    }
}
