// Using the Factories namespace
using lab2.Factories;

namespace TextFormatting
{
    // Main program class
    class Program
    {
        // Main entry point
        static void Main()
        {
            // Creating an instance of EmployeeRepository
            EmployeeRepository employeeRepository = new EmployeeRepository();
            // Getting a list of employees from the repository
            List<Employee> employees = employeeRepository.GetEmployees();

            // User prompts to select the format type
            Console.WriteLine(">>> Enter a type you are about to format the database`s data");
            Console.WriteLine("> text - Format data to plain text");
            Console.WriteLine("> html - Format data to HTML");
            Console.WriteLine("> xml - Format data to XML");

            // Reading the user input
            string formatType = Console.ReadLine();

            // Getting the appropriate TextFormatterFactory based on user input
            TextFormatterFactory factory = GetFactory(formatType);

            // Formatting and displaying the data if a valid factory is obtained
            if (factory != null)
            {
                string formattedText = factory.GetFormatter().FormatText(employees);
                Console.WriteLine(formattedText);
            }
            else
            {
                Console.WriteLine("Invalid format entered");
            }
        }

        // Method to get the appropriate TextFormatterFactory based on user input
        private static TextFormatterFactory GetFactory(string formatType) =>
            formatType.ToLower() switch
            {
                "text" => new PlainTextFormatterFactory(),
                "html" => new HtmlTextFormatterFactory(),
                "xml" => new XmlTextFormatterFactory(),
                _ => null
            };
    }
}