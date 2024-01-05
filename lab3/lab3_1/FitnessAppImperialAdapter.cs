using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1
{
    // Adapter to use FitnessAppImperial as IFitnessApp
    public class FitnessAppImperialAdapter : FitnessAppImperial, IFitnessApp
    {
        // Implementing IFitnessApp interface methods by using methods from FitnessAppImperial
        public void RegisterUser(string username, string password, int age, double height, double weight)
        {
            this.RegisterUserWithTransferringFromImperialToMetric(username, password, age, height, weight);
        }

        public void ShowUserData()
        {
            this.ShowUserDataImperialFormat();
        }

        public void SyncDataWithDatabase()
        {
            this.ConvertAndSyncDataWithDatabase();
        }
    }
}
