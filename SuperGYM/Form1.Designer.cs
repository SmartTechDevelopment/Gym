namespace SuperGYM
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ps_tb = new System.Windows.Forms.TextBox();
            this.un_tb = new System.Windows.Forms.TextBox();
            this.signin_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ps_tb
            // 
            this.ps_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ps_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ps_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ps_tb.Location = new System.Drawing.Point(340, 418);
            this.ps_tb.Margin = new System.Windows.Forms.Padding(2);
            this.ps_tb.Name = "ps_tb";
            this.ps_tb.PasswordChar = '*';
            this.ps_tb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ps_tb.Size = new System.Drawing.Size(145, 31);
            this.ps_tb.TabIndex = 2;
            this.ps_tb.Text = "000000";
            this.ps_tb.UseSystemPasswordChar = true;
            this.ps_tb.Enter += new System.EventHandler(this.ps_tb_Enter);
            this.ps_tb.Leave += new System.EventHandler(this.ps_tb_Leave);
            // 
            // un_tb
            // 
            this.un_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.un_tb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.un_tb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.un_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.un_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.un_tb.Location = new System.Drawing.Point(340, 368);
            this.un_tb.Margin = new System.Windows.Forms.Padding(2);
            this.un_tb.Name = "un_tb";
            this.un_tb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.un_tb.Size = new System.Drawing.Size(145, 31);
            this.un_tb.TabIndex = 1;
            this.un_tb.Text = "اسم المستخدم";
            this.un_tb.Enter += new System.EventHandler(this.un_tb_Enter);
            this.un_tb.Leave += new System.EventHandler(this.un_tb_Leave);
            // 
            // signin_btn
            // 
            this.signin_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signin_btn.BackColor = System.Drawing.Color.Transparent;
            this.signin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signin_btn.Location = new System.Drawing.Point(340, 473);
            this.signin_btn.Margin = new System.Windows.Forms.Padding(2);
            this.signin_btn.Name = "signin_btn";
            this.signin_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.signin_btn.Size = new System.Drawing.Size(169, 33);
            this.signin_btn.TabIndex = 0;
            this.signin_btn.UseVisualStyleBackColor = false;
            this.signin_btn.Click += new System.EventHandler(this.signin_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.signin_btn);
            this.Controls.Add(this.ps_tb);
            this.Controls.Add(this.un_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ps_tb;
        private System.Windows.Forms.TextBox un_tb;
        private System.Windows.Forms.Button signin_btn;
    }
}

