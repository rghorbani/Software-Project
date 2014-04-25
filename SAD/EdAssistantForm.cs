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
    public partial class EdAssistantForm : Form
    {
        private EducationAssistant _eduassistant;
        // public static List<EducationAssistant> eduAssistants { get; set; }

        public EdAssistantForm()
        {
            InitializeComponent();
            // eduAssistants = new List<EducationAssistant>();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string uname = txtUser.Text;
            string password = txtPass.Text;
            string email = txtEmail.Text;
            string name = txtName.Text;

            if (string.IsNullOrEmpty(uname) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Error: Complete all the fields!");
            }
            else
            {
                _eduassistant = new EducationAssistant(uname, password, email, name);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Database.getDatabase().addUser(_eduassistant);
                MessageBox.Show("Count: " + Database.getDatabase().countOfUsers());
                txtUser.Text = "";
                txtPass.Text = "";
                txtEmail.Text = "";
                txtName.Text = "";
                //this.Close();


            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            // login.Closed += (sender, args) => this.Close();
            login.Show();
            // this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
