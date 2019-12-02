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
    public partial class DetailsForm : Form
    {
        listusers listusers;
        DetailsRoombyUser detailform;
        int idUser;
        public DetailsForm(listusers nlist)
        {
            InitializeComponent();
            listusers = nlist;
            listusers.Hide();
            detailform = new DetailsRoombyUser(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {

        }
        public void detail(int id)
        {
            idUser = id;
            ListViewItem itm;
            using (ChatContext db = new ChatContext())
            {
                var query = (from m in db.Messages
                             join r in db.Rooms on m.idRoom equals r.id
                             where m.idUser==id
                             select  r.name);

                foreach (var r in query)
                {
                    
                    itm = new ListViewItem(r);
                    listView1.Items.Add(itm);
                    //itm = new ListViewItem(r.name);
                    //listView1.Items.Add(itm);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
            detailform.Show();
            detailform.listMessage(i,idUser);
        }
    }
}
