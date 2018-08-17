using System;
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
        int pageindex;

        public Form1()
        {
            db = new Model();
            user = db.User.First();
            irc = new List<Connection>();
            pageindex = 0;

            InitializeComponent();

            NameLabel.Text = user.UserName;
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Closed += delegate
            {
                user = db.User.First();
                NameLabel.Text = user.UserName;
            };
            f2.Show();

        }

        private void ShowStream_Click(object sender, EventArgs e)
        {
            pageindex = 0;
        }

        public void UpdateStreamList()
        {
            WebClient webClient = new WebClient();
            webClient.QueryString.Add("oauth_token", user.OauthToken);
            webClient.QueryString.Add("limit", "15");
            webClient.QueryString.Add("offset", (pageindex).ToString());
            string result = webClient.DownloadString("https://api.twitch.tv/kraken/streams");
            dynamic myjson = Newtonsoft.Json.JsonConvert.DeserializeObject(result);

            StreamList.Items.Clear();
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
            if (!string.IsNullOrWhiteSpace(ChannelName.Text))
            {
                irc.Add(new Connection("irc.twitch.tv", 6667, user.UserName, user.OauthToken, ChannelName.Text));
                irc.Last().ping.Start();
                irc.Last().save.Start();
                ConnectedStream.Rows.Add(irc.Last().channel, "Chat", "Remove");
                ChannelName.Clear();
            }
            else
            {
                foreach (ListViewItem i in StreamList.Items)
                {
                    if (i.Checked)
                    {
                        irc.Add(new Connection("irc.twitch.tv", 6667, user.UserName, user.OauthToken, i.SubItems[0].Text));
                        irc.Last().ping.Start();
                        irc.Last().save.Start();
                        ConnectedStream.Rows.Add(irc.Last().channel, "Chat", "Remove");
                        i.Checked = false;
                    }
                }
            }
        }

        private void ConnectedStream_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.ColumnIndex == 1)
            {
                Form3 f3 = new Form3(irc[e.RowIndex]);
                f3.ShowDialog();
            }
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.ColumnIndex == 2)
            {
                irc[e.RowIndex].save.ThreadRun = false;
                irc[e.RowIndex].ping.ThreadRun = false;
                irc.RemoveAt(e.RowIndex);
                ConnectedStream.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void leftbutton_Click(object sender, EventArgs e)
        {
            if (pageindex >= 15)
            {
                pageindex -= 15;
                UpdateStreamList();
            }
        }

        private void rightbutton_Click(object sender, EventArgs e)
        {
            pageindex += 15;
            UpdateStreamList();
        }
    }
}
