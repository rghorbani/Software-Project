using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD
{
    public class ReceiverGroup
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public List<Receiver> recievers { get; set; }

        public ReceiverGroup(int Id, string t, string d)
        {
            this.id = Id;
            this.title = t;
            this.description = d;
        }
    }
}
