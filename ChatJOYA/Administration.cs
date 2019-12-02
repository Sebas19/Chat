using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatJOYA
{
    public partial class Administration : Form
    {
        Form1 form1;
        listusers listusersForm;
        public Administration(Form1 nform)
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(chatroom_FormClosing);
            form1 = nform;
            form1.Hide();
            listusersForm = new listusers(this);
        }

        private void listusers_Click(object sender, EventArgs e)
        {
            listusersForm.Show();
        }

        private void Administration_Load(object sender, EventArgs e)
        {

        }
        private void chatroom_FormClosing(object sender, FormClosingEventArgs e)
        {
            //stops for from closing
            e.Cancel = true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
