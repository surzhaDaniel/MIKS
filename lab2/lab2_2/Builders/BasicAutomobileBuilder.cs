using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_2.Builders
{
    // Class for creating the basic configuration
    public class BasicAutomobileBuilder : IAutomobileBuilder
    {
        private readonly Automobile _automobile = new Automobile();

        public void SetEngine(string engineType)
        {
            _automobile.Engine = engineType;
        }
        public void SetTransmission(string transmissionType)
        {
            _automobile.Transmission = transmissionType;
        }
        public void SetHeadlights(string headlightsType)
        {
            _automobile.Headlights = headlightsType;
        }
        public void SetWheels(string wheelsType)
        {
            _automobile.Wheels = wheelsType;
        }
        public void AddSafetySystem(string safetySystem)
        {
            _automobile.SafetySystems.Add(safetySystem);
        }
        public void AddOptionalFeature(string feature)
        {
            _automobile.OptionalFeatures.Add(feature);
        }
        public Automobile GetAutomobile()
        {
            return _automobile;
        }
    }
}
