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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateTemplate createtemplate = new CreateTemplate();
            createtemplate.Show();
            
        }

        private void btnShowTemps_Click(object sender, EventArgs e)
        {
            ShowTemplates showTemplates = new ShowTemplates();
            // showTemplates.Controls.Add(new Label { Text = "fuck you" });
            showTemplates.Show();
        }
    }
}
