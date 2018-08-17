using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatSaver
{
    public class PingSender
    {
        private Connection _irc;
        private Thread pingSender;
        public bool ThreadRun;


        // Empty constructor makes instance of Thread
        public PingSender(Connection irc)
        {
            _irc = irc;
            ThreadRun = true;
            pingSender = new Thread(new ThreadStart(this.Run));

        }

        // Starts the thread
        public void Start()
        {
            pingSender.IsBackground = true;
            pingSender.Start();
        }

        // Send PING to irc server every 5 minutes
        public void Run()
        {
            while (ThreadRun)
            {
                _irc.SendIrcMessage("PING irc.twitch.tv");
                Thread.Sleep(300000); // 5 minutes
            }
        }
    }
}
