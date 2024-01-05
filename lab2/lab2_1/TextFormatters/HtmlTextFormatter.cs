using TextFormatting;

namespace lab2.TextFormatters
{
    // Implementation of ITextFormatter for HTML formatting
    internal class HtmlTextFormatter : ITextFormatter
    {
        // Method to format a list of employees to HTML
        public string FormatText(List<Employee> employees)
        {
            // Initializing the HTML result string
            string result = "<html>\n<body>\n<table border='1'>\n<tr><th>Employee ID</th><th>Name</th></tr>\n";
            // Looping through employees and adding HTML table rows
            foreach (var employee in employees)
            {
                result += $"<tr><td>{employee.EmployeeId}</td><td>{employee.Name}</td></tr>\n";
            }
            result += "</table>\n</body>\n</html>";
            // Returning the formatted HTML string
            return result;
        }
    }
}