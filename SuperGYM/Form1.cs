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
using System.Net.NetworkInformation;
namespace SuperGYM
{
    public partial class Form1 : Form
    {
        OleDbConnection connection;
        string connString;
        DataSet ds = new DataSet();
        AppHome appHome = new AppHome();
        string un, pswd;
        int h, w;
        public Form1()
        {
            InitializeComponent();

            h = Screen.PrimaryScreen.Bounds.Height;
            w = Screen.PrimaryScreen.Bounds.Width;

            connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB.accdb;Persist Security Info=False;";
            connection = new OleDbConnection(connString);
            connection.Open();

        }
        public string GetMACAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card  
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            return sMacAddress;
        }

        void conntoDB()
        {
            string sql = "Select Username From Users Where Username ='" + un_tb.Text.ToString() + "'";
            string sql2 = "SELECT Password FROM Users where Password ='" + ps_tb.Text.ToString() + "'";

            OleDbCommand cmd = new OleDbCommand(sql, connection);
            OleDbCommand cmd2 = new OleDbCommand(sql2, connection);

            OleDbDataReader reader;
            OleDbDataReader reader2;

            reader = cmd.ExecuteReader();
            reader2 = cmd2.ExecuteReader();

            while (reader.Read())
            {
                un = reader.GetString(0).ToString();
            }

            while (reader2.Read())
            {
                pswd = reader2.GetString(0).ToString();
            }

            reader.Close();
            reader2.Close();
        }
        void MainMenu_show()
        {
            appHome.Show();
            this.Hide();
            un_tb.Text = "";
            ps_tb.Text = "";
        }
        void msgerror()
        {
            MessageBox.Show("عذرا اسم المستخدم أو كلمة المرور غير صحيحة من فضلك حاول مرة أخرى :(", "UNCORRECT", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void signin_btn_Click(object sender, EventArgs e)
        {
            
            if ( un_tb.Text == "اسم المستخدم"  || ps_tb.Text == "000000")
            {
                MessageBox.Show("برجاء كتابة اسم المستخدم وكلمة المرور :(", "UNCORRECT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                try
                {
                    conntoDB();
                    if (un_tb.Text == un && un_tb.Text != "")
                        if (ps_tb.Text == pswd)
                        {
                            MainMenu_show();
                        }
                        else
                            msgerror();
                    else
                        msgerror();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
            Application.Exit();
        }

        private void un_tb_Enter(object sender, EventArgs e)
        {
            if (un_tb.Text == "اسم المستخدم")
            {
                un_tb.Text = "";
            }
        }

        private void un_tb_Leave(object sender, EventArgs e)
        {
            if (un_tb.Text == "")
            {
                un_tb.Text = "اسم المستخدم";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //if (GetMACAddress() == "262737618173")//check the mac address
            //{
            //}
            //else
            //{
            //    MessageBox.Show("برجاء شراء البرنامج اولا ... للاستعلام الرجاء الاتصال علي 01141394361 - 01003424842 م/أحمد , م/محمد ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Application.Exit();
            //}
        }

        private void ps_tb_Enter(object sender, EventArgs e)
        {
            if (ps_tb.Text == "000000")
            {
                ps_tb.Text = "";
            }
        }

        private void ps_tb_Leave(object sender, EventArgs e)
        {
            if (ps_tb.Text == "")
            {
                ps_tb.Text = "000000";
            }
        }
    }
}
