using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_2
{
    // Interface for the automobile builder
    public interface IAutomobileBuilder
    {
        void SetEngine(string engineType);
        void SetTransmission(string transmissionType);
        void SetHeadlights(string headlightsType);
        void SetWheels(string wheelsType);
        void AddSafetySystem(string safetySystem);
        void AddOptionalFeature(string feature);
        Automobile GetAutomobile();
    }
}
