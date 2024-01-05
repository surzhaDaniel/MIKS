using TextFormatting;

namespace lab2.TextFormatters
{
    // Interface definition for text formatters
    internal interface ITextFormatter
    {
        string FormatText(List<Employee> employees);
    }
}