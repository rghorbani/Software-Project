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
    public partial class AddReceiversToGroup : Form
    {
        private int group_id;
        private List<Receiver> receivers;
        private List<Receiver> OldreceiversOfGroup;
        private List<Receiver> NewreceiversOfGroup;
        public AddReceiversToGroup(int id)
        {
            InitializeComponent();
            this.group_id = id;
            NewreceiversOfGroup = new List<Receiver>();
            OldreceiversOfGroup = Database.getDatabase().GetReceiversOfGroup(group_id);
            for (int i = 0; i < OldreceiversOfGroup.Count; i++)
            {
                listBox1.Items.Add(OldreceiversOfGroup[i].FName + " " + OldreceiversOfGroup[i].LName);
                NewreceiversOfGroup.Add(OldreceiversOfGroup[i]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddReceiversToGroup_Load(object sender, EventArgs e)
        {
            receivers = Database.getDatabase().getReceivers();
            for (int i = 0; i < receivers.Count; i++)
            {
                ReceiversDropDown.Items.Add(receivers[i].FName + " " + receivers[i].LName);
            }
            this.listBox1.MouseDoubleClick += new MouseEventHandler(listBox1_MouseDoubleClick);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ReceiversDropDown.SelectedIndex >= 0)
            {
                int receiver_id = receivers[ReceiversDropDown.SelectedIndex].ID;
                for (int i = 0; i < NewreceiversOfGroup.Count; i++)
                    if (NewreceiversOfGroup[i].ID == receiver_id)
                        return;
                NewreceiversOfGroup.Add(receivers[ReceiversDropDown.SelectedIndex]);
                listBox1.Items.Add(receivers[ReceiversDropDown.SelectedIndex].FName + " " + receivers[ReceiversDropDown.SelectedIndex].LName);
            }
        }

        private void ReceiversDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < NewreceiversOfGroup.Count; i++)
            {
                bool existed = false;
                for (int j = 0; j < OldreceiversOfGroup.Count; j++) {
                    if (NewreceiversOfGroup[i].ID == OldreceiversOfGroup[j].ID) {
                        existed = true;
                        break;
                    }
                }
                if (existed)
                    continue;
                Database.getDatabase().AddReceiverToGroup(group_id, NewreceiversOfGroup[i].ID);
            }
            for(int i=0; i< OldreceiversOfGroup.Count; i++) {
                bool deleted = true;
                for(int j=0; j<NewreceiversOfGroup.Count; j++){
                    if( OldreceiversOfGroup[i].ID == NewreceiversOfGroup[j].ID){
                        deleted = false;
                        break;
                    }
                }
                if(deleted){
                    Database.getDatabase().removeReceiverOfGroup(OldreceiversOfGroup[i].ID, group_id);
                }
            }
            this.Close();

            //Database.getDatabase().AddReceiverToGroup(group_id,receiver_id);
        }
        void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                listBox1.Items.RemoveAt(index);
                NewreceiversOfGroup.RemoveAt(index);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
