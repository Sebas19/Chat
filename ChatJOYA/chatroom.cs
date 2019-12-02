using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ChatJOYA
{

    public partial class chatroom : Form
    {
        Form1 form;
        string nick;
        int id;
        string room; TcpClient clientSocket = new TcpClient();
        NetworkStream serverStream;
        public chatroom(Form1 nform1)
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(chatroom_FormClosing);
            form = nform1;
            form.Hide();
            //serversocket server = new serversocket();
            Thread thread1 = new Thread(serversocket.startserverroom);
            thread1.Start();
        }
        private void chatroom_FormClosing(object sender, FormClosingEventArgs e)
        {
            //stops for from closing
            e.Cancel = true;
            this.Hide();
        }

        public void senduser(string user, string roomname , int idroom)
        {
            nick = user;
            id = idroom;
            room = roomname;
            sendmessage("Connected user: " + nick);
            name.Text = roomname;
            chargeusers();
            //readmesage();
            //Thread thread2 = new Thread(readmesage);
            //thread2.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chatroom_Load(object sender, EventArgs e)
        {
            
            clientSocket.Connect("127.0.0.1", 8888);
            msgconect.Text = "Connected ...";
            
            //readmesage();
        }
        public void chargeusers()
        {
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            ListViewItem itm;
            using (var db = new ChatContext())
            {
                /*var query = (from m in db.Messages                            
                            join us in db.Users on m.idUser equals us.id
                            where m.idRoom == id
                            orderby us.nick
                            select us.nick);*/

               var query = from m in db.Messages
                            join us in db.Users on m.idUser equals us.id
                            where us.connec == true && m.idRoom == id
                            orderby us.nick
                            select us.nick;
                foreach (var r in query)
                {

                    itm = new ListViewItem(r);
                    listView1.Items.Add(itm);
                    //itm = new ListViewItem(r.name);
                    //listView1.Items.Add(itm);
                }
            }
        }
        public void sendmessage(string message)
        {
            serverStream = clientSocket.GetStream();
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(message);
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
            using(ChatContext db = new ChatContext())
            {
                int i = 0;
                var query = (from b in db.Users
                             where b.nick== nick && b.connec == true
                             select b.id).ToList();
                i = query.First();
                Message newmessage = new Message { idRoom = id,idUser=i,text=message};
                db.Messages.Add(newmessage);
                db.SaveChanges();
            }
            writemessage.Text = "";
            writemessage.Focus();
            return;
        }
        public void readmesage()
        {
            byte[] inStream = new byte[100250];
            serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
            string returndata = System.Text.Encoding.ASCII.GetString(inStream);
            FormatMessage(richTextBox1, returndata);
            richTextBox1.Text = returndata;
        }

        public static void FormatMessage(RichTextBox box, string msg)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = System.Drawing.SystemColors.AppWorkspace;
            box.AppendText(msg);
                
            box.SelectionColor = System.Drawing.SystemColors.Highlight;
           // box.AppendText(msg["User"].ToObject<string>() + ": ");
            box.SelectionColor = box.ForeColor;
           // box.AppendText(msg["Content"].ToObject<string>() + Environment.NewLine);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string msg = writemessage.Text;
            writemessage.Text = "";
            sendmessage(nick + ": " + msg);
            readmesage();
        }

        private void buttonLeave_Click(object sender, EventArgs e)
        {
            using (var db = new ChatContext())
            {
                var result = (from room in db.Rooms
                              where room.id == id
                              select room).ToList();
                //Room loginroom = new Room { users = result[0].users++ };
                foreach (var r in result) { r.users--; }
                db.SaveChanges();
            }
            this.Close();
        }
    }
    
}
