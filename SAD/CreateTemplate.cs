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

    public partial class CreateTemplate : Form
    {

        // public static List<Template> templates;
        private Template _template;
        public CreateTemplate()
        {
            InitializeComponent();
            // templates = new List<Template>();    
        }

        private void CreateTemplate_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateTemp_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string text = txtText.Text;
            string receivers = txtReceiver.Text;
            DateTime senttime = dtsenttime.Value;
            bool createTask = false;
            bool isAutomatic = false;
            bool hasReminder = false;
            bool error = false;
            string priority = "";
            if(YesToTask.Checked){
                createTask = true;
            } else if(NoToTask.Checked) {
                createTask = false;
            } else {
                error = true;
            }
            if(YesToAutomatic.Checked){
                isAutomatic = true;
            } else if(NoToAutomatic.Checked) {
                isAutomatic = false;
            } else {
                error = true;
            }
            if(YesToReminder.Checked){
                hasReminder = true;
            } else if(NoToReminder.Checked) {
                hasReminder = false;
            } else {
                error = true;
            }
            if (Priority.Text == "1" || Priority.Text == "2" || Priority.Text == "3" || Priority.Text == "4" || Priority.Text == "5") {
                priority = Priority.Text;
            } else {
                error = true;
            }
            if (string.IsNullOrEmpty(title) ||
                string.IsNullOrEmpty(text) ||
                string.IsNullOrEmpty(receivers) ||
                error)
            {
                MessageBox.Show("Error: Complete all the fields!");
            } else {
                _template = new Template(title, text, receivers, createTask, senttime, isAutomatic, hasReminder, priority);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Database.getDatabase().AddTemplate(_template);
                MessageBox.Show("Template added successfully!!!");
                


            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
        
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
