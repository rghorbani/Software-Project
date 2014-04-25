using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD
{
    class Database
    {
        private static Database db = null;

        // Lists
        private List<EducationAssistant> edAssistants;
        private List<Template> templates;
        private Database() {
            edAssistants = new List<EducationAssistant>();
            templates = new List<Template>();

            addUser(new EducationAssistant("admin", "admin", "admin", "admin"));
        }

        public static Database getDatabase() {
            if(db == null) {
                db = new Database();
            }
            return db;
        }

        //User related Functions
        public void addUser(EducationAssistant user) {
            edAssistants.Add(user);
        }

        public int countOfUsers() {
            return edAssistants.Count;
        }

        public EducationAssistant IsRegistered(string userName, string password) {

            for (int i = 0; i < edAssistants.Count; i++)
            {
                if (edAssistants.ElementAt(i).Username.Equals(userName) && edAssistants.ElementAt(i).Password.Equals(password))
                {
                    return edAssistants.ElementAt(i);
                }
            }
            return null;
        }

        // Template related Functions
        public List<Template> getTemplates() {
            return templates;
        }
        public void AddTemplate(Template template) {
            templates.Add(template);
        }
    }
}
