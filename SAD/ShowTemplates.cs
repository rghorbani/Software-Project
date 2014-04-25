using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SAD
{
    public partial class ShowTemplates : Form
    {
        public ShowTemplates()
        {
            InitializeComponent();
        }

        private void ShowTemplates_Load(object sender, EventArgs e)
        {
            templateGridView.CellClick += new DataGridViewCellEventHandler(templateGridView_CellContentClick);
            RefreshList();
        }

        private void addTemplate_Click(object sender, EventArgs e)
        {
            CreateTemplate createtemplate = new CreateTemplate();
            createtemplate.Show();

            RefreshList();
        }

        private void RefreshList() {
            List<Template> templates = Database.getDatabase().getTemplates();

            templateGridView.Rows.Clear();

            foreach (Template temp in templates)
            {
                object[] tempProps = new object[9];
                tempProps[0] = temp.Title;
                tempProps[1] = "مشاهده";
                foreach(string reciever in temp.TemplateReceiver)
                    tempProps[2] += reciever + "\r";
                tempProps[3] = temp.Priority;
                tempProps[4] = temp.HasReminder;
                tempProps[5] = temp.IsAutomatic;
                tempProps[6] = temp.CreateTask;
                tempProps[7] = "مشاهده";
                tempProps[8] = "اعمال تغییر";
                
                templateGridView.Rows.Add(tempProps);
            }
        }

        private void templateGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Template> templates = Database.getDatabase().getTemplates();
            if (e.ColumnIndex == templateGridView.Columns["Column2"].Index && e.RowIndex >= 0)
            {
                EditTextTemplate edtexttemplate = new EditTextTemplate(e.RowIndex);
                edtexttemplate.Show();                
            }
            else if (e.ColumnIndex == templateGridView.Columns["Column8"].Index && e.RowIndex >= 0)
            {
                EditDateTemplate edDateTemplate = new EditDateTemplate(e.RowIndex);
                edDateTemplate.Show();
            }
            else if (e.ColumnIndex == templateGridView.Columns["Column9"].Index && e.RowIndex >= 0)
            {
                templates[e.RowIndex].Title = templateGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                string[] rcv = Regex.Split(templateGridView.Rows[e.RowIndex].Cells[2].Value.ToString(), "\r\n");
                templates[e.RowIndex].TemplateReceiver = new List<string>(rcv);
                templates[e.RowIndex].Priority = templateGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (templateGridView.Rows[e.RowIndex].Cells[4].Value.ToString().Equals("True"))
                    templates[e.RowIndex].HasReminder = true;
                else
                    templates[e.RowIndex].HasReminder = false;
                if (templateGridView.Rows[e.RowIndex].Cells[5].Value.ToString().Equals("True"))
                    templates[e.RowIndex].IsAutomatic = true;
                else
                    templates[e.RowIndex].IsAutomatic = false;
                if (templateGridView.Rows[e.RowIndex].Cells[6].Value.ToString().Equals("True"))
                    templates[e.RowIndex].CreateTask = true;
                else
                    templates[e.RowIndex].CreateTask = false;
                MessageBox.Show("Change succesfully:)");
            }
        }
    }
}
