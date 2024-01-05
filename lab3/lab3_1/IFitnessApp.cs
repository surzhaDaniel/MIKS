using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1
{
    // Interface defining the operations for a fitness application
    public interface IFitnessApp
    {
        void RegisterUser(string username, string password, int age, double height, double weight);
        void ShowUserData();
        void SyncDataWithDatabase();
    }
}
