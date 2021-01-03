
namespace RacoonLogin.Presentation
{
    partial class Register
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPswd = new System.Windows.Forms.Label();
            this.txtPswdConf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLogin.Location = new System.Drawing.Point(14, 39);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(44, 18);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "login";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Lime;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("Short Xurkit Tilt", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.Green;
            this.btnRegister.Location = new System.Drawing.Point(17, 199);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(287, 158);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "BECOME A\r\nRACOON !!!";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(17, 60);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(287, 24);
            this.txtLogin.TabIndex = 2;
            this.txtLogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(17, 108);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(287, 24);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblPswd
            // 
            this.lblPswd.AutoSize = true;
            this.lblPswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPswd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPswd.Location = new System.Drawing.Point(14, 87);
            this.lblPswd.Name = "lblPswd";
            this.lblPswd.Size = new System.Drawing.Size(81, 18);
            this.lblPswd.TabIndex = 3;
            this.lblPswd.Text = "password";
            // 
            // txtPswdConf
            // 
            this.txtPswdConf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPswdConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPswdConf.Location = new System.Drawing.Point(17, 156);
            this.txtPswdConf.Name = "txtPswdConf";
            this.txtPswdConf.Size = new System.Drawing.Size(287, 24);
            this.txtPswdConf.TabIndex = 6;
            this.txtPswdConf.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(14, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "password... again!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Lime;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnExit.Location = new System.Drawing.Point(17, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(22, 20);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(323, 376);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtPswdConf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPswd);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblLogin);
            this.ForeColor = System.Drawing.Color.GhostWhite;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPswd;
        private System.Windows.Forms.TextBox txtPswdConf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
    }
}