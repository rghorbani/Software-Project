using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD
{
    public class EducationAssistant
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public DateTime LastAccess { get; set; }
        public DateTime FirstAccess { get; set; }
        public List<Template> CreatedTemplates { get; set; }
        public List<Sample> SentLetters { get; set; }
        public EducationAssistant() { 
       
        }
        public EducationAssistant(string username, string password, string email, string fullname){
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.FullName = fullname;
        
        }
    }
}
