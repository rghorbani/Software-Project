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

        private Template _template;
        private List<ReceiverGroup> selected_groups;
        private List<ReceiverGroup> groups;
        private List<Receiver> receiversOfGroup;
        private ReceiverGroup selectedGroup;
        private Receiver selectedReceiver;
        private List<Receiver> selected_receivers;
        public CreateTemplate()
        {
            InitializeComponent();
            // templates = new List<Template>();    
            selected_groups = new List<ReceiverGroup>();
            selected_receivers = new List<Receiver>();
        }

        private void CreateTemplate_Load(object sender, EventArgs e)
        {
            groups = Database.getDatabase().getReceiverGroups();

            
            for (int i = 0; i < groups.Count; i++) {
                GroupsDropDown.Items.Add(groups[i].title);
            }

            this.listBox1.MouseDoubleClick += new MouseEventHandler(listBox1_MouseDoubleClick);
            this.listBox2.MouseDoubleClick += new MouseEventHandler(listBox2_MouseDoubleClick);
        }

        void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                //MessageBox.Show(index.ToString());
                listBox1.Items.RemoveAt(index);
                selected_groups.RemoveAt(index);
            }
        }

        void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                //MessageBox.Show(index.ToString());
                listBox1.Items.RemoveAt(index);
                selected_receivers.RemoveAt(index);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateTemp_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string text = txtText.Text;
            string receivers = "";
            DateTime senttime = dtsenttime.Value;
            bool periodic = false;
            bool isAutomatic = false;
            bool error = false;
            int type = 0;
            if(YesToPeriodic.Checked){
                periodic = true;
            } else if(NoToPeriodic.Checked) {
                periodic = false;
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
            if (periodic)
            {
                if (month1.Checked)
                {
                    type = 1;
                }
                else if (month3.Checked)
                {
                    type = 2;
                }
                else if (month6.Checked)
                {
                    type = 3;
                }
                else if (year.Checked)
                {
                    type = 4;
                }
                else
                {
                    error = true;
                }
            }
            else
                type = 0;
            
            if (string.IsNullOrEmpty(title) ||
                string.IsNullOrEmpty(text) ||                
                error)
            {
                MessageBox.Show("خطا: تمام قسمت ها را پر کنید.");
            }
            else
            {
                _template = new Template(1,title, text, receivers, periodic, senttime, isAutomatic, type);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Database.getDatabase().AddTemplate(_template,selected_groups, selected_receivers);
                

                MessageBox.Show("قالب با موفقیت اضافه شد");
                this.Close();
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }

        private void NoToPeriodic_CheckedChanged(object sender, EventArgs e)
        {
            if (NoToPeriodic.Checked)
            {
                month1.Enabled = false;
                month3.Enabled = false;
                month6.Enabled = false;
                year.Enabled = false;
            }
            else {
                month1.Enabled = true;
                month3.Enabled = true;
                month6.Enabled = true;
                year.Enabled = true;
            
            }
        }

        private void GroupsDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedGroup = groups[GroupsDropDown.SelectedIndex];
            receiversOfGroup = Database.getDatabase().GetReceiversOfGroup(selectedGroup.id); 
            if (ReceiversDropDown.Items.Count > 0)
                ReceiversDropDown.Items.Clear();

            for (int i = 0; i < receiversOfGroup.Count; i++)
            {
                ReceiversDropDown.Items.Add(receiversOfGroup[i].FName + " " + receiversOfGroup[i].LName);
            }
            
        }

        private void month6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void year_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void month3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void month1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void YesToPeriodic_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void YesToAutomatic_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NoToAutomatic_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtsenttime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedGroup != null)
            {
                selected_groups.Add(selectedGroup);
                listBox1.Items.Add(selectedGroup.title);
            }
        }

        private void ReceiversDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedReceiver= receiversOfGroup[ReceiversDropDown.SelectedIndex]; 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (selectedReceiver != null)
            {
                selected_receivers.Add(selectedReceiver);
                listBox2.Items.Add(selectedReceiver.LName);
            }
        }

    }
}
