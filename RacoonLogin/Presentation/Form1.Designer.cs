
namespace RacoonLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPswd = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Short Xurkit Tilt", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(233, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 84);
            this.label1.TabIndex = 7;
            this.label1.Text = "ARE YOU A \r\nRACOON?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblPswd
            // 
            this.lblPswd.AutoSize = true;
            this.lblPswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPswd.Location = new System.Drawing.Point(237, 152);
            this.lblPswd.Name = "lblPswd";
            this.lblPswd.Size = new System.Drawing.Size(73, 18);
            this.lblPswd.TabIndex = 4;
            this.lblPswd.Text = "password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(240, 173);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '$';
            this.txtPassword.Size = new System.Drawing.Size(177, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Magenta;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 10;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(342, 205);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.UseWaitCursor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Lime;
            this.btnEnter.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnEnter.FlatAppearance.BorderSize = 10;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnEnter.Location = new System.Drawing.Point(240, 205);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "ENTER";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.BlueViolet;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Font = new System.Drawing.Font("Short Xurkit Tilt", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNew.Location = new System.Drawing.Point(17, 242);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(400, 52);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "be a racoon!";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtLogin.Location = new System.Drawing.Point(240, 129);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(177, 20);
            this.txtLogin.TabIndex = 12;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(237, 108);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(39, 18);
            this.lblLogin.TabIndex = 11;
            this.lblLogin.Text = "login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(435, 310);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPswd);
            this.Controls.Add(this.btnEnter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPswd;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblLogin;
    }
}

