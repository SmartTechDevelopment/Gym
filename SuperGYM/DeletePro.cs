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
    public partial class DeletePro : Form
    {
        OleDbConnection connection;
        string connString;
        public DeletePro()
        {
            InitializeComponent();
            connString = "  Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB.accdb;Persist Security Info=False;";
            connection = new OleDbConnection(connString);
            connection.Open();
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            if ( cats_combox.SelectedIndex == -1 || pro_combox.SelectedIndex == -1 )
            {
                    MessageBox.Show("برجاء اختيار المنـتج المراد حذفه");
            }
            else
            {
                DialogResult result = MessageBox.Show("هل انت متأكد من حذف المنتج؟", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string query = "Delete from Products where Product_Name = '" + pro_combox.SelectedItem.ToString() + "' And Product_Category = '" + cats_combox.SelectedItem.ToString() + "'";
                    OleDbCommand cmd = new OleDbCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تم حذف المنـتج بنجاح");

                    pro_combox.Items.Clear();
                    pro_combox.Text = "اسم المنتج";

                    MessageBox.Show("تم حذف المنتج بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void ReturnHome_Click(object sender, EventArgs e)
        {
            connection.Close();
            AppHome ap = new AppHome();
            ap.Show();
            this.Hide();
        }

        private void DeletePro_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
            Application.Exit();
        }

        private void DeletePro_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "Select Category_Name From Categories ";
                OleDbCommand cmd = new OleDbCommand(sql, connection);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cats_combox.Items.Add(reader.GetString(0));
                }
                reader.Close();
            }

            catch (Exception ex)
            {

            }
        }

        private void cats_combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pro_combox.Items.Clear();
            try
            {
                string sql = "Select Product_Name From Products Where Product_Category = '"+cats_combox.SelectedItem.ToString()+"' ";
                OleDbCommand cmd = new OleDbCommand(sql, connection);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    pro_combox.Items.Add(reader.GetString(0));
                }
                reader.Close();
            }

            catch (Exception ex)
            {

            }
        }


    }
}
