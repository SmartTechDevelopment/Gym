using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperGYM
{
    public partial class AppHome : Form
    {
        public AppHome()
        {
            InitializeComponent();
        }

        private void signout_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل تريد الخروج؟", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Form1 F1 = new Form1();
                F1.Show();
                this.Hide();
            }
        }

        private void addpro_btn_Click(object sender, EventArgs e)
        {
            AddProForm addForm = new AddProForm();
            this.Hide();
            addForm.Show();

        }

        private void delpro_btn_Click(object sender, EventArgs e)
        {
            DeletePro delform = new DeletePro();
            delform.Show();
            this.Hide();
        }

        private void addcat_btn_Click(object sender, EventArgs e)
        {
            AddCat addcatForm = new AddCat();
            addcatForm.Show();
            this.Hide();
        }

        private void AppHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void store_btn_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            this.Hide();
            store.Show();
        }

        private void cash_btn_Click(object sender, EventArgs e)
        {
            Cashier cashier = new Cashier();
            this.Hide();
            cashier.Show();
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            Return returnForm = new Return();
            this.Hide();
            returnForm.Show();
        }

        private void bills_btn_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            this.Hide();
            sales.Show();
        }
    }
}
