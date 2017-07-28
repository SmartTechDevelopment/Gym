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

    public partial class Cashier : Form
    {
        OleDbConnection connection;
        string connString;

        OleDbDataReader reader;

        int pro_price, pro_quantity, total_price = 0 ;
        

        int deleted_money , deleted_quantity, deleted_barcode, temp_quantity;

        public Cashier()
        {
            InitializeComponent();

            connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB.accdb;Persist Security Info=False;";
            connection = new OleDbConnection(connString);
            connection.Open();
        }

        private void Cashier_Load(object sender, EventArgs e)
        {
           
            barcode_txt.ReadOnly = false;
            cats_combbox.Items.Clear();
            cats_combbox.Text = "";
            try
            {
                string sql = "Select Category_Name From Categories ";
                OleDbCommand cmd = new OleDbCommand(sql, connection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cats_combbox.Items.Add(reader.GetString(0));
                }
                reader.Close();

                sql = "Update Products Set Product_Quantity_Temp = Product_Quantity";

                cmd = new OleDbCommand(sql, connection);

                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {

            }

        }

        private void cats_combbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            products_combox.Items.Clear();
            products_combox.Text = "";
            try
            {
                string sql = "Select * From Products Where Product_Category = '" + cats_combbox.SelectedItem.ToString() + "' ";
                OleDbCommand cmd = new OleDbCommand(sql, connection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    products_combox.Items.Add(reader.GetString(0));
                }
                reader.Close();
                quantity_combbox.SelectedIndex = 0;
            }

            catch (Exception ex)
            {

            }

        }

        private void products_combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            quantity_combbox.Items.Clear();

            try
            {
                string sql = "Select * From Products Where Product_Category = '" + cats_combbox.SelectedItem.ToString() + "' AND Product_Name = '" + products_combox.SelectedItem.ToString() + "' ";
                OleDbCommand cmd = new OleDbCommand(sql, connection);
                reader = cmd.ExecuteReader();
                reader.Read();

                barcode_txt.Text = reader.GetString(4);

                for ( int x = 1 ; x <=  Convert.ToInt16(reader.GetValue(6)) ; x++ )
                {
                    quantity_combbox.Items.Add(x);
                }
                if (Convert.ToInt16(reader.GetValue(6)) == 0)
                {
                    MessageBox.Show("المنتج الذي تم اختياره غير موجود حاليا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                reader.Close();

                barcode_txt.ReadOnly = true;

            }

            catch (Exception ex)
            {

            }

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("الخروج سيؤدي لحذف المنتجات التي قمت بإختيارها ، متأكد ؟", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    AppHome appHome = new AppHome();
                    this.Hide();
                    appHome.Show();
                }

            }
            else
            {

                connection.Close();
                AppHome ap = new AppHome();
                ap.Show();
                this.Hide();
            }
        }

        private void Cashier_FormClosing(object sender, FormClosingEventArgs e)
        {

            connection.Close();
            Application.Exit();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            barcode_txt.Focus();

            if ( cats_combbox.SelectedIndex == -1 && products_combox.SelectedIndex == -1 && barcode_txt.Text == "")
            {
                MessageBox.Show("برجاء اختيار المنتج المراد بيعه عن طريق الباركود او اختياره من القائمة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ( quantity_combbox.SelectedIndex == -1 )
            {
                MessageBox.Show("برجاء اختيار الكمية المباعة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int PQT = 0;
                    string sql = "Select * From Products Where Product_Barcode = '" + barcode_txt.Text + "' ";

                    OleDbCommand cmd = new OleDbCommand(sql, connection);
                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        pro_price = Convert.ToInt16(reader.GetValue(2));

                        for (int x = 1; x <= Convert.ToInt16(reader.GetValue(6)); x++)
                        {
                            quantity_combbox.Items.Add(x);
                        }
                   
                        PQT = Convert.ToInt16(reader.GetValue(6));
                        pro_quantity = Convert.ToInt16(quantity_combbox.SelectedItem.ToString());
                        string[] row = new string[] { reader.GetString(0), barcode_txt.Text, reader.GetString(1), reader.GetString(2), pro_quantity.ToString() , DateTime.Now.ToString() };
                        dataGridView1.Rows.Add(row);
                        temp_quantity = PQT - pro_quantity;
                        sql = "Update Products Set Product_Quantity_Temp = '" + temp_quantity + "' where Product_Barcode = '" + barcode_txt.Text + "'";
                        cmd = new OleDbCommand(sql, connection);
                        cmd.ExecuteNonQuery();


                        reader.Close();

                        cats_combbox.Text = "";
                        barcode_txt.Text = "";
                        quantity_combbox.Items.Clear();
                        quantity_combbox.Text = "";
                        products_combox.Items.Clear();
                        products_combox.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("المنتج غير متاح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }


                catch (Exception ex)
                {

                }
               
            }
          
        }


        private void finish_btn_Click(object sender, EventArgs e)
        {
            barcode_txt.Focus();
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("برجاء اضافة منتجات للمبيعات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("هل انت متأكد ؟", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    for (int x = 0; x < dataGridView1.Rows.Count ; x++)
                    {
                        string sql = "Insert Into Sales Values ( '" + dataGridView1.Rows[x].Cells[1].Value.ToString() + "' , " + Convert.ToInt16(dataGridView1.Rows[x].Cells[4].Value) + " , '" + dataGridView1.Rows[x].Cells[5].Value.ToString() + "' ) ";

                        OleDbCommand cmd = new OleDbCommand(sql, connection);

                        cmd.ExecuteNonQuery();

                        sql = "Select Product_Quantity From Products Where Product_Barcode = '" + dataGridView1.Rows[x].Cells[1].Value.ToString() + "'";

                        cmd = new OleDbCommand(sql, connection);
                        OleDbDataReader reader1 = cmd.ExecuteReader();
                        reader1.Read();

                        int previous_quantity = Convert.ToInt16(reader1.GetValue(0));
                        reader1.Close();

                        sql = "Update Products Set Product_Quantity = " + previous_quantity + " - " + dataGridView1.Rows[x].Cells[4].Value.ToString() + " Where Product_Barcode = '" + dataGridView1.Rows[x].Cells[1].Value.ToString() + "' ";

                        cmd = new OleDbCommand(sql, connection);

                        cmd.ExecuteNonQuery();

                        sql = "Update Products Set Product_Quantity_Temp = Product_Quantity Where Product_Barcode = '" + dataGridView1.Rows[x].Cells[1].Value.ToString() + "' ";

                        cmd = new OleDbCommand(sql, connection);

                        cmd.ExecuteNonQuery();


                    }

                    MessageBox.Show("تم بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cats_combbox.SelectedIndex = -1;
                    products_combox.SelectedIndex = -1;
                    quantity_combbox.Items.Clear();
                    barcode_txt.Text = "";
                    dataGridView1.Rows.Clear();
                    total.Text = "0.00";
                }
            }

        }

        //private void barcode_txt_Leave(object sender, EventArgs e)
        //{
        //    quantity_combbox.Items.Clear();

        //    try
        //    {
        //        string sql = "Select * From Products Where Product_Barcode = '" + barcode_txt.Text + "' ";

        //        OleDbCommand cmd = new OleDbCommand(sql, connection);
        //        reader = cmd.ExecuteReader();
        //        reader.Read();

        //        pro_price = Convert.ToInt16(reader.GetValue(2));
        //        for (int x = 1; x <= Convert.ToInt16(reader.GetValue(6)); x++)
        //        {
        //            quantity_combbox.Items.Add(x);
        //        }

        //        reader.Close();

        //    }

        //    catch (Exception ex)
        //    {

        //    }
        //}

        private void barcode_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                add();
            }


        void add()
        {
            try
            {
                int PQT = 0;
                string sql = "Select * From Products Where Product_Barcode = '" + barcode_txt.Text + "' ";

                OleDbCommand cmd = new OleDbCommand(sql, connection);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    pro_price = Convert.ToInt16(reader.GetValue(2));

                    for (int x = 1; x <= Convert.ToInt16(reader.GetValue(6)); x++)
                    {
                        quantity_combbox.Items.Add(x);
                    }
                    quantity_combbox.SelectedIndex = 0;
                    PQT = Convert.ToInt16(reader.GetValue(6));
                    pro_quantity = Convert.ToInt16(quantity_combbox.SelectedItem.ToString());
                    string[] row = new string[] { reader.GetString(0), barcode_txt.Text, reader.GetString(1), reader.GetString(2), pro_quantity.ToString(), DateTime.Now.ToString() };
                    dataGridView1.Rows.Add(row);
                    temp_quantity = PQT - pro_quantity;
                    sql = "Update Products Set Product_Quantity_Temp = '" + temp_quantity + "' where Product_Barcode = '" + barcode_txt.Text + "'";
                    cmd = new OleDbCommand(sql, connection);
                    cmd.ExecuteNonQuery();


                    //total_price += (pro_price * pro_quantity);

                    //total.Text = total_price.ToString();

                    reader.Close();

                    cats_combbox.Text = "";
                    barcode_txt.Text = "";
                    quantity_combbox.Items.Clear();
                    quantity_combbox.Text = "";
                    products_combox.Items.Clear();
                    products_combox.Text = "";
                }
                else
                {
                    MessageBox.Show("المنتج غير متاح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

            }

        }

        private void Cashier_KeyDown(object sender, KeyEventArgs e)
        {
         
        }

        private void cats_combbox_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void cats_combbox_DropDownClosed(object sender, EventArgs e)
        {
            barcode_txt.Focus();
           
        }

        private void products_combox_DropDownClosed(object sender, EventArgs e)
        {
            barcode_txt.Focus();
        }

        private void quantity_combbox_DropDownClosed(object sender, EventArgs e)
        {
            barcode_txt.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            barcode_txt.Focus();
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            barcode_txt.Focus();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            total_price = 0;

            totall();
            
        }

        private void Cashier_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void barcode_txt_TextChanged(object sender, EventArgs e)
        {
            quantity_combbox.Items.Clear();

            try
            {
                string sql = "Select * From Products Where Product_Barcode = '" + barcode_txt.Text + "' ";

                OleDbCommand cmd = new OleDbCommand(sql, connection);
                reader = cmd.ExecuteReader();
                reader.Read();

                pro_price = Convert.ToInt16(reader.GetValue(2));
                for (int x = 1; x <= Convert.ToInt16(reader.GetValue(6)); x++)
                {
                    quantity_combbox.Items.Add(x);
                }

                reader.Close();

            }

            catch (Exception ex)
            {

            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            deleted_money = (Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[3].Value)) * (Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[4].Value));
            deleted_quantity = (Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[4].Value));
            deleted_barcode = (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value));
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

            string sql = "Update Products Set Product_Quantity_Temp = '" + (temp_quantity + deleted_quantity) + "' Where Product_Barcode = '" + deleted_barcode.ToString() + "' ";

            OleDbCommand cmd = new OleDbCommand(sql, connection);
            cmd.ExecuteReader();

            totall();
        }

        private void totall()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                total_price += int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) * int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
            total.Text = total_price.ToString();
        }
    }

}
