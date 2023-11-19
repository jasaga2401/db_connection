using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        //  SQL Server connection string
        string connectionString = "Data Source=Amaze\\SQLEXPRESS;Initial Catalog=things_to_do;Integrated Security=True";

        // Create a new SqlConnection using the connection string
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                // Open the database connection
                connection.Open();
                Console.WriteLine("Connected to the database.");

                // Your database operations go here...

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                // Ensure the connection is closed, whether an exception occurs or not
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    Console.WriteLine("Connection closed.");
                }
            }
        }
    }
}

