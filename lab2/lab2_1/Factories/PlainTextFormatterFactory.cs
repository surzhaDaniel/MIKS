using lab2.TextFormatters;

namespace lab2.Factories
{
    // Implementation of TextFormatterFactory for plain text formatter
    internal class PlainTextFormatterFactory : TextFormatterFactory
    {
        // Method to create an instance of PlainTextFormatter
        public override ITextFormatter GetFormatter()
        {
            return new PlainTextFormatter();
        }
    }
}