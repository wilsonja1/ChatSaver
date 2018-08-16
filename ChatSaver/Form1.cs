﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatSaver
{
    public partial class Form1 : Form
    {
        Model db;
        User user;
        List<Connection> irc;
        List<PingSender> ping;

        public Form1()
        {
            db = new Model();
            user = db.User.First();

            InitializeComponent();

            NameLabel.Text = user.UserName;
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            using (Form2 f2 = new Form2())
            {
                f2.ShowDialog();

            }
        }

        private void ShowStream_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.QueryString.Add("oauth_token", user.OauthToken);
            webClient.QueryString.Add("limit", "10");
            string result = webClient.DownloadString("https://api.twitch.tv/kraken/streams");
            dynamic myjson = Newtonsoft.Json.JsonConvert.DeserializeObject(result);

            var x = myjson["streams"][0]["channel"]["name"];
            foreach (var i in myjson["streams"])
            {
                string name = i["channel"]["name"];
                string game = i["game"];
                string viewer = i["viewers"];
                ListViewItem item1 = new ListViewItem(name);
                item1.SubItems.Add(game);
                item1.SubItems.Add(viewer);
                StreamList.Items.Add(item1);
            }
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            irc = new List<Connection>();
            if (!string.IsNullOrWhiteSpace(ChannelName.Text))
            {
                irc.Add(new Connection("irc.twitch.tv", 6667, user.UserName, user.OauthToken, ChannelName.Text));
                ChannelName.Clear();
            }
            else
            {
                foreach (ListViewItem i in StreamList.Items)
                {
                    if (i.Checked)
                    {
                        irc.Add(new Connection("irc.twitch.tv", 6667, user.UserName, user.OauthToken, i.SubItems[0].Text));
                    }
                }
            }
            //This will be problem multiply adding them.
            foreach (Connection x in irc)
            {
                ConnectedStream.Rows.Add(x.channel, true, false, "Chat");
            }
            StartPing();
        }

        private void StartPing()
        {
            foreach(Connection x in irc)
            {
                ping.Add(new PingSender(x));
                ping.Last().Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var firstSelectedItem = StreamList.SelectedItems[0];
            MessageBox.Show(firstSelectedItem.Index.ToString());

        }

        private void ConnectedStream_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                Form3 f3 = new Form3(irc[e.ColumnIndex-2]);
                f3.ShowDialog();
            }
        }
    }
}
