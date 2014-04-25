using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD
{
   public class Receiver
    {
        public string FullName { get; set; }
        public string Field { get; set; }
        public string Email { get; set; }
        public List<Sample> ReceivedSamples { get; set; }
        public List<ReceiverRole> Roles { get; set; }

    }
}
