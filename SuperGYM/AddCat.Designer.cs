namespace SuperGYM
{
    partial class AddCat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCat));
            this.CatName_text = new System.Windows.Forms.TextBox();
            this.CatDesc_Text = new System.Windows.Forms.TextBox();
            this.AddCat_Button = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CatName_text
            // 
            this.CatName_text.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.CatName_text, "CatName_text");
            this.CatName_text.Name = "CatName_text";
            this.CatName_text.Enter += new System.EventHandler(this.CatName_text_Enter);
            this.CatName_text.Leave += new System.EventHandler(this.CatName_text_Leave);
            // 
            // CatDesc_Text
            // 
            resources.ApplyResources(this.CatDesc_Text, "CatDesc_Text");
            this.CatDesc_Text.Name = "CatDesc_Text";
            this.CatDesc_Text.Enter += new System.EventHandler(this.CatDesc_Text_Enter);
            this.CatDesc_Text.Leave += new System.EventHandler(this.CatDesc_Text_Leave);
            // 
            // AddCat_Button
            // 
            resources.ApplyResources(this.AddCat_Button, "AddCat_Button");
            this.AddCat_Button.BackColor = System.Drawing.Color.Transparent;
            this.AddCat_Button.Name = "AddCat_Button";
            this.AddCat_Button.UseVisualStyleBackColor = false;
            this.AddCat_Button.Click += new System.EventHandler(this.AddCat_Button_Click);
            // 
            // Back_Button
            // 
            resources.ApplyResources(this.Back_Button, "Back_Button");
            this.Back_Button.BackColor = System.Drawing.Color.Transparent;
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.UseVisualStyleBackColor = false;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // AddCat
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.AddCat_Button);
            this.Controls.Add(this.CatDesc_Text);
            this.Controls.Add(this.CatName_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddCat";
            this.ShowIcon = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddCat_FormClosing);
            this.Load += new System.EventHandler(this.AddCat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CatName_text;
        private System.Windows.Forms.TextBox CatDesc_Text;
        private System.Windows.Forms.Button AddCat_Button;
        private System.Windows.Forms.Button Back_Button;
    }
}