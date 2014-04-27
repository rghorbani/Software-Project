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
        List<Template> templates;
        public ShowTemplates()
        {
            InitializeComponent();
            templates = Database.getDatabase().getTemplates();
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

            templateGridView.Rows.Clear();

            foreach (Template temp in templates)
            {
                object[] tempProps = new object[8];
                tempProps[0] = temp.Title;
                tempProps[1] = "مشاهده";
                foreach(string reciever in temp.TemplateReceiver)
                    tempProps[2] += reciever + "\r";
//                tempProps[4] = temp.HasReminder;
                tempProps[3] = temp.IsAutomatic;
                if (temp.Periodic)
                {
                    tempProps[4] = temp.Periodic;
                    if (temp.PeriodType == 1)
                        tempProps[5] = "یک ماهه";
                    if (temp.PeriodType == 2)
                        tempProps[5] = "سه ماهه";
                    if (temp.PeriodType == 3)
                        tempProps[5] = "شش ماهه";
                    if (temp.PeriodType == 4)
                        tempProps[5] = "یک ساله";
                }
                else
                {
                    tempProps[4] = false;
                    //tempProps[5] = "غیر دوره ای";
                    
                }
                tempProps[6] = "مشاهده";
                tempProps[7] = "اعمال تغییر";
                
                templateGridView.Rows.Add(tempProps);
            }
        }

        private void templateGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (templateGridView.Rows[e.RowIndex].Cells[4].Value.ToString().Equals("True") && templateGridView.Rows[e.RowIndex].Cells[5].Value == null )
            {
                MessageBox.Show("نوع دوره را مشخص کنید");
                return;
            }
            
            if (e.ColumnIndex == templateGridView.Columns["Column2"].Index && e.RowIndex >= 0)
            {
                EditTextTemplate edtexttemplate = new EditTextTemplate(templates[e.RowIndex].id, templates[e.RowIndex].Text);
                edtexttemplate.Show();                
            }
            else if (e.ColumnIndex == templateGridView.Columns["Column7"].Index && e.RowIndex >= 0)
            {
                EditDateTemplate edDateTemplate = new EditDateTemplate(templates[e.RowIndex].id, templates[e.RowIndex].SentTime);
                edDateTemplate.Show();
            }
            else if (e.ColumnIndex == templateGridView.Columns["Column8"].Index && e.RowIndex >= 0)
            {
                templates[e.RowIndex].Title = templateGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                string[] rcv = Regex.Split(templateGridView.Rows[e.RowIndex].Cells[2].Value.ToString(), "\r\n");
                templates[e.RowIndex].TemplateReceiver = new List<string>(rcv);
                //templates[e.RowIndex].Priority = templateGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (templateGridView.Rows[e.RowIndex].Cells[3].Value.ToString().Equals("True"))
                    templates[e.RowIndex].IsAutomatic = true;
                else
                    templates[e.RowIndex].IsAutomatic = false;
                if (templateGridView.Rows[e.RowIndex].Cells[4].Value.ToString().Equals("True"))
                {
                    templates[e.RowIndex].Periodic = true;
                    if (templateGridView.Rows[e.RowIndex].Cells[5].Value.ToString().Equals("یک ماهه"))
                        templates[e.RowIndex].PeriodType = 1;
                    else if (templateGridView.Rows[e.RowIndex].Cells[5].Value.ToString().Equals("سه ماهه"))
                        templates[e.RowIndex].PeriodType = 2;
                    else if (templateGridView.Rows[e.RowIndex].Cells[5].Value.ToString().Equals("شش ماهه"))
                        templates[e.RowIndex].PeriodType = 3;
                    else if (templateGridView.Rows[e.RowIndex].Cells[5].Value.ToString().Equals("یک ساله"))
                        templates[e.RowIndex].PeriodType = 4;                
                }
                else
                {
                    templates[e.RowIndex].Periodic = false;
                    templates[e.RowIndex].PeriodType = 0;
                }
                string query = "UPDATE templates SET title= '" + templates[e.RowIndex].Title + "', is_automatic= " + templates[e.RowIndex].IsAutomatic + ", is_periodic =" + templates[e.RowIndex].Periodic + ", period_type=" + templates[e.RowIndex].PeriodType + " where template_id= " + templates[e.RowIndex].id;
                //Database.con.Update(query);
                Database.getDatabase().Update(query);
                MessageBox.Show("تغییرات با موفقیت اعمال شد :)");
            }
        }
    }
}
