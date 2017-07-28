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
    public partial class Store : Form
    {
        OleDbConnection connection;
        string connString;
        string query = " Select Product_Name , Product_Category , Product_Price , Product_Quantity , Product_Barcode , Product_Description from Products ";
        DataSet ds = new DataSet();
        OleDbDataAdapter da;
        DataTable dt;

        public Store()
        {
            InitializeComponent();

            connString = "  Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB.accdb;Persist Security Info=False;";
            connection = new OleDbConnection(connString);
            connection.Open();
        }

        private void fill_store()
        {
            OleDbCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Product_Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Product_Name"].HeaderText = "اسم المنتج";
            dataGridView1.Columns["Product_Category"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Product_Category"].HeaderText = "الصنف";
            dataGridView1.Columns["Product_Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Product_Price"].HeaderText = "سعر المنتج";
            dataGridView1.Columns["Product_Quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Product_Quantity"].HeaderText = "الكمية";
            dataGridView1.Columns["Product_Barcode"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Product_Barcode"].HeaderText = "كود المنتج";
            dataGridView1.Columns["Product_Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Product_Description"].HeaderText = "وصف المنتج";
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            AppHome home = new AppHome();
            this.Hide();
            home.Show();
        }

        private void Store_Load(object sender, EventArgs e)
        {
            fill_store();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            bool flag = true;
            foreach (DataGridViewRow rw in this.dataGridView1.Rows)
            {
                for (int i = 0; i < rw.Cells.Count; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        flag = false;
                    }
                }
            }

            if (flag)
            {
                DialogResult result = MessageBox.Show("هل تريد حفظ التغييرات؟", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    OleDbDataAdapter adapter = new OleDbDataAdapter();
                    adapter.SelectCommand = new OleDbCommand(query, connection);
                    OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);

                    adapter.Update(dt);

                    MessageBox.Show("تم حفظ التغييرات بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("برجاء التأكد من اكمال جميع البيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Store_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
            Application.Exit();
        }
    }
}
