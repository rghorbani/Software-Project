using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD
{
   public class Sample
    {
        public DateTime SentTime { get; set; }
        public List<string> PS { get; set; }
        public List <string> AttachedFileAddr{ get; set; }
        public Template RelatedTemplate { get; set; }
        public Receiver SampleReceiver { get; set; }
        public EducationAssistant SampleSender { get; set; }
        public Task SampleTask { get; set; }

    }
}
