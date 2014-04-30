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
    public partial class EditReceiversOfTemplate : Form
    {
        private List<ReceiverGroup> Oldselected_groups;
        private List<Receiver> Oldselected_receivers;
        private List<ReceiverGroup> Newselected_groups;
        private List<Receiver> Newselected_receivers;
        private List<ReceiverGroup> groups;
        private List<Receiver> receivers;
        private ReceiverGroup selectedGroup;
        private Receiver selectedReceiver;
        int template_id;
        public EditReceiversOfTemplate(int id)
        {
            InitializeComponent();
            template_id = id;
            groups = Database.getDatabase().getReceiverGroups();
            Oldselected_groups = Database.getDatabase().getGroupsOfTemplate(template_id);
            Oldselected_receivers = Database.getDatabase().getReceiversOfTemplate(template_id);
            Newselected_groups = new List<ReceiverGroup>();
            Newselected_receivers = new List<Receiver>();
            receivers = null;
            for (int i = 0; i < groups.Count; i++) 
            {
                GroupsDropDown.Items.Add(groups[i].title);
            }

            for (int i = 0; i < Oldselected_groups.Count; i++)
            {
                Newselected_groups.Add(Oldselected_groups[i]);
                listBox1.Items.Add(Oldselected_groups[i].title);                
            }
            for (int i = 0; i < Oldselected_receivers.Count; i++)
            {
                Newselected_receivers.Add(Oldselected_receivers[i]);
                listBox2.Items.Add(Oldselected_receivers[i].FName + " " + Oldselected_receivers[i].LName);
            }
        }

        private void EditReceiversOfTemplate_Load(object sender, EventArgs e)
        {
            this.listBox1.MouseDoubleClick += new MouseEventHandler(listBox1_MouseDoubleClick);
            this.listBox2.MouseDoubleClick += new MouseEventHandler(listBox2_MouseDoubleClick);
        }
        void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                listBox1.Items.RemoveAt(index);
                Newselected_groups.RemoveAt(index);
            }
        }

        void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox2.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                listBox2.Items.RemoveAt(index);
                Newselected_receivers.RemoveAt(index);
            }
        }


        private void GroupsDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedGroup = groups[GroupsDropDown.SelectedIndex];
            receivers = Database.getDatabase().GetReceiversOfGroup(selectedGroup.id);
            if (ReceiversDropDown.Items.Count > 0)
                ReceiversDropDown.Items.Clear();

            for (int i = 0; i < receivers.Count; i++)
            {
                ReceiversDropDown.Items.Add(receivers[i].FName + " " + receivers[i].LName);
            }
        }


        private void ReceiversDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedReceiver = receivers[ReceiversDropDown.SelectedIndex];
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            if (selectedGroup != null)
            {
                for (int i = 0; i < Newselected_groups.Count; i++)
                    if (Newselected_groups[i].id == selectedGroup.id)
                        return;
                Newselected_groups.Add(selectedGroup);
                listBox1.Items.Add(selectedGroup.title);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedReceiver != null)
            {
                for (int i = 0; i < Newselected_receivers.Count; i++)
                    if (Newselected_receivers[i].ID == selectedReceiver.ID)
                        return;
                Newselected_receivers.Add(selectedReceiver);
                listBox2.Items.Add(selectedReceiver.FName + " " + selectedReceiver.LName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //adding new receivers
            for (int i = 0; i < Newselected_receivers.Count; i++)
            {
                bool existed = false;
                for (int j = 0; j < Oldselected_receivers.Count; j++)
                {
                    if (Newselected_receivers[i].ID == Oldselected_receivers[j].ID)
                    {
                        existed = true;
                        break;
                    }
                }
                if (existed)
                    continue;
                Database.getDatabase().AddReceiverToTemplate(Newselected_receivers[i].ID, template_id);
            }
            //removing deleted receivers
            for (int i = 0; i < Oldselected_receivers.Count; i++)
            {
                bool deleted = true;
                for (int j = 0; j < Newselected_receivers.Count; j++)
                {
                    if (Oldselected_receivers[i].ID == Newselected_receivers[j].ID)
                    {
                        deleted = false;
                        break;
                    }
                }
                if (deleted)
                {
                    Database.getDatabase().removeReceiverOfTemplate(Oldselected_receivers[i].ID, template_id);
                }
            }
            //adding new groups
            for (int i = 0; i < Newselected_groups.Count; i++)
            {
                bool existed = false;
                for (int j = 0; j < Oldselected_groups.Count; j++)
                {
                    if (Newselected_groups[i].id == Oldselected_groups[j].id)
                    {
                        existed = true;
                        break;
                    }
                }
                if (existed)
                    continue;
                Database.getDatabase().AddGroupToTemplate(Newselected_groups[i].id, template_id);
            }
            //removing deleted groups
            for (int i = 0; i < Oldselected_groups.Count; i++)
            {
                bool deleted = true;
                for (int j = 0; j < Newselected_groups.Count; j++)
                {
                    if (Oldselected_groups[i].id == Newselected_groups[j].id)
                    {
                        deleted = false;
                        break;
                    }
                }
                if (deleted)
                {
                    Database.getDatabase().removeGroupOfTemplate(Oldselected_groups[i].id, template_id);
                }
            }
            this.Close();

        }

    }
}
