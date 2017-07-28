namespace SuperGYM
{
    partial class DeletePro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletePro));
            this.DeleteProduct = new System.Windows.Forms.Button();
            this.ReturnHome = new System.Windows.Forms.Button();
            this.cats_combox = new System.Windows.Forms.ComboBox();
            this.pro_combox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteProduct.BackColor = System.Drawing.Color.Transparent;
            this.DeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteProduct.Location = new System.Drawing.Point(251, 525);
            this.DeleteProduct.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DeleteProduct.Size = new System.Drawing.Size(178, 35);
            this.DeleteProduct.TabIndex = 8;
            this.DeleteProduct.UseVisualStyleBackColor = false;
            this.DeleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // ReturnHome
            // 
            this.ReturnHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReturnHome.BackColor = System.Drawing.Color.Transparent;
            this.ReturnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReturnHome.Location = new System.Drawing.Point(251, 577);
            this.ReturnHome.Margin = new System.Windows.Forms.Padding(2);
            this.ReturnHome.Name = "ReturnHome";
            this.ReturnHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ReturnHome.Size = new System.Drawing.Size(178, 36);
            this.ReturnHome.TabIndex = 9;
            this.ReturnHome.UseVisualStyleBackColor = false;
            this.ReturnHome.Click += new System.EventHandler(this.ReturnHome_Click);
            // 
            // cats_combox
            // 
            this.cats_combox.FormattingEnabled = true;
            this.cats_combox.Location = new System.Drawing.Point(330, 379);
            this.cats_combox.Name = "cats_combox";
            this.cats_combox.Size = new System.Drawing.Size(183, 21);
            this.cats_combox.TabIndex = 10;
            this.cats_combox.Text = "اسم الصنف";
            this.cats_combox.SelectedIndexChanged += new System.EventHandler(this.cats_combox_SelectedIndexChanged);
            // 
            // pro_combox
            // 
            this.pro_combox.FormattingEnabled = true;
            this.pro_combox.Location = new System.Drawing.Point(330, 445);
            this.pro_combox.Name = "pro_combox";
            this.pro_combox.Size = new System.Drawing.Size(183, 21);
            this.pro_combox.TabIndex = 11;
            this.pro_combox.Text = "اسم المنتج";
            // 
            // DeletePro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.pro_combox);
            this.Controls.Add(this.cats_combox);
            this.Controls.Add(this.ReturnHome);
            this.Controls.Add(this.DeleteProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DeletePro";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حذف منتج";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeletePro_FormClosing);
            this.Load += new System.EventHandler(this.DeletePro_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeleteProduct;
        private System.Windows.Forms.Button ReturnHome;
        private System.Windows.Forms.ComboBox cats_combox;
        private System.Windows.Forms.ComboBox pro_combox;
    }
}