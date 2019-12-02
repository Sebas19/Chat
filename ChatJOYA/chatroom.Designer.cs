namespace ChatJOYA
{
    partial class chatroom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.msgconect = new System.Windows.Forms.Label();
            this.buttonLeave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.writemessage = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.lbroomname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.msgconect);
            this.panel1.Controls.Add(this.buttonLeave);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.lbroomname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 691);
            this.panel1.TabIndex = 0;
            // 
            // msgconect
            // 
            this.msgconect.AutoSize = true;
            this.msgconect.Location = new System.Drawing.Point(37, 655);
            this.msgconect.Name = "msgconect";
            this.msgconect.Size = new System.Drawing.Size(0, 20);
            this.msgconect.TabIndex = 4;
            // 
            // buttonLeave
            // 
            this.buttonLeave.Location = new System.Drawing.Point(583, 12);
            this.buttonLeave.Name = "buttonLeave";
            this.buttonLeave.Size = new System.Drawing.Size(174, 34);
            this.buttonLeave.TabIndex = 3;
            this.buttonLeave.Text = "LEAVE ROOM";
            this.buttonLeave.UseVisualStyleBackColor = true;
            this.buttonLeave.Click += new System.EventHandler(this.buttonLeave_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.writemessage, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonSend, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(34, 52);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1027, 600);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(767, 553);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // writemessage
            // 
            this.writemessage.Location = new System.Drawing.Point(3, 563);
            this.writemessage.Name = "writemessage";
            this.writemessage.Size = new System.Drawing.Size(767, 26);
            this.writemessage.TabIndex = 1;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(776, 563);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(248, 34);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(776, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 554);
            this.panel2.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 26);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(242, 527);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(58, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connected Users:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(239, 29);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(0, 20);
            this.name.TabIndex = 1;
            this.name.Visible = false;
            // 
            // lbroomname
            // 
            this.lbroomname.AutoSize = true;
            this.lbroomname.Location = new System.Drawing.Point(76, 29);
            this.lbroomname.Name = "lbroomname";
            this.lbroomname.Size = new System.Drawing.Size(106, 20);
            this.lbroomname.TabIndex = 0;
            this.lbroomname.Text = "Room Name: ";
            // 
            // chatroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 691);
            this.Controls.Add(this.panel1);
            this.Name = "chatroom";
            this.Text = "chatroom";
            this.Load += new System.EventHandler(this.chatroom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLeave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox writemessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label lbroomname;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label msgconect;
    }
}