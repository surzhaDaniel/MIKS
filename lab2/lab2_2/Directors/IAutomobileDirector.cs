using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2_2.Builders;

namespace lab2_2.Directors
{
    // Interface for the automobile director
    public interface IAutomobileDirector
    {
        void ConstructBasicAutomobile(IAutomobileBuilder builder);
        void ConstructLuxuryAutomobile(IAutomobileBuilder builder);
        void ConstructSportsCar(IAutomobileBuilder builder);
        void ConstructSUV(IAutomobileBuilder builder);
    }
}
