using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suyog
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            lb_error.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Tb_userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if(tb_userName.Text=="shree"&& tb_password.Text == "shree")
            {
                Form std = this;
                Home home = new Home();
                home.ShowDialog();
                std.Close();

            }
            else
            {
                MessageBox.Show("Username or password incorrect.");
            }
        }
    }
}
