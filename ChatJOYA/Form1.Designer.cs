namespace ChatJOYA
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ingresar = new System.Windows.Forms.Button();
            this.lbmesExist = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Room = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Login = new System.Windows.Forms.Button();
            this.bbtCreateRoom = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(379, 267);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Nick Name";
            // 
            // Ingresar
            // 
            this.Ingresar.Location = new System.Drawing.Point(483, 299);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(101, 49);
            this.Ingresar.TabIndex = 2;
            this.Ingresar.Text = "Ingresar";
            this.Ingresar.UseVisualStyleBackColor = true;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // lbmesExist
            // 
            this.lbmesExist.AutoSize = true;
            this.lbmesExist.Location = new System.Drawing.Point(495, 367);
            this.lbmesExist.Name = "lbmesExist";
            this.lbmesExist.Size = new System.Drawing.Size(0, 20);
            this.lbmesExist.TabIndex = 3;
            this.lbmesExist.Visible = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Room,
            this.UserCount});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(788, 606);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 38;
            // 
            // Room
            // 
            this.Room.Text = "Room";
            this.Room.Width = 305;
            // 
            // UserCount
            // 
            this.UserCount.Text = "UserCount";
            this.UserCount.Width = 441;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(889, 123);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(147, 52);
            this.Login.TabIndex = 5;
            this.Login.Text = "Login in room";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Visible = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // bbtCreateRoom
            // 
            this.bbtCreateRoom.Location = new System.Drawing.Point(889, 288);
            this.bbtCreateRoom.Name = "bbtCreateRoom";
            this.bbtCreateRoom.Size = new System.Drawing.Size(147, 60);
            this.bbtCreateRoom.TabIndex = 6;
            this.bbtCreateRoom.Text = "Create Room";
            this.bbtCreateRoom.UseVisualStyleBackColor = true;
            this.bbtCreateRoom.Visible = false;
            this.bbtCreateRoom.Click += new System.EventHandler(this.bbtCreateRoom_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(889, 243);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 26);
            this.textBox2.TabIndex = 7;
            this.textBox2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(913, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Room Name";
            this.label2.Visible = false;
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(889, 427);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(162, 43);
            this.logout.TabIndex = 9;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Visible = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // admin
            // 
            this.admin.Location = new System.Drawing.Point(889, 565);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(171, 53);
            this.admin.TabIndex = 10;
            this.admin.Text = "Administration";
            this.admin.UseVisualStyleBackColor = true;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 643);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.bbtCreateRoom);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbmesExist);
            this.Controls.Add(this.Ingresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Lobby";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ingresar;
        private System.Windows.Forms.Label lbmesExist;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Room;
        private System.Windows.Forms.ColumnHeader UserCount;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button bbtCreateRoom;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button admin;
    }
}

