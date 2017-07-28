using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperGYM
{
    public partial class Sales : Form
    {
        OleDbConnection connection;
        string connString;

        string sql;

        OleDbCommand cmd;
        OleDbDataReader reader;

        double total = 0 ; 

        public Sales()
        {
            InitializeComponent();

            connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB.accdb;Persist Security Info=False;";
            connection = new OleDbConnection(connString);
            connection.Open();

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            AppHome appHome = new AppHome();
            this.Hide();
            appHome.Show();
        }

       
        private void LoadSales(int month)
        {

            try
            {
                if (month == 12)
                {
                    sql = "SELECT Products.Product_Name, Products.Product_Category, Sales.Product_Barcode, Products.Product_Price, Sales.Quantity, Sales.Date FROM Products INNER JOIN Sales ON Products.Product_Barcode = Sales.Product_Barcode Where Sales.Date BETWEEN #" + DateTime.Now.Year + "-12-01# AND #" + (DateTime.Now.Year + 1) + "-01-01# ";
                }
                else if (month == 13)
                {
                    sql = "SELECT Products.Product_Name, Products.Product_Category, Sales.Product_Barcode, Products.Product_Price, Sales.Quantity, Sales.Date FROM Products INNER JOIN Sales ON Products.Product_Barcode = Sales.Product_Barcode";
                }
                else
                {
                    sql = "SELECT Products.Product_Name, Products.Product_Category, Sales.Product_Barcode, Products.Product_Price, Sales.Quantity, Sales.Date FROM Products INNER JOIN Sales ON Products.Product_Barcode = Sales.Product_Barcode Where Sales.Date BETWEEN #" + DateTime.Now.Year + "-" + month + "-01# AND #" + DateTime.Now.Year + "-" + (month + 1) + "-01# ";
                }
                cmd = new OleDbCommand(sql, connection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] row = new string[] { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetValue(3).ToString(), reader.GetValue(4).ToString(), reader.GetDateTime(5).ToString() };
                    dataGridView1.Rows.Add(row);

                    total += (Convert.ToInt16(reader.GetValue(3)) * Convert.ToInt16(reader.GetValue(4)));

                }

                total_revenue.Text = total.ToString();


            }

            catch (Exception ex)
            {

            }



        }

        private void Sales_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadSales(comboBox1.SelectedIndex + 1);
        }
    }
}
