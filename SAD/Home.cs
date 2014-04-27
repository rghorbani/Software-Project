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
            showTemplates.Show();
        }

        private void btnAddReciever_Click(object sender, EventArgs e)
        {
            AddReciever addReciever = new AddReciever();
            addReciever.Show();
            
        }

        private void btnMakeGroup_Click(object sender, EventArgs e)
        {
            MakeGroup makeGroup = new MakeGroup();
            makeGroup.Show();

        }

        private void btnShowGroup_Click(object sender, EventArgs e)
        {
            ShowReceiverGroups showGroups = new ShowReceiverGroups();
            showGroups.Show();
        }

    }
}
