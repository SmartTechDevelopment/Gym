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
    public partial class AddCat : Form
    {
        OleDbConnection connection;
        string connString;
        OleDbCommand Command;

        public AddCat()
        {
            InitializeComponent();
            connString = "  Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB.accdb;Persist Security Info=False;";
            connection = new OleDbConnection(connString);
            connection.Open();
        }

        private void AddCat_Load(object sender, EventArgs e)
        {

        }

        private void AddCat_Button_Click(object sender, EventArgs e)
        {


            if (CatName_text.Text == "" || CatDesc_Text.Text == "" || CatName_text.Text == "اسم الصنف" || CatDesc_Text.Text == "وصف الصنف")
            {
                MessageBox.Show("برجاء ادخال جميع البيانات");
            }

            else
            {

                DialogResult result = MessageBox.Show("هل انت متأكد من جميع البيانات؟", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string query = "Insert into Categories (Category_Name,Category_Description) Values('" + CatName_text.Text + "','" + CatDesc_Text.Text + "') ";
                    Command = new OleDbCommand(query, connection);
                    Command.ExecuteNonQuery();
                    MessageBox.Show("تم اضافة الصنف بنجاح","تم",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    CatName_text.Clear();
                    CatDesc_Text.Clear();
                }
            }

        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            connection.Close();
            AppHome ap = new AppHome();
            ap.Show();
            this.Hide();
        }

        private void CatName_text_Enter(object sender, EventArgs e)
        {
            if (CatName_text.Text == "اسم الصنف")
            {
                CatName_text.Text = "";
            }
        }

        private void CatName_text_Leave(object sender, EventArgs e)
        {
            if (CatName_text.Text == "")
            {
                CatName_text.Text = "اسم الصنف";
            }
        }

        private void CatDesc_Text_Enter(object sender, EventArgs e)
        {
            if (CatDesc_Text.Text == "وصف الصنف")
            {
                CatDesc_Text.Text = "";
            }
        }

        private void CatDesc_Text_Leave(object sender, EventArgs e)
        {
            if (CatDesc_Text.Text == "")
            {
                CatDesc_Text.Text = "وصف الصنف";
            }

        }

        private void AddCat_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
            Application.Exit();
        }







    }
}
