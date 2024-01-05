using lab2.TextFormatters;

namespace lab2.Factories
{
    // Implementation of TextFormatterFactory for HTML text formatter
    internal class HtmlTextFormatterFactory : TextFormatterFactory
    {
        // Method to create an instance of HtmlTextFormatter
        public override ITextFormatter GetFormatter()
        {
            return new HtmlTextFormatter();
        }
    }
}