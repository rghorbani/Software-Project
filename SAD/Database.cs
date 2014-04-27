using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SAD
{
    class Database
    {
        private static Database db = null;
        public static DBConnect con = new DBConnect();
        // Lists
        private List<EducationAssistant> edAssistants;
        
        private static string current_user;
        
        private List<Template> templates;
        private List<Receiver> receivers;
        private List<ReceiverGroup> groups;
        private Database() {
            edAssistants = new List<EducationAssistant>();
            templates = new List<Template>();
            receivers = new List<Receiver>();
            groups = new List<ReceiverGroup>();

            //addUser(new EducationAssistant("admin", "admin", "admin", "admin"));
        }

        public static Database getDatabase() {
            if(db == null) {
                db = new Database();
            }
            return db;
        }

        //User related Functions
        public void addUser(EducationAssistant user) {
            //edAssistants.Add(user);

            string query;
            query = "Insert into users (username, password, email) VALUES ('"+user.Username + "','"+user.Password+ "','" + user.Email + "')" ;
            con.Insert(query);
        }

        public int countOfUsers() {
            //return edAssistants.Count;
            string query;
            query = "SELECT Count(*) FROM users";
            return con.Count(query);

        }

        public bool IsRegistered(string userName, string password) {

            /*for (int i = 0; i < edAssistants.Count; i++)
            {
                if (edAssistants.ElementAt(i).Username.Equals(userName) && edAssistants.ElementAt(i).Password.Equals(password))
                {
                    return edAssistants.ElementAt(i);
                }
            }
            return null;*/
            string query;
            query = "Select * from users where username = '" + userName + "' and password = '" + password + "'";
            List<List <string> > l = con.Select(query);
            if (l.Count == 0)
                return false;
            else{
                //MessageBox.Show(l[0][1]);    
                //if (l[0][1] == userName && l[0][2] == password)
                current_user = l[0][0];    
                return true;
                
            }
            

            /*if (l[1][0] == userName && l[2][0] == password) 
                return true;*/
            
        }

        // Template related Functions
        public List<Template> getTemplates() {
            
            string query;
            query = "Select * from templates";
            List<List <string> > l = con.Select(query);

            List<Template> temps = new List<Template>();
            for (int i = 0; i < l.Count; i++) {
                
                Template newTemplate = new Template(Convert.ToInt32(l[i][0]),l[i][3], l[i][4], "sd", l[i][6] == "True", DateTime.Now, l[i][8] == "True", Convert.ToInt32(l[i][7]));
                temps.Add(newTemplate);
            }
            return temps;
        }
        public void AddTemplate(Template template,List<ReceiverGroup> groups, List<Receiver> receivers) {
            templates.Add(template);
            //string  NowDateTime = string.Format("{0:YYYY-MM-dd}", DateTime.Now);
            //string sentTime = string.Format("{0:YYYY-MM-dd}", template.SentTime);
            //int periodic
            string query;
            //DateTime theDate = DateTime.Now;
            query = "Insert into templates (user_id, create_date, title, content, base_sent_time, is_periodic, period_type, is_automatic) VALUES ('" + current_user + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "'  ,'" + template.Title + "','" + template.Text + "','" + template.SentTime.ToString("yyyy-MM-dd") + "'," + template.Periodic + "," + template.PeriodType + "," + template.IsAutomatic + ")";
            con.Insert(query);

            query = "select MAX(template_id) from templates";
            int template_id = con.Count(query);
            for (int i = 0; i < groups.Count; i++)
            {
                query = "Insert into template_group(template_id,group_id) VALUES(" + template_id.ToString() + "," + groups[i].id.ToString() + ")";
                con.Insert(query);
            }
            for (int i = 0; i < receivers.Count; i++)
            {
                query = "Insert into template_receiver(template_id,receiver_id) VALUES(" + template_id.ToString() + "," + receivers[i].ID.ToString() + ")";
                con.Insert(query);
            }
            //if template.Periodic 
            int count = (template.PeriodType == 4)?12:(template.PeriodType == 3)?6:(template.PeriodType == 2)?3:(template.PeriodType == 1)?1:0;
            if (count != 0)
            {
                for (int i = 0; i < (24 / count); i++)
                {
                    //DateTime tmp = template.SentTime.AddMonths(count * (i + 1));
                    //Console.WriteLine(tmp.ToString("yyyy-MM-dd"));
                    query = "Insert into template_sent_time(template_id, sent_time) VALUES(" + template_id.ToString() + ", '" + template.SentTime.AddMonths(count * (i + 1)).ToString("yyyy-MM-dd") + "')";
                    con.Insert(query);

                }
            }
            else {
                query = "Insert into template_sent_time(template_id, sent_time) VALUES(" + template_id.ToString() + ", '" + template.SentTime.ToString("yyyy-MM-dd") + "')";
                con.Insert(query);            
            }
        }

        public void AddReciever(Receiver receiver) {
            //receivers.Add(receiver);
            string query = "Insert into receivers (first_name , last_name, email, role) VALUES ('" + receiver.FName + "', '" + receiver.LName + "','" + receiver.Email + "','" + receiver.Role + "')";
            Database.con.Insert(query);
        }
        public List<Receiver> getReceivers(){
            return receivers;
        }

        public void AddRecieverGroup(ReceiverGroup _group)
        {
            //groups.Add(_group);
            string query = "Insert into groups (group_name , description) VALUES ('" + _group.title + "', '" + _group.description + "')";
            Database.con.Insert(query);

        }
        public List< List<string> > FillDropDownReceivers() 
        {
            string query = "Select * from receivers";
            return Database.con.Select(query);

            //Database.con.FillDropDownList(query,dropdown);

        
        }

        public void AddReceiverToGroup(int group_id, int receiver_id) {
            //string query = "Insert INTO join_group_receiver(group_id)(select group_id from groups where group_name = 'test')";
            //string query = "Insert INTO join_group_receiver(group_id,receiver_id)((select group_id from groups where group_name='"+name+"')(select receiver_id from receivers where email = '"+email+"'))";
            string query = "Insert INTO join_group_receiver(group_id, receiver_id) values(" + group_id + "," + receiver_id + ")";
            con.Insert(query);
        }
        public List<ReceiverGroup> getReceiverGroups() {
            string query = "Select * from groups";
            List<List <string> > l = con.Select(query);
            List<ReceiverGroup> groupList = new List<ReceiverGroup>();
            for (int i = 0; i < l.Count; i++)
            {
                ReceiverGroup nextGroup = new ReceiverGroup(Convert.ToInt32(l[i][0]), l[i][1], l[i][2]);
                groupList.Add(nextGroup);
            }
            return groupList;
        }
        public void Update(string query) {
            con.Update(query);
        }
        public List<Receiver> GetReceiversOfGroup(int group_id) 
        {
            List<Receiver> receiversOfGroup = new List<Receiver>();
            string query = "SELECT receivers.receiver_id, first_name, last_name, email, role FROM receivers JOIN join_group_receiver ON	receivers.receiver_id=join_group_receiver.receiver_id JOIN groups ON groups.group_id=join_group_receiver.group_id where groups.group_id = " + group_id;
            List<List<string>> l = Database.con.Select(query);

            for (int i = 0; i < l.Count; i++)
            {
                receiversOfGroup.Add( new Receiver(Convert.ToInt32(l[i][0]),l[i][1],l[i][2],l[i][3],l[i][4]));
            }

            return receiversOfGroup;
        }
        
    }
}
