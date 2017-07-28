namespace SuperGYM
{
    partial class Cashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier));
            this.total = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.finish_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sell_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.products_combox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cats_combbox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.barcode_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.quantity_combbox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.BackColor = System.Drawing.Color.Transparent;
            this.total.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.total.Location = new System.Drawing.Point(852, 576);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(57, 17);
            this.total.TabIndex = 29;
            this.total.Text = "00.000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(804, 554);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "إجمالي المبيعات الان";
            // 
            // finish_btn
            // 
            this.finish_btn.BackColor = System.Drawing.Color.Black;
            this.finish_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finish_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.finish_btn.Location = new System.Drawing.Point(423, 538);
            this.finish_btn.Name = "finish_btn";
            this.finish_btn.Size = new System.Drawing.Size(114, 48);
            this.finish_btn.TabIndex = 25;
            this.finish_btn.Text = "إنـــهــــاء\r\n( F )";
            this.finish_btn.UseVisualStyleBackColor = false;
            this.finish_btn.Click += new System.EventHandler(this.finish_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_Name,
            this.Product_Barcode,
            this.Product_Cat,
            this.Product_Price,
            this.Product_Quantity,
            this.Sell_Date});
            this.dataGridView1.Location = new System.Drawing.Point(423, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(523, 212);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // Product_Name
            // 
            this.Product_Name.HeaderText = "اسم المنتج";
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
            this.Product_Name.Width = 160;
            // 
            // Product_Barcode
            // 
            this.Product_Barcode.HeaderText = "كود المنتج";
            this.Product_Barcode.Name = "Product_Barcode";
            this.Product_Barcode.ReadOnly = true;
            // 
            // Product_Cat
            // 
            this.Product_Cat.HeaderText = "الصنف";
            this.Product_Cat.Name = "Product_Cat";
            this.Product_Cat.ReadOnly = true;
            // 
            // Product_Price
            // 
            this.Product_Price.HeaderText = "سعر المنتج";
            this.Product_Price.Name = "Product_Price";
            this.Product_Price.ReadOnly = true;
            this.Product_Price.Width = 60;
            // 
            // Product_Quantity
            // 
            this.Product_Quantity.HeaderText = "الكمية";
            this.Product_Quantity.Name = "Product_Quantity";
            this.Product_Quantity.ReadOnly = true;
            this.Product_Quantity.Width = 60;
            // 
            // Sell_Date
            // 
            this.Sell_Date.HeaderText = "التاريخ";
            this.Sell_Date.Name = "Sell_Date";
            this.Sell_Date.ReadOnly = true;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Black;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_btn.Location = new System.Drawing.Point(423, 239);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(114, 48);
            this.add_btn.TabIndex = 23;
            this.add_btn.Text = "إضافة للمبيعات\r\n( Enter )";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(718, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "الكمية";
            // 
            // products_combox
            // 
            this.products_combox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.products_combox.FormattingEnabled = true;
            this.products_combox.Location = new System.Drawing.Point(772, 268);
            this.products_combox.Name = "products_combox";
            this.products_combox.Size = new System.Drawing.Size(121, 21);
            this.products_combox.TabIndex = 20;
            this.products_combox.SelectedIndexChanged += new System.EventHandler(this.products_combox_SelectedIndexChanged);
            this.products_combox.DropDownClosed += new System.EventHandler(this.products_combox_DropDownClosed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(899, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "المنتج";
            // 
            // cats_combbox
            // 
            this.cats_combbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cats_combbox.FormattingEnabled = true;
            this.cats_combbox.Location = new System.Drawing.Point(772, 240);
            this.cats_combbox.Name = "cats_combbox";
            this.cats_combbox.Size = new System.Drawing.Size(121, 21);
            this.cats_combbox.TabIndex = 18;
            this.cats_combbox.SelectedIndexChanged += new System.EventHandler(this.cats_combbox_SelectedIndexChanged);
            this.cats_combbox.DropDownClosed += new System.EventHandler(this.cats_combbox_DropDownClosed);
            this.cats_combbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cats_combbox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(899, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "الصنف";
            // 
            // barcode_txt
            // 
            this.barcode_txt.Location = new System.Drawing.Point(543, 239);
            this.barcode_txt.Name = "barcode_txt";
            this.barcode_txt.Size = new System.Drawing.Size(162, 20);
            this.barcode_txt.TabIndex = 16;
            this.barcode_txt.TextChanged += new System.EventHandler(this.barcode_txt_TextChanged);
            this.barcode_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.barcode_txt_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(709, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "الباركود";
            // 
            // back_btn
            // 
            this.back_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back_btn.BackColor = System.Drawing.Color.Transparent;
            this.back_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back_btn.Location = new System.Drawing.Point(280, 161);
            this.back_btn.Margin = new System.Windows.Forms.Padding(2);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(170, 27);
            this.back_btn.TabIndex = 30;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // quantity_combbox
            // 
            this.quantity_combbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quantity_combbox.FormattingEnabled = true;
            this.quantity_combbox.Location = new System.Drawing.Point(629, 272);
            this.quantity_combbox.Name = "quantity_combbox";
            this.quantity_combbox.Size = new System.Drawing.Size(76, 21);
            this.quantity_combbox.TabIndex = 31;
            this.quantity_combbox.DropDownClosed += new System.EventHandler(this.quantity_combbox_DropDownClosed);
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(121)))), ((int)(((byte)(243)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.quantity_combbox);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.finish_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.products_combox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cats_combbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barcode_txt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cashier";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الكاشير";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cashier_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cashier_FormClosed);
            this.Load += new System.EventHandler(this.Cashier_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cashier_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button finish_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox products_combox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cats_combbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox barcode_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.ComboBox quantity_combbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sell_Date;
    }
}