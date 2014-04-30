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
    public partial class EditTextTemplate : Form
    {
        public Template temp;
        public EditTextTemplate( Template template)
        {
            InitializeComponent();
            
;
            //List<Template> templates = Database.getDatabase().getTemplates();
            richTextBox1.Text = template.Text;
            temp = template;
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "UPDATE templates SET content='" + richTextBox1.Text + "' where template_id = " + temp.id;
            Database.con.Update(query);
            //List<Template> templates = Database.getDatabase().getTemplates();
            //templates[row].Text = richTextBox1.Text;
            temp.Text = richTextBox1.Text;
            this.Close();
        }
    }
}
