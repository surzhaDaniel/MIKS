using lab2.TextFormatters;

namespace lab2.Factories
{
    // Abstract class for text formatter factories
    internal abstract class TextFormatterFactory
    {
        // Abstract method to get an instance of ITextFormatter
        public abstract ITextFormatter GetFormatter();
    }
}