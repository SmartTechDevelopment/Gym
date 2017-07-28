namespace SuperGYM
{
    partial class AddProForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProForm));
            this.proname_txt = new System.Windows.Forms.TextBox();
            this.cat_combox = new System.Windows.Forms.ComboBox();
            this.proprice_txt = new System.Windows.Forms.TextBox();
            this.quantity_txt = new System.Windows.Forms.TextBox();
            this.barcode_txt = new System.Windows.Forms.TextBox();
            this.prodesc_txt = new System.Windows.Forms.TextBox();
            this.addpro_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // proname_txt
            // 
            this.proname_txt.Location = new System.Drawing.Point(351, 323);
            this.proname_txt.Name = "proname_txt";
            this.proname_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.proname_txt.Size = new System.Drawing.Size(152, 20);
            this.proname_txt.TabIndex = 1;
            this.proname_txt.Text = "اسم المنتج";
            this.proname_txt.Enter += new System.EventHandler(this.proname_txt_Enter);
            this.proname_txt.Leave += new System.EventHandler(this.proname_txt_Leave);
            // 
            // cat_combox
            // 
            this.cat_combox.FormattingEnabled = true;
            this.cat_combox.Location = new System.Drawing.Point(352, 350);
            this.cat_combox.Name = "cat_combox";
            this.cat_combox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cat_combox.Size = new System.Drawing.Size(152, 21);
            this.cat_combox.TabIndex = 2;
            this.cat_combox.Text = "الصنف";
            // 
            // proprice_txt
            // 
            this.proprice_txt.Location = new System.Drawing.Point(351, 375);
            this.proprice_txt.Name = "proprice_txt";
            this.proprice_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.proprice_txt.Size = new System.Drawing.Size(152, 20);
            this.proprice_txt.TabIndex = 3;
            this.proprice_txt.Text = "سعر المنتج";
            this.proprice_txt.Enter += new System.EventHandler(this.proprice_txt_Enter);
            this.proprice_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.proprice_txt_KeyPress);
            this.proprice_txt.Leave += new System.EventHandler(this.proprice_txt_Leave);
            // 
            // quantity_txt
            // 
            this.quantity_txt.Location = new System.Drawing.Point(351, 404);
            this.quantity_txt.Name = "quantity_txt";
            this.quantity_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.quantity_txt.Size = new System.Drawing.Size(152, 20);
            this.quantity_txt.TabIndex = 4;
            this.quantity_txt.Text = "الكمية";
            this.quantity_txt.Enter += new System.EventHandler(this.quantity_txt_Enter);
            this.quantity_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantity_txt_KeyPress);
            this.quantity_txt.Leave += new System.EventHandler(this.quantity_txt_Leave);
            // 
            // barcode_txt
            // 
            this.barcode_txt.Location = new System.Drawing.Point(352, 432);
            this.barcode_txt.Name = "barcode_txt";
            this.barcode_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.barcode_txt.Size = new System.Drawing.Size(152, 20);
            this.barcode_txt.TabIndex = 5;
            this.barcode_txt.Text = "كود المنتج";
            this.barcode_txt.Enter += new System.EventHandler(this.barcode_txt_Enter);
            this.barcode_txt.Leave += new System.EventHandler(this.barcode_txt_Leave);
            // 
            // prodesc_txt
            // 
            this.prodesc_txt.Location = new System.Drawing.Point(352, 469);
            this.prodesc_txt.Multiline = true;
            this.prodesc_txt.Name = "prodesc_txt";
            this.prodesc_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.prodesc_txt.Size = new System.Drawing.Size(152, 34);
            this.prodesc_txt.TabIndex = 6;
            this.prodesc_txt.Text = "وصف المنتج";
            this.prodesc_txt.Enter += new System.EventHandler(this.prodesc_txt_Enter);
            this.prodesc_txt.Leave += new System.EventHandler(this.prodesc_txt_Leave);
            // 
            // addpro_btn
            // 
            this.addpro_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addpro_btn.BackColor = System.Drawing.Color.Transparent;
            this.addpro_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addpro_btn.Location = new System.Drawing.Point(255, 582);
            this.addpro_btn.Margin = new System.Windows.Forms.Padding(2);
            this.addpro_btn.Name = "addpro_btn";
            this.addpro_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addpro_btn.Size = new System.Drawing.Size(122, 21);
            this.addpro_btn.TabIndex = 7;
            this.addpro_btn.UseVisualStyleBackColor = false;
            this.addpro_btn.Click += new System.EventHandler(this.addpro_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back_btn.BackColor = System.Drawing.Color.Transparent;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back_btn.Location = new System.Drawing.Point(256, 616);
            this.back_btn.Margin = new System.Windows.Forms.Padding(2);
            this.back_btn.Name = "back_btn";
            this.back_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.back_btn.Size = new System.Drawing.Size(122, 21);
            this.back_btn.TabIndex = 0;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // AddProForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.addpro_btn);
            this.Controls.Add(this.prodesc_txt);
            this.Controls.Add(this.barcode_txt);
            this.Controls.Add(this.quantity_txt);
            this.Controls.Add(this.proprice_txt);
            this.Controls.Add(this.cat_combox);
            this.Controls.Add(this.proname_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddProForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة منتج";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddProForm_FormClosing);
            this.Load += new System.EventHandler(this.AddProForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox proname_txt;
        private System.Windows.Forms.ComboBox cat_combox;
        private System.Windows.Forms.TextBox proprice_txt;
        private System.Windows.Forms.TextBox quantity_txt;
        private System.Windows.Forms.TextBox barcode_txt;
        private System.Windows.Forms.TextBox prodesc_txt;
        private System.Windows.Forms.Button addpro_btn;
        private System.Windows.Forms.Button back_btn;
    }
}