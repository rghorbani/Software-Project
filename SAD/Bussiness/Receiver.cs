using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD
{
   public class Receiver
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public int ID { get; set; }
//        public List<Sample> ReceivedSamples { get; set; }
//        public List<ReceiverRole> Roles { get; set; }

        public Receiver(string fname, string lname, string role, string email)
        {
            this.FName = fname;
            this.LName = lname;
            this.Role = role;
            this.Email = email;
        }
        public Receiver(int id, string fname, string lname, string email, string role)
        {
            this.FName = fname;
            this.LName = lname;
            this.Role = role;
            this.Email = email;
            this.ID = id;
        }

    }
}
