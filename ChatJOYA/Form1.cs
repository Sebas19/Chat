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
    public partial class Form1 : Form
    {
        chatroom chat_room;
        Administration adminform;
        string nick;
        public Form1()
        {
            InitializeComponent();
            chat_room = new chatroom(this);
            adminform = new Administration(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.MaxLength = 40;
            //textBox1.ReadOnly = true;
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            nick = textBox1.Text;
            using(var db = new ChatContext())
            {
                var result = (from row in db.Users
                              where row.nick == nick && row.connec == true
                              select row).ToList();

                if (result.Count() != 0)
                {
                    lbmesExist.Visible = true;
                    lbmesExist.Text = "User Name is Already Exist";

                }
                else
                {
                    textBox1.Visible = false;
                    label1.Visible = false;
                    lbmesExist.Visible = true;
                    Ingresar.Visible = false;
                    Ingresar.Enabled = false;
                    User newuser = new User { nick = nick , connec=true };
                    db.Users.Add(newuser);
                    db.SaveChanges();
                    lbmesExist.Text = "Well Come";
                    lbmesExist.Visible = false;

                    ListRooms();
                    //lobby_room.Show();
                    
                }
            }

        }


        public void addNewRoom(string name)
        {
            if (name.Length != 0)
            {
                int i = 0;
                using (ChatContext db = new ChatContext())
                {
                    Room newRoom = new Room { name = name, users = 0 };
                    db.Rooms.Add(newRoom);
                    db.SaveChanges();
                    var result = (from b in db.Rooms
                                  where b.name == name
                                  orderby b.id descending
                                  select b.id).ToList();

                    i = result.First();
                    logInToRoom(i);
                }
                /*using (ChatContext db = new ChatContext())
                {
                    var result = (from b in db.Rooms
                                 where b.name == name
                                 orderby b.id descending
                                 select b.id).ToList();

                    i = result.First();
                    logInToRoom(i);
                }*/
            
            }
            else
            {
                textBox2.Text = "Invalid Name";
            }
            
        }
        public void logInToRoom(int idRoom)
        {

            string roomname = "";
            using (var db = new ChatContext())
            {
                var result = (from room in db.Rooms
                              where room.id == idRoom
                              select room).ToList();
                //Room loginroom = new Room { users = result[0].users++ };
                foreach (var r in result) { r.users++; roomname = r.name; }
                db.SaveChanges();
                chat_room.Show();
                chat_room.senduser(nick ,roomname , idRoom);
            }
            //label2.Text = this.listView1.SelectedItems[0].Tag.ToString();
        }

        public string ListRooms()
        {
            listView1.Visible = true;
            Login.Visible = true;
            bbtCreateRoom.Visible = true;
            textBox2.Visible = true;
            label2.Visible = true;
            logout.Visible = true;
            //listView1.Columns.Add("Rooms");
            //listView1.Columns.Add("");
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            string[] arr = new string[4];
            ListViewItem itm;
            using (var db = new ChatContext())
            {
                var query = from b in db.Rooms
                            where b.users > 0
                            orderby b.name
                            select b;
                foreach (var r in query)
                {
                    arr[0] = r.id.ToString();
                    arr[1] = r.name;
                    arr[2] = r.users.ToString();
                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);
                    //itm = new ListViewItem(r.name);
                    //listView1.Items.Add(itm);
                }
                
            }
            return "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Rooms_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
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
            logInToRoom(i);
            //Login.Text = listView1.SelectedItems[0].SubItems[0].Text;
        }

        private void bbtCreateRoom_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            addNewRoom(name);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            using(ChatContext db = new ChatContext())
            {
                var result = (from us in db.Users
                              where us.nick==nick && us.connec==true
                              select us);
                foreach (var r in result) r.connec = false;
                db.SaveChanges();
            }
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void admin_Click(object sender, EventArgs e)
        {
            adminform.Show();

        }
    }
}
