using TextFormatting;

namespace lab2.TextFormatters
{
    // Implementation of ITextFormatter for XML formatting
    internal class XmlTextFormatter : ITextFormatter
    {
        // Method to format a list of employees to XML
        public string FormatText(List<Employee> employees)
        {
            // Initializing the XML result string
            string result = "<Employees>\n";
            // Looping through employees and adding XML elements
            foreach (var employee in employees)
            {
                result += $"\t<Employee>\n\t\t<EmployeeId>{employee.EmployeeId}</EmployeeId>\n\t\t<Name>{employee.Name}</Name>\n\t</Employee>\n";
            }
            result += "</Employees>";
            // Returning the formatted XML string
            return result;
        }
    }
}