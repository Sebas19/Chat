namespace ChatJOYA
{
    partial class Administration
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
            this.listusers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listusers
            // 
            this.listusers.Location = new System.Drawing.Point(93, 45);
            this.listusers.Name = "listusers";
            this.listusers.Size = new System.Drawing.Size(142, 33);
            this.listusers.TabIndex = 0;
            this.listusers.Text = "List Users";
            this.listusers.UseVisualStyleBackColor = true;
            this.listusers.Click += new System.EventHandler(this.listusers_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 380);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listusers);
            this.Name = "Administration";
            this.Text = "Administration";
            this.Load += new System.EventHandler(this.Administration_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listusers;
        private System.Windows.Forms.Button button1;
    }
}