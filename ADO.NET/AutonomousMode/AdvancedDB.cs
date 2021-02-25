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
    class AdvancedDB
    {
        private SqlConnection _conn;
        private SqlDataAdapter itemsAdapter;
        public DataSet DataSet { get; }

        public AdvancedDB()
        {
            _conn = new SqlConnection();
            _conn.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            DataSet = new DataSet();
            itemsAdapter = new SqlDataAdapter();

            itemsAdapter.SelectCommand = new SqlCommand("SELECT * FROM Products", _conn);
            itemsAdapter.Fill(DataSet, "Products");  
            


            //var comm = new SqlCommand("INSERT INTO Products VALUES('Pen',10,10)", _conn);
            //itemsAdapter.InsertCommand.Parameters.AddWithValue("Title", "Pen");
            //itemsAdapter.InsertCommand.Parameters.AddWithValue("Price", 10);
            //itemsAdapter.InsertCommand.Parameters.AddWithValue("Quantity", 100);
            //itemsAdapter.InsertCommand = comm;
            //itemsAdapter.Update(dataSet.Tables["Products"]);
        }

        public int AddProduct(string title, int price, int quantity)
        {
            // var comm = new SqlCommand("INSERT INTO Products VALUES('Pen',10,10)", _conn);
            //itemsAdapter.InsertCommand.Parameters.AddWithValue("Title", "Pen");
            //itemsAdapter.InsertCommand.Parameters.AddWithValue("Price", 10);
            //itemsAdapter.InsertCommand.Parameters.AddWithValue("Quantity", 100);
            //itemsAdapter.InsertCommand = comm;
            
            var dataRow = DataSet.Tables["Products"].Rows.Add();
            dataRow.SetField(1, "Pen");
            dataRow.SetField(2, 10);
            dataRow.SetField(3, 10);

            return itemsAdapter.Update(DataSet.Tables["Products"]);
        }

    }
}
