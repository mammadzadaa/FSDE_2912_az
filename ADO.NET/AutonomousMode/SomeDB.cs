using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutonomousMode
{
    class SomeDB : IDisposable
    {
        private SqlConnection _conn = new SqlConnection();

        public void OpenConnection()
        {
            _conn.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            _conn.Open();
        }

        public void CloseConnection()
        {
            _conn.Close();
        }

        public void Dispose()
        {
            CloseConnection();
        }

        public DataTable GetData()
        {
            var comm = new SqlCommand();
            comm.CommandText = "SELECT * FROM Products";
            comm.Connection = _conn;
            var result = comm.ExecuteReader();
            DataTable dt = new DataTable();
            for (int i = 0; i < result.FieldCount; i++)
            {
                dt.Columns.Add(new DataColumn(result.GetName(i)));
            }
            while (result.Read())
            {
                var row = dt.NewRow();
                for (int i = 0; i < result.FieldCount; i++)
                {
                    row[i] = result[i];
                }
                dt.Rows.Add(row);
            }
            result.Close();
            return dt;
        }
    }
}
