namespace SuperGYM
{
    partial class Return
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Return));
            this.back_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Quantit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selling_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.return_btn = new System.Windows.Forms.Button();
            this.return_value_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back_btn.BackColor = System.Drawing.Color.Transparent;
            this.back_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back_btn.Location = new System.Drawing.Point(278, 159);
            this.back_btn.Margin = new System.Windows.Forms.Padding(2);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(182, 31);
            this.back_btn.TabIndex = 6;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(342, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(644, 307);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
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
            // return_btn
            // 
            this.return_btn.BackColor = System.Drawing.Color.Black;
            this.return_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.return_btn.Location = new System.Drawing.Point(342, 551);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(143, 48);
            this.return_btn.TabIndex = 26;
            this.return_btn.Text = "إرجاع";
            this.return_btn.UseVisualStyleBackColor = false;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // return_value_txt
            // 
            this.return_value_txt.Location = new System.Drawing.Point(808, 565);
            this.return_value_txt.Name = "return_value_txt";
            this.return_value_txt.Size = new System.Drawing.Size(63, 20);
            this.return_value_txt.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(877, 567);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "الكمية المرتجعة";
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(121)))), ((int)(((byte)(243)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.return_value_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.back_btn);
            this.Name = "Return";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المرتجعات";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Return_FormClosing);
            this.Load += new System.EventHandler(this.Return_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.TextBox return_value_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Quantit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Selling_Date;
    }
}