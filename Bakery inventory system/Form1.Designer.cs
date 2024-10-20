namespace Bakery_inventory_system
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            username = new TextBox();
            password = new TextBox();
            login = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(407, -14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26F, FontStyle.Bold);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(441, 128);
            label1.Name = "label1";
            label1.Size = new Size(130, 51);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(307, 197);
            label2.Name = "label2";
            label2.Size = new Size(125, 26);
            label2.TabIndex = 2;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(307, 304);
            label3.Name = "label3";
            label3.Size = new Size(101, 26);
            label3.TabIndex = 3;
            label3.Text = "Pasword";
            // 
            // username
            // 
            username.BorderStyle = BorderStyle.FixedSingle;
            username.Location = new Point(307, 246);
            username.Name = "username";
            username.Size = new Size(381, 27);
            username.TabIndex = 4;
            // 
            // password
            // 
            password.BorderStyle = BorderStyle.FixedSingle;
            password.Location = new Point(307, 346);
            password.Name = "password";
            password.Size = new Size(381, 27);
            password.TabIndex = 5;
            // 
            // login
            // 
            login.BackColor = Color.DarkCyan;
            login.FlatAppearance.BorderColor = Color.DarkCyan;
            login.FlatAppearance.BorderSize = 0;
            login.FlatStyle = FlatStyle.Flat;
            login.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            login.ForeColor = Color.Snow;
            login.Location = new Point(432, 408);
            login.Name = "login";
            login.Size = new Size(111, 48);
            login.TabIndex = 6;
            login.Text = "Login";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 580);
            panel1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 580);
            Controls.Add(panel1);
            Controls.Add(login);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Bakery";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox u;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox username;
        private TextBox password;
        private Button login;
        private Panel panel1;
    }
}
