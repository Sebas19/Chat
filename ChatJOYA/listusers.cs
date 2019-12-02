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
    public partial class listusers : Form
    {
        Administration admin;
        DetailsForm detailsform;
        public listusers(Administration nAdmin)
        {
            InitializeComponent();
            admin = nAdmin;
            admin.Hide();
            detailsform = new DetailsForm(this);
            this.FormClosing += new FormClosingEventHandler(chatroom_FormClosing);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listusers_Load(object sender, EventArgs e)
        {
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            string[] arr = new string[4];
            ListViewItem itm;
            using (ChatContext db = new ChatContext())
            {
                var query = from u in db.Users
                            select u;

                foreach (var r in query)
                {
                    arr[0] = r.id.ToString();
                    arr[1] = r.nick;
                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);
                    //itm = new ListViewItem(r.name);
                    //listView1.Items.Add(itm);
                }
            }
        }

        private void Details_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                i = System.Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
            }
            catch (FormatException)
            {

            }
            catch (OverflowException)
            {

            }
            DetailList(i);
        }

        public void DetailList(int id)
        {
            detailsform.Show();
            detailsform.detail(id);
        }
        private void chatroom_FormClosing(object sender, FormClosingEventArgs e)
        {
            //stops for from closing
            e.Cancel = true;
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
