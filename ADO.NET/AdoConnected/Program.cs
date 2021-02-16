using System;
using System.Data.SqlClient;
using System.Configuration;


namespace AdoConnected
{
    class Program
    {
        static void Main(string[] args)
        {
           
            using (var conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
                conn.Open();
                Console.WriteLine(ConfigurationManager.ConnectionStrings["Connection"]);
                Console.WriteLine("Connection is Open");
                var command = new SqlCommand();

                command.Parameters.Add(new SqlParameter("Name", "'; DROP TABLE Teachers --"));

                //string name = "'; DROP TABLE Temp --";
                //command.CommandText = $"SELECT * FROM Students WHERE FirstName = '{name}'";
                command.CommandText = $"SELECT * FROM Students WHERE FirstName = @Name";

                var transaction = conn.BeginTransaction();
                command.Transaction = transaction;
                command.Connection = conn;

                try
                {
                    var result = command.ExecuteReader();
                    transaction.Commit();
                    while (result.Read())
                    {
                        Console.WriteLine((int)result[0]);
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                }
            }
            Console.WriteLine("Connection is Closed");
        }
    }
}
