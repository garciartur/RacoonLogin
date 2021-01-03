using RacoonLogin.Model;
using RacoonLogin.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacoonLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controling control = new Controling();
            control.Access(txtLogin.Text, txtPassword.Text);
            if (control.message.Equals(""))
            {
                if (control.verified)
                {
                    MessageBox.Show("you're in!", "loading...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //cria instância do formulário de boas vindas
                    Welcome welcome = new Welcome();
                    welcome.Show();
                }
                else MessageBox.Show("you're WRONG!!! Try again...", "ERROR!!!!!!!!!!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show(control.message);
           
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
