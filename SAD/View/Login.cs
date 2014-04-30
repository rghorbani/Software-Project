using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if ((Database.getDatabase().IsRegistered(txtUser.Text, txtPass.Text)))
            {
                MessageBox.Show("شما وارد شدید!");
                Home home = new Home();
                home.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("نام کاربری یا کلمه عبور اشتباه است");
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
