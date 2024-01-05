using System.Data.SqlClient;

namespace TextFormatting
{
    // Class for working with the database
    internal class EmployeeRepository
    {
        // Method to retrieve a list of employees from the database
        public List<Employee> GetEmployees()
        {
            // Initializing a list to store employees
            List<Employee> employees = new List<Employee>();

            // Database connection string and connection initialization
            string connectionString = @"Data Source=WIN-ABQ5UODH45N\SQLEXPRESS;Initial Catalog=EmployeeDatabase;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL query to select EmployeeId and Name from Employees table
                string query = "SELECT EmployeeId, Name FROM Employees";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Reading data using SqlDataReader and populating the employees list
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee employee = new Employee
                            {
                                EmployeeId = reader.GetInt32(0),
                                Name = reader.GetString(1)
                            };
                            employees.Add(employee);
                        }
                    }
                }
            }
            // Returning the list of employees
            return employees;
        }
    }
}