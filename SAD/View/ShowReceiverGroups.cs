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
    public partial class ShowReceiverGroups : Form
    {
        public List<ReceiverGroup> groups;
        
        public ShowReceiverGroups()
        {
            InitializeComponent();
            groups = Database.getDatabase().getReceiverGroups();
            RefreshList();
        }

        private void ShowReceiverGroups_Load(object sender, EventArgs e)
        {
            dataGridViewGroups.CellClick += new DataGridViewCellEventHandler(dataGridViewGroups_CellContentClick);
            RefreshList();
        }

        public void btnMakeGroup_Click(object sender, EventArgs e)
        {
            MakeGroup makeGroup = new MakeGroup();
            makeGroup.Show();

            RefreshList();

        }

        private void RefreshList()
        {

            dataGridViewGroups.Rows.Clear();

            foreach (ReceiverGroup group in groups)
            {
                object[] groupProps = new object[3];
                groupProps[2] = group.title;
                groupProps[0] = "مشاهده";
                groupProps[1] = "مشاهده";
                //groupProps[7] = "اعمال تغییر";

                dataGridViewGroups.Rows.Add(groupProps);
            }
        }

        private void dataGridViewGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewGroups.Columns["Receivers"].Index && e.RowIndex >= 0)
            {
                AddReceiversToGroup addreceivertogroup = new AddReceiversToGroup(groups[e.RowIndex].id);
                addreceivertogroup.Show();
            }
        }


    }
}
