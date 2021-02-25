using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutonomousMode
{
    public partial class Form1 : Form
    {
        //private SomeDB db;
        private AdvancedDB adb;
        public Form1()
        {
            InitializeComponent();
            adb = new AdvancedDB();
            //db = new SomeDB();

            //db.OpenConnection();
            //dataGridView.DataSource = db.GetData();
            dataGridView.DataSource = adb.DataSet.Tables["Products"];
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int res = adb.AddProduct(titleTextBox.Text,(int)PriceNumericUpDown.Value,(int)QuantityNumericUpDown.Value);
            MessageBox.Show($"Rows : {res}");
        }
    }
}
