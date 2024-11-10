namespace PayrollMgmtSystem
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
            this.btn_sign = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_reg = new System.Windows.Forms.Button();
            this.txt_uname = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.lbl_uname = new System.Windows.Forms.Label();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_sign
            // 
            this.btn_sign.Location = new System.Drawing.Point(398, 174);
            this.btn_sign.Name = "btn_sign";
            this.btn_sign.Size = new System.Drawing.Size(75, 23);
            this.btn_sign.TabIndex = 0;
            this.btn_sign.Text = "Sign In";
            this.btn_sign.UseVisualStyleBackColor = true;
            this.btn_sign.Click += new System.EventHandler(this.btn_sign_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(249, 174);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 0;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_reg
            // 
            this.btn_reg.Location = new System.Drawing.Point(398, 37);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(75, 23);
            this.btn_reg.TabIndex = 0;
            this.btn_reg.Text = "Register";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // txt_uname
            // 
            this.txt_uname.Location = new System.Drawing.Point(154, 40);
            this.txt_uname.Name = "txt_uname";
            this.txt_uname.Size = new System.Drawing.Size(144, 20);
            this.txt_uname.TabIndex = 1;
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(154, 89);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(144, 20);
            this.txt_pwd.TabIndex = 1;
            // 
            // lbl_uname
            // 
            this.lbl_uname.AutoSize = true;
            this.lbl_uname.Location = new System.Drawing.Point(47, 43);
            this.lbl_uname.Name = "lbl_uname";
            this.lbl_uname.Size = new System.Drawing.Size(55, 13);
            this.lbl_uname.TabIndex = 2;
            this.lbl_uname.Text = "Username";
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Location = new System.Drawing.Point(47, 96);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(53, 13);
            this.lbl_pwd.TabIndex = 2;
            this.lbl_pwd.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 222);
            this.Controls.Add(this.lbl_pwd);
            this.Controls.Add(this.lbl_uname);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_uname);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_sign);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sign;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.TextBox txt_uname;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Label lbl_uname;
        private System.Windows.Forms.Label lbl_pwd;
    }
}

