using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace SuperGYM
{
    public partial class AddProForm : Form
    {

        OleDbConnection connection;
        string connString;
        OleDbCommand Command;

        public AddProForm()
        {
            InitializeComponent();
            connString = "  Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB.accdb;Persist Security Info=False;";
            connection = new OleDbConnection(connString);
            connection.Open();
        }

        private void addpro_btn_Click(object sender, EventArgs e)
        {
            if (proname_txt.Text == "" || cat_combox.SelectedIndex == -1 || proprice_txt.Text == "" || quantity_txt.Text == "" || barcode_txt.Text == "" || prodesc_txt.Text == "" || proname_txt.Text == "اسم المنتج" || cat_combox.SelectedItem.ToString() == "الصنف" || proprice_txt.Text == "سعر المنتج" || quantity_txt.Text == "الكمية" || barcode_txt.Text == "كود المنتج" || prodesc_txt.Text == "وصف المنتج")
            {
                MessageBox.Show("برجاء ادخال جميع البيانات","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                string query;

                query = "Select Product_Barcode From Products Where Product_Barcode = '" + barcode_txt.Text + "' ";

                Command = new OleDbCommand(query, connection);
                OleDbDataReader reader = Command.ExecuteReader();

                if ( reader.Read() )
                {
                    MessageBox.Show("الباركود المدخل موجود بالفعل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    reader.Close();
                    barcode_txt.Text = "كود المنتج";
                }
                else
                {
                    query = "Insert into Products(Product_Name,Product_Category,Product_Price,Product_Quantity,Product_Barcode,Product_Description,Product_Quantity_Temp) Values('" + proname_txt.Text + "','" + cat_combox.SelectedItem + "','" + proprice_txt.Text + "','" + quantity_txt.Text + "','" + barcode_txt.Text + "','" + prodesc_txt.Text + "','" + quantity_txt.Text + "')";
                    Command = new OleDbCommand(query, connection);
                    Command.ExecuteNonQuery();

                    MessageBox.Show("تم اضافة المنتج بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    proname_txt.Text = "اسم المنتج";
                    cat_combox.Text = "الصنف";
                    proprice_txt.Text = "سعر المنتج";
                    quantity_txt.Text = "الكمية";
                    barcode_txt.Text = "كود المنتج";
                    prodesc_txt.Text = "وصف المنتج";

                }
            }


        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            connection.Close();
            AppHome ap = new AppHome();
            ap.Show();
            this.Hide();
        }

        private void proname_txt_Enter(object sender, EventArgs e)
        {
            if (proname_txt.Text == "اسم المنتج")
            {
                proname_txt.Text = "";
            }
        }

        private void proname_txt_Leave(object sender, EventArgs e)
        {
            if (proname_txt.Text == "")
            {
                proname_txt.Text = "اسم المنتج";
            }
        }

        private void proprice_txt_Enter(object sender, EventArgs e)
        {
            if (proprice_txt.Text == "سعر المنتج")
            {
                proprice_txt.Text = "";
            }

        }

        private void proprice_txt_Leave(object sender, EventArgs e)
        {
            if (proprice_txt.Text == "")
            {
                proprice_txt.Text = "سعر المنتج";
            }
        }

        private void quantity_txt_Enter(object sender, EventArgs e)
        {
            if (quantity_txt.Text == "الكمية")
            {
                quantity_txt.Text = "";
            }

        }

        private void quantity_txt_Leave(object sender, EventArgs e)
        {
            if (quantity_txt.Text == "")
            {
                quantity_txt.Text = "الكمية";
            }

        }

        private void barcode_txt_Enter(object sender, EventArgs e)
        {
            if (barcode_txt.Text == "كود المنتج")
            {
                barcode_txt.Text = "";
            }
        }

        private void barcode_txt_Leave(object sender, EventArgs e)
        {
            if (barcode_txt.Text == "")
            {
                barcode_txt.Text = "كود المنتج";
            }
        }

        private void prodesc_txt_Enter(object sender, EventArgs e)
        {
            if (prodesc_txt.Text == "وصف المنتج")
            {
                prodesc_txt.Text = "";
            }
        }

        private void prodesc_txt_Leave(object sender, EventArgs e)
        {
            if (prodesc_txt.Text == "")
            {
                prodesc_txt.Text = "وصف المنتج";
            }

        }

        private void AddProForm_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "Select Category_Name From Categories ";
                OleDbCommand cmd = new OleDbCommand(sql, connection);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cat_combox.Items.Add(reader.GetString(0));
                }
                reader.Close();
            }

            catch (Exception ex)
            {

            }
        }

        private void AddProForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
            Application.Exit();
        }

        private void proprice_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void quantity_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }









        }
    }

