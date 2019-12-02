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
    public partial class DetailsRoombyUser : Form
    {
        DetailsForm detalform;
        public DetailsRoombyUser(DetailsForm ndetail)
        {
            InitializeComponent();
            detalform = ndetail;
            detalform.Hide();
            this.FormClosing += new FormClosingEventHandler(chatroom_FormClosing);
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void listMessage(int idroom , int iduser){
            ListViewItem itm;
            using (ChatContext db = new ChatContext())
            {
                var query = (from m in db.Messages                             
                             where m.idUser == iduser && m.idRoom == idroom
                             select m.text);

                foreach (var r in query)
                {

                    itm = new ListViewItem(r);
                    listView1.Items.Add(itm);
                    //itm = new ListViewItem(r.name);
                    //listView1.Items.Add(itm);
                }
            }
        }

        private void DetailsRoombyUser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
