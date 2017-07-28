namespace SuperGYM
{
    partial class Sales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Quantit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selling_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.back_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.total_revenue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_Name,
            this.Product_Cat,
            this.Product_Barcode,
            this.Product_Price,
            this.Product_Quantit,
            this.Selling_Date});
            this.dataGridView1.Location = new System.Drawing.Point(343, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(644, 307);
            this.dataGridView1.TabIndex = 28;
            // 
            // Product_Name
            // 
            this.Product_Name.HeaderText = "اسم المنتج";
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
            this.Product_Name.Width = 130;
            // 
            // Product_Cat
            // 
            this.Product_Cat.HeaderText = "الصنف";
            this.Product_Cat.Name = "Product_Cat";
            this.Product_Cat.ReadOnly = true;
            this.Product_Cat.Width = 90;
            // 
            // Product_Barcode
            // 
            this.Product_Barcode.HeaderText = "كود المنتج";
            this.Product_Barcode.Name = "Product_Barcode";
            this.Product_Barcode.ReadOnly = true;
            this.Product_Barcode.Width = 120;
            // 
            // Product_Price
            // 
            this.Product_Price.HeaderText = "سعر المنتج";
            this.Product_Price.Name = "Product_Price";
            this.Product_Price.ReadOnly = true;
            this.Product_Price.Width = 70;
            // 
            // Product_Quantit
            // 
            this.Product_Quantit.HeaderText = "الكمية المباعة";
            this.Product_Quantit.Name = "Product_Quantit";
            this.Product_Quantit.ReadOnly = true;
            this.Product_Quantit.Width = 70;
            // 
            // Selling_Date
            // 
            this.Selling_Date.HeaderText = "التاريخ";
            this.Selling_Date.Name = "Selling_Date";
            this.Selling_Date.ReadOnly = true;
            this.Selling_Date.Width = 120;
            // 
            // back_btn
            // 
            this.back_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back_btn.BackColor = System.Drawing.Color.Transparent;
            this.back_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back_btn.Location = new System.Drawing.Point(279, 159);
            this.back_btn.Margin = new System.Windows.Forms.Padding(2);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(182, 31);
            this.back_btn.TabIndex = 27;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(878, 567);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "الإجمالي :";
            // 
            // total_revenue
            // 
            this.total_revenue.AutoSize = true;
            this.total_revenue.BackColor = System.Drawing.Color.Transparent;
            this.total_revenue.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.total_revenue.Location = new System.Drawing.Point(813, 567);
            this.total_revenue.Name = "total_revenue";
            this.total_revenue.Size = new System.Drawing.Size(49, 17);
            this.total_revenue.TabIndex = 32;
            this.total_revenue.Text = "00.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(632, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "مبيعات شهر :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1- يناير ",
            "2- فبراير",
            "3- مارس",
            "4- ابريل",
            "5- مايو",
            "6- يونيو",
            "7- يوليه",
            "8- اغسطس",
            "9- سبتمبر",
            "0- اكتوبر",
            "11- نوفمبر",
            "12- ديسمبر ",
            "اجمالي المبيعات"});
            this.comboBox1.Location = new System.Drawing.Point(505, 165);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(121)))), ((int)(((byte)(243)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.total_revenue);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.label1);
            this.Name = "Sales";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المبيعات";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sales_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Quantit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Selling_Date;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label total_revenue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}