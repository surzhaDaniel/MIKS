using TextFormatting;

namespace lab2.TextFormatters
{
    // Implementation of ITextFormatter for plain text formatting
    internal class PlainTextFormatter : ITextFormatter
    {
        // Method to format a list of employees to plain text
        public string FormatText(List<Employee> employees)
        {
            // Initializing the plain text result string
            string result = "PlainText:\n";
            // Looping through employees and adding plain text representation
            foreach (Employee employee in employees)
            {
                result += $"id: {employee.EmployeeId}\tName: {employee.Name}\n";
            }
            // Returning the formatted plain text string
            return result;
        }
    }
}