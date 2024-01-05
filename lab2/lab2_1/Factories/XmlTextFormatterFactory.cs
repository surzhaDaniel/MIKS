using lab2.TextFormatters;

namespace lab2.Factories
{
    // Implementation of TextFormatterFactory for XML text formatter
    internal class XmlTextFormatterFactory : TextFormatterFactory
    {
        // Method to create an instance of XmlTextFormatter
        public override ITextFormatter GetFormatter()
        {
            return new XmlTextFormatter();
        }
    }
}