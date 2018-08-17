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
    public partial class Form4 : Form
    {
        Model db;

        public Form4()
        {
            db = new Model();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            dataGridView1.Rows.Clear();
            IQueryable<Chat> z;
            z = db.Chat.Where(y => y.Name == x);
            foreach (var i in z)
            {
                dataGridView1.Rows.Add(i.Name, i.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string x = textBox2.Text;
            textBox2.Text = "";
            dataGridView1.Rows.Clear();


            IQueryable<Chat> z = db.Chat.Where(y => y.Message.Contains(x));
            label4.Text = z.Count().ToString();
            label6.Text = x;

            foreach (var i in z)
            {
                dataGridView1.Rows.Add(i.Name, i.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = (int) numericUpDown1.Value;
            IQueryable<Chat> z = db.Chat.Take(num);
            dataGridView1.Rows.Clear();

            foreach (var i in z)
            {
                dataGridView1.Rows.Add(i.Name, i.Message);
            }
        }
    }
}
