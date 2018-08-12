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

        public Form1()
        {
            db = new Model();
            user = db.User.First();

            InitializeComponent();

            NameLabel.Text = user.UserName;
            //StreamList.Columns.Add("Name", 100);
            //StreamList.Columns.Add("Game", 100);
            //StreamList.Columns.Add("Viewers", 100);

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
            webClient.QueryString.Add("limit", "5");
            string result = webClient.DownloadString("https://api.twitch.tv/kraken/streams");
            dynamic myjson = Newtonsoft.Json.JsonConvert.DeserializeObject(result);

            var x = myjson["streams"][0]["channel"]["name"];
            foreach (var i in myjson["streams"])
            {
                string name = i["channel"]["name"];
                string game = i["game"];
                string viewer = i["viewers"];
                var item1 = new ListViewItem(new[] { name, game, viewer });
                StreamList.Items.Add(item1);
            }
        }
    }
}
