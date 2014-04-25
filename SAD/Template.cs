using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SAD
{
    public class Template
    {
        public string Title { get; set; }
        public string Text { get; set; }
        //      public List<DateTime> SentTime  { get; set; }
        public DateTime SentTime { get; set; }
        public bool HasReminder { get; set; }
        public string Priority { get; set; }
        public bool IsAutomatic { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsConfirmed { get; set; }
        public bool CreateTask { get; set; }
        public EducationAssistant Creator { get; set; }
        //        public List<Receiver> TemplateReceiver { get; set; }
        public List<string> TemplateReceiver { get; set; }
        public Template(string title, string text, string receivers, bool createTask, DateTime senttime, bool isAutomatic, bool hasReminder, string priority)
        {
            this.SentTime = senttime;
            this.Title = title;
            this.Text = text;
            string[] rcv = Regex.Split(receivers, "\r\n");
            this.TemplateReceiver = new List<string>(rcv);
            this.CreateTask = createTask;
            this.HasReminder = hasReminder;
            this.IsAutomatic = isAutomatic;
            this.Priority = priority;

        }
    }
}