using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD
{
    public class EducationManager
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public DateTime StartTime { get; set; }
        public List<Template> ConfirmedTemplates { get; set; }


    }
}
