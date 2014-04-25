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
    public partial class EditDateTemplate : Form
    {
        public EditDateTemplate(int r)
        {
            InitializeComponent();
            row = r;
            List<Template> templates = Database.getDatabase().getTemplates();
            dateTime.Value = templates[row].SentTime ;
            
        }
        private int row;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Template> templates = Database.getDatabase().getTemplates();
            templates[row].SentTime = dateTime.Value;
            this.Close();
        }
    }
}
