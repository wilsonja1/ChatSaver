﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            MessageBox.Show("here");
            InitializeComponent();

            label2.Text = irc.channel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("wassup");

                while (true)
                {
                    string msg = irc.ReadMessage();
                    textBox1.AppendText(Environment.NewLine + " >> " + msg);
                    System.Threading.Thread.Sleep(240);
                    Application.DoEvents();
                }
        }
    }
}
