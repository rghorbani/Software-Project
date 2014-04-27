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
        private string p;
        private int group_id;
        private List<List<string>> l;
        public AddReceiversToGroup(int id)
        {
            InitializeComponent();
            this.group_id = id;
        }

        public AddReceiversToGroup(string p)
        {
            // TODO: Complete member initialization
            this.p = p;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddReceiversToGroup_Load(object sender, EventArgs e)
        {
            l = Database.getDatabase().FillDropDownReceivers();
            for (int i = 0; i < l.Count; i++) {
                ReceiversDropDown.Items.Add(l[i][1] + " " + l[i][2]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int receiver_id = Convert.ToInt32(l[ReceiversDropDown.SelectedIndex][0]);
            Database.getDatabase().AddReceiverToGroup(group_id,receiver_id);
        }

        private void ReceiversDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
