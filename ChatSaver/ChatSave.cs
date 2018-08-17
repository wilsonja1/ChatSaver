using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatSaver
{
    class ChatSave
    {
        private Connection _irc;
        private Thread Saver;
        private Model db;

        public ChatSave(Connection irc)
        {
            _irc = irc;
            Saver = new Thread(new ThreadStart(this.Run));
        }

        public void Start()
        {
            Saver.IsBackground = true;
            Saver.Start();
        }

        public void Run()
        {
            db = new Model();
            while (true)
            {
                string x = _irc.ReadMessage();
                string name = "";
                string channel = "";
                string message = "";

                if (!x.Contains("battlejacklegend"))
                {
                    try { 
                        name = x.Split(':')[1].Split('!')[0];
                        channel = _irc.channel;
                        message = x.Split(':')[2];
                    }
                    catch
                    {

                    }

                    Chat y = new Chat(name, message, DateTime.Now, channel);
        
                    db.Chat.Add(y);
                    db.SaveChangesAsync();
                }

            }
        }
    }
}
