using Microsoft.Data.SqlClient;
using System;

namespace AdoIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionStringBuilder = new SqlConnectionStringBuilder();
            connectionStringBuilder.DataSource = @"localhost\SQLEXPRESS";
            connectionStringBuilder.InitialCatalog = "StepITAcademy";
            connectionStringBuilder.IntegratedSecurity = true;

            Console.WriteLine(connectionStringBuilder.ToString());
            using (var connection = new SqlConnection(connectionStringBuilder.ToString()))
            {
                connection.Open();
                Console.WriteLine("Connection is open!\n");                
                //var querry = "INSERT INTO Students VALUES('Zabil','Hajiyev','2001-04-29',1000,'zabil001@mail.ru')";
                var querry = "SELECT * FROM Students";
                var command = new SqlCommand(querry, connection);
                //command.ExecuteNonQuery();
                var result = command.ExecuteReader();
                while (result.Read())
                {
                    Console.Write((int)result[0]);
                    Console.WriteLine(" " + (string)result[1]);
                }
            }
            Console.WriteLine("Connection closed!\n");


        }
    }
}
