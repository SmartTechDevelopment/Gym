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
    public partial class Return : Form
    {
        OleDbConnection connection;
        string connString;

        string sql;

        OleDbCommand cmd;
        OleDbDataReader reader;

        string return_barcode;
        int old_sold_quantity , available_quantity ;

        string date; 

        public Return()
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

        private void Return_Load(object sender, EventArgs e)
        {
            LoadSales();
        }

        private void LoadSales()
        {
            dataGridView1.Rows.Clear();

            try
            {
                sql = "SELECT Products.Product_Name, Products.Product_Category, Sales.Product_Barcode, Products.Product_Price, Sales.Quantity, Sales.Date FROM Products INNER JOIN Sales ON Products.Product_Barcode = Sales.Product_Barcode ";
                cmd = new OleDbCommand(sql, connection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] row = new string[] { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetValue(3).ToString(), reader.GetValue(4).ToString(), reader.GetDateTime(5).ToString() };
                    dataGridView1.Rows.Add(row);
                }

                reader.Close();
            }

            catch (Exception ex)
            {

            }
        }

        private void Return_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
            Application.Exit();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == dataGridView1.Rows.Count)
            {
                MessageBox.Show("برجاء اختيار منتج صحيح لإرجاعه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                return_barcode = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                old_sold_quantity = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                return_value_txt.Text = old_sold_quantity.ToString();
                date = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                 
            }
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجد منتجات مباعة لإرجاعها", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (old_sold_quantity < Convert.ToInt16(return_value_txt.Text))
            {
                MessageBox.Show("الكمية المرتجعة لا يمكن ان تزيد عن الكمية المباعة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("هل انت متأكد من ارجاع الكمية المدخلة؟", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    sql = "Update Sales Set Quantity = " + (old_sold_quantity - Convert.ToInt16(return_value_txt.Text)) + " Where Product_Barcode = '" + return_barcode + "' AND Date = #" + date + "# ";
                    cmd = new OleDbCommand(sql, connection);
                    cmd.ExecuteNonQuery();


                    sql = " Select Product_Quantity From Products Where Product_Barcode = '" + return_barcode + "' ";
                    cmd = new OleDbCommand(sql, connection);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    available_quantity = Convert.ToInt16(reader.GetValue(0));
                    reader.Close();


                    sql = "Update Products Set Product_Quantity = " + (available_quantity + Convert.ToInt16(return_value_txt.Text)) + " Where Product_Barcode = '" + return_barcode + "' ";
                    cmd = new OleDbCommand(sql, connection);
                    cmd.ExecuteNonQuery();

                    if (old_sold_quantity == Convert.ToInt16(return_value_txt.Text))
                    {
                        sql = "Delete From Sales Where Product_Barcode = '" + return_barcode + "' AND Date = #" + date + "# ";
                        cmd = new OleDbCommand(sql, connection);
                        cmd.ExecuteNonQuery();
                    }

                    LoadSales();

                    MessageBox.Show("تم ارجاع المنتج بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return_value_txt.Text = "";
                }
            }
        }
    }
}
