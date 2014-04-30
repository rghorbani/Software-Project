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

            string query;
            query = "Select * from users where username = '" + userName + "' and password = '" + password + "'";
            List<List <string> > l = con.Select(query);
            if (l.Count == 0)
                return false;
            else{
                current_user = l[0][0];    
                return true;
                
            }                        
        }

        // Template related Functions
        public List<Template> getTemplates() {
            
            string query;
            query = "Select * from templates";
            List<List <string> > l = con.Select(query);

            List<Template> temps = new List<Template>();
            for (int i = 0; i < l.Count; i++) {
                Template newTemplate = new Template(Convert.ToInt32(l[i][0]), l[i][3], l[i][4], l[i][6] == "True", Convert.ToDateTime(l[i][5]), l[i][8] == "True", Convert.ToInt32(l[i][7]));
                temps.Add(newTemplate);
            }
            return temps;
        }
        public void AddTemplate(Template template,List<ReceiverGroup> groups, List<Receiver> receivers) {
            templates.Add(template);
            string query;
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
            string query = "Insert into receivers (first_name , last_name, email, role) VALUES ('" + receiver.FName + "', '" + receiver.LName + "','" + receiver.Email + "','" + receiver.Role + "')";
            Database.con.Insert(query);
        }

        public void AddRecieverGroup(ReceiverGroup _group)
        {
            //groups.Add(_group);
            string query = "Insert into groups (group_name , description, root_group_id) VALUES ('" + _group.title + "', '" + _group.description + "', " + _group.root + ")";
            Database.con.Insert(query);
        }

        public List<Receiver> getReceivers() 
        {
            string query = "Select * from receivers";

            List<List<string>> l = Database.con.Select(query);
            List<Receiver> receiversOfGroup = new List<Receiver>();
            for (int i = 0; i < l.Count; i++) {
                receiversOfGroup.Add(new Receiver(Convert.ToInt32(l[i][0]), l[i][1], l[i][2], l[i][3], l[i][4]));
            }
            return receiversOfGroup;        
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
                ReceiverGroup nextGroup = new ReceiverGroup(Convert.ToInt32(l[i][0]), l[i][1], l[i][2], Convert.ToInt32(l[i][3]));
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
        public List<ReceiverGroup> getGroupsOfTemplate(int template_id)
        {
            string query = "SELECT  groups.group_id, group_name FROM groups JOIN template_group ON groups.group_id = template_group.group_id where template_group.template_id = " + template_id;
            List<List<string>> l = Database.con.Select(query);
            List<ReceiverGroup> groupsOfTemplate = new List<ReceiverGroup>();
            for (int i = 0; i < l.Count; i++)
                groupsOfTemplate.Add(new ReceiverGroup(Convert.ToInt32(l[i][0]),l[i][1],"", 0));
            return groupsOfTemplate;
        
        }
        public List<Receiver> getReceiversOfTemplate(int template_id)
        {
            string query = "SELECT  receivers.receiver_id, first_name, last_name, email, role FROM receivers JOIN template_receiver ON receivers.receiver_id = template_receiver.receiver_id where template_receiver.template_id = " + template_id;
            List<List<string>> l = Database.con.Select(query);
            List<Receiver> receiversOfTemplate = new List<Receiver>();
            for(int i=0; i<l.Count; i++)
                receiversOfTemplate.Add(new Receiver(Convert.ToInt32(l[i][0]), l[i][1], l[i][2], l[i][3], l[i][4]));
            return receiversOfTemplate;
        }
        public void removeReceiverOfGroup(int receiver_id, int group_id) {
            string query = "DELETE FROM join_group_receiver WHERE group_id = " + group_id + " and receiver_id = " + receiver_id;
            con.Delete(query);
        }
        public void AddGroupToTemplate(int group_id, int template_id)
        {
            string query = "Insert into template_group(template_id,group_id) VALUES(" + template_id + "," + group_id + ")";
            con.Insert(query);
        }
        public void AddReceiverToTemplate( int receiver_id, int template_id)
        {
            string query = "Insert into template_receiver(template_id,receiver_id) VALUES(" + template_id + "," + receiver_id + ")";
            con.Insert(query);        
        }
        public void removeReceiverOfTemplate(int receiver_id, int template_id) 
        {
            string query = "DELETE FROM template_receiver WHERE template_id = " + template_id + " and receiver_id = " + receiver_id;            
            con.Insert(query);
        }
        public void removeGroupOfTemplate(int group_id, int template_id)
        {
            string query = "DELETE FROM template_group WHERE template_id = " + template_id + " and group_id = " + group_id;
            con.Insert(query);
        }
        public void removeTemplateSentTimes(int template_id)
        {
            string query = "DELETE FROM template_sent_time WHERE template_id = " + template_id;
            con.Insert(query);        
        }
        public void AddSentTimesToTemplate(Template template)
        {
            int count = (template.PeriodType == 4) ? 12 : (template.PeriodType == 3) ? 6 : (template.PeriodType == 2) ? 3 : (template.PeriodType == 1) ? 1 : 0;
            if (count != 0)
            {
                for (int i = 0; i < (24 / count); i++)
                {
                    string query = "Insert into template_sent_time(template_id, sent_time) VALUES(" + template.id + ", '" + template.SentTime.AddMonths(count * (i + 1)).ToString("yyyy-MM-dd") + "')";
                    con.Insert(query);
                }
            }
            else
            {
                string query = "Insert into template_sent_time(template_id, sent_time) VALUES(" + template.id + ", '" + template.SentTime.ToString("yyyy-MM-dd") + "')";
                con.Insert(query);
            }        
        }
    }
}
