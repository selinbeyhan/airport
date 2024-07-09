using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;


namespace airport
{
    namespace MySQLConnectionExample
    {
        using System;
        using MySql.Data.MySqlClient;

        namespace MySQLConnectionExample
        {
            class Program
            {
                static void Main(string[] args)
                {
                    string server = "localhost";
                    string database = "airline"; 
                    string user = "admin"; 
                    string password = ""; 
                    string connectionString = $"server={server};user={user};database={database};port=3306;password={password}";

                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            Console.WriteLine("Connected to the database successfully.");

                            // Пример за вмъкване на данни
                            string insertQuery = "INSERT INTO your_table_name (name, age, email) VALUES (@name, @age, @email)";
                            using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn))
                            {
                                insertCommand.Parameters.AddWithValue("@name", "John Doe");
                                insertCommand.Parameters.AddWithValue("@age", 30);
                                insertCommand.Parameters.AddWithValue("@email", "john.doe@example.com");
                                insertCommand.ExecuteNonQuery();
                                Console.WriteLine("Data inserted successfully.");
                            }

                            // Пример за четене на данни
                            string selectQuery = "SELECT id, name, age, email FROM your_table_name";
                            using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, conn))
                            {
                                using (MySqlDataReader reader = selectCommand.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        Console.WriteLine($"ID: {reader["id"]}, Name: {reader["name"]}, Age: {reader["age"]}, Email: {reader["email"]}");
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                 
                    }
                }
            }
        }

    }

}
    

