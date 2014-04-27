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
    public partial class AddReciever : Form
    {
        private Receiver _receiver;

        public AddReciever()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddReciever_Load(object sender, EventArgs e)
        {

        }

        private void txtField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnAddReciever_Click(object sender, EventArgs e)
        {
            string fName = txtFName.Text;
            string lName = txtLName.Text;
            string email = txtEmail.Text;
            string role = "";
            //MessageBox.Show(optionRole.Text);
            if (optionRole.Text.Equals("دانشجو"))
                role = "student";
            else
                role = "professor";

            if (string.IsNullOrEmpty(fName) ||
                string.IsNullOrEmpty(lName)||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(role))
            {
                MessageBox.Show("خطا: تمام قسمت ها را پر کنید.");
            }
            else
            {
                _receiver = new Receiver(fName, lName, email, role);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Database.getDatabase().AddReciever(_receiver);
                MessageBox.Show("مخاطب اضافه شد!");

            }
        }
    }
}
