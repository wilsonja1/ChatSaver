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
    public partial class Form1 : Form
    {
        Model db;

        public Form1()
        {
            db = new Model();

            InitializeComponent();
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
