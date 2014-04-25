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
        public EditTextTemplate(int r)
        {
            InitializeComponent();
            row = r;
            List<Template> templates = Database.getDatabase().getTemplates();
            richTextBox1.Text = templates[row].Text;
        }
        public int row;
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Template> templates = Database.getDatabase().getTemplates();
            templates[row].Text = richTextBox1.Text;
            this.Close();
        }
    }
}
