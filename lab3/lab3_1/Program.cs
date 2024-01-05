using System;

namespace lab3_1
{
    // Main program
    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of fitness applications
            IFitnessApp fitnessAppMetric = new FitnessAppMetric();
            IFitnessApp imperialImperialAdapter = new FitnessAppImperialAdapter();

            // Registering and displaying user data in the metric app
            fitnessAppMetric.RegisterUser("John", "password", 25, 180, 75);
            Console.WriteLine("User's data in metric app:");
            fitnessAppMetric.ShowUserData();
            Console.WriteLine("--------------------");
            fitnessAppMetric.SyncDataWithDatabase();
            Console.WriteLine("--------------------\n\n");

            // Registering and displaying user data in the imperial app using the adapter
            imperialImperialAdapter.RegisterUser("Jane", "password", 30, 70, 160);
            Console.WriteLine("User's data in imperial app:");
            imperialImperialAdapter.ShowUserData();
            imperialImperialAdapter.SyncDataWithDatabase();
            Console.WriteLine("--------------------\n");
        }
    }
}
