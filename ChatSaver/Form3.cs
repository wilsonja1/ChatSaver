using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatSaver
{
    public partial class Form3 : Form
    {
        Connection irc;
        public Form3(Connection e)
        {
            irc = e;

            InitializeComponent();

            label2.Text = irc.channel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                while (true)
                {
                    string msg = irc.ReadMessage2();
                    if (!string.IsNullOrWhiteSpace(msg))
                    {
                        AppendTextBox(msg);
                    }
                    System.Threading.Thread.Sleep(240);
                }
            }).Start();
        }

        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            textBox1.AppendText(Environment.NewLine + " >> " + value);
            Application.DoEvents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            irc.SendIrcMessage(textBox2.Text);
            AppendTextBox(textBox2.Text);
            textBox2.Text = "";          
        }
    }
}
