using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2_2.Builders;

namespace lab2_2.Directors
{
    // Concrete class for the automobile director
    public class AutomobileDirector : IAutomobileDirector
    {
        public void ConstructBasicAutomobile(IAutomobileBuilder builder)
        {
            builder.SetEngine("V6");
            builder.SetTransmission("Automatic");
            builder.SetHeadlights("LED");
            builder.SetWheels("18-inch alloy");
            builder.AddSafetySystem("ABS");
            builder.AddSafetySystem("Airbags");
            builder.AddOptionalFeature("Bluetooth Connectivity");
        }
        public void ConstructLuxuryAutomobile(IAutomobileBuilder builder)
        {
            builder.SetEngine("V8");
            builder.SetTransmission("Automatic");
            builder.SetHeadlights("Xenon");
            builder.SetWheels("20-inch alloy");
            builder.AddSafetySystem("ABS");
            builder.AddSafetySystem("Airbags");
            builder.AddOptionalFeature("Premium Audio System");
        }
        public void ConstructSportsCar(IAutomobileBuilder builder)
        {
            builder.SetEngine("V8");
            builder.SetTransmission("Automatic");
            builder.SetHeadlights("LED");
            builder.SetWheels("19-inch alloy");
            builder.AddSafetySystem("ABS");
            builder.AddSafetySystem("Airbags");
            builder.AddOptionalFeature("Sports Suspension");
            builder.AddOptionalFeature("Aerodynamic Design");
        }
        public void ConstructSUV(IAutomobileBuilder builder)
        {
            builder.SetEngine("V6");
            builder.SetTransmission("Automatic");
            builder.SetHeadlights("LED");
            builder.SetWheels("20-inch off-road");
            builder.AddSafetySystem("ABS");
            builder.AddSafetySystem("Airbags");
            builder.AddOptionalFeature("Off-Road Suspension");
            builder.AddOptionalFeature("4x4 Drive");
        }
    }
}
