using RacoonLogin.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacoonLogin.Presentation
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Controling control = new Controling();
            var message = control.Register(txtLogin.Text, txtPassword.Text, txtPswdConf.Text);
            if (control.verified)
                MessageBox.Show(message, "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show(control.message);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
