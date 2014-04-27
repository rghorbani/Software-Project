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
    public partial class MakeGroup : Form
    {
        ReceiverGroup _group;
        public MakeGroup()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnMakeGroup_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string description = txtDescription.Text;
            if (string.IsNullOrEmpty(title) ||
                string.IsNullOrEmpty(description) )
            {
                MessageBox.Show("خطا: تمام قسمت ها را پر کنید.");
            }
            else
            {
                _group = new ReceiverGroup(1,title, description);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Database.getDatabase().AddRecieverGroup(_group);
                MessageBox.Show("گروه اضافه شد!");

            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
