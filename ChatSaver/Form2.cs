using System;
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
    public partial class Form2 : Form
    {
        Model db;
        User start;
        public Form2()
        {
            db = new Model();
            start = db.User.First();

            InitializeComponent();

            textBox1.Text = start.UserName;
            textBox2.Text = start.OauthToken;
            textBox3.Text = start.UserId.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string token = textBox2.Text;
            int id = Convert.ToInt16(textBox3.Text);

            start.UserName = username;
            start.OauthToken = token;

            db.SaveChanges();
            this.Close();
        }
    }
}
