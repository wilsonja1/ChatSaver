using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChatSaver
{
    public class Connection
    {
        public string userName;
        public string channel;

        public PingSender ping;
        public ChatSave save;

        private TcpClient _tcpClient;
        private StreamReader _inputStream;
        private StreamReader _inputStream2;

        private MemoryStream _copyStream;

        private StreamWriter _outputStream;
        private StreamWriter _outputStream2;

        public Connection(string ip, int port, string userName, string password, string channel)
        {
            try
            {
                this.userName = userName;
                this.channel = channel;

                _tcpClient = new TcpClient(ip, port);
                _inputStream = new StreamReader(_tcpClient.GetStream());
                _outputStream = new StreamWriter(_tcpClient.GetStream());

                _copyStream = new MemoryStream();
                _inputStream2 = new StreamReader(_copyStream);
                _outputStream2 = new StreamWriter(_copyStream);

                password = "oauth:" + password;

                // Try to join the room
                _outputStream.WriteLine("PASS " + password + "\r\n");
                _outputStream.WriteLine("NICK " + userName + "\r\n");
                //_outputStream.WriteLine("USER " + userName + " 8 * :" + userName);
                _outputStream.WriteLine("JOIN #" + channel + "\r\n");
                _outputStream.Flush();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            ping = new PingSender(this);
            save = new ChatSave(this);
        }

        public void SendIrcMessage(string message)
        {
            try
            {
                _outputStream.WriteLine(message);
                _outputStream.Flush();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SendPublicChatMessage(string message)
        {
            try
            {
                SendIrcMessage(":" + userName + "!" + userName + "@" + userName +
                ".tmi.twitch.tv PRIVMSG #" + channel + " :" + message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public string ReadMessage()
        {
            try
            {
                string message = _inputStream.ReadLine();
                _outputStream2.WriteLine(message);
                _outputStream2.Flush();
                return message;
            }
            catch (Exception ex)
            {
                return "Error receiving message: " + ex.Message;
            }
        }

        public string ReadMessage2()
        {
            try
            {
                _copyStream.Position = 0;
                string message = _inputStream2.ReadLine();
                return message;
            }
            catch (Exception ex)
            {
                return "Error receiving message: " + ex.Message;
            }
        }
    }
}
