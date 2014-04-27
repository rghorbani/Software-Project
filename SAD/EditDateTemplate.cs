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
        public EditDateTemplate(int template_id, DateTime template_sent_time)
        {
            InitializeComponent();
            row = template_id;
//            List<Template> templates = Database.getDatabase().getTemplates();
            dateTime.Value = template_sent_time ;
            
        }
        private int row;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string query = "UPDATE templates SET name='Joe', age='22' WHERE name='John Smith'";
            //List<Template> templates = Database.getDatabase().getTemplates();
            //templates[row].SentTime = dateTime.Value;
            this.Close();
        }
    }
}
