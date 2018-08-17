using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatSaver
{
    public class Chat
    {
        public int ChatId { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }
        public string Channel { get; set; }

        public Chat(string name, string message,DateTime time,string channel)
        {
            Name = name;
            Message = message;
            Time = time;
            Channel = channel;
        }

        public Chat() : base()
        {

        }
    }
}
