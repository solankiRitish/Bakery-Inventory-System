namespace Bakery_inventory_system
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            panel1 = new Panel();
            label6 = new Label();
            Report = new Label();
            label1 = new Label();
            MangeUser = new Label();
            Stock = new Label();
            Product = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ID = new TextBox();
            UserName = new TextBox();
            label4 = new Label();
            NewPassword = new TextBox();
            label5 = new Label();
            ReEnterPassword = new TextBox();
            label8 = new Label();
            change = new Button();
            label2 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(Report);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(MangeUser);
            panel1.Controls.Add(Stock);
            panel1.Controls.Add(Product);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(271, 517);
            panel1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(75, 470);
            label6.Name = "label6";
            label6.Size = new Size(96, 25);
            label6.TabIndex = 6;
            label6.Text = "Log Out";
            label6.Click += label6_Click_1;
            // 
            // Report
            // 
            Report.AutoSize = true;
            Report.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Report.ForeColor = Color.White;
            Report.Location = new Point(88, 298);
            Report.Name = "Report";
            Report.Size = new Size(83, 25);
            Report.TabIndex = 5;
            Report.Text = "Report";
            Report.Click += Report_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(33, 407);
            label1.Name = "label1";
            label1.Size = new Size(193, 25);
            label1.TabIndex = 4;
            label1.Text = "Change Password";
            label1.Click += label1_Click;
            // 
            // MangeUser
            // 
            MangeUser.AutoSize = true;
            MangeUser.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MangeUser.ForeColor = Color.White;
            MangeUser.Location = new Point(59, 350);
            MangeUser.Name = "MangeUser";
            MangeUser.Size = new Size(148, 25);
            MangeUser.TabIndex = 3;
            MangeUser.Text = "Manage User";
            MangeUser.Click += MangeUser_Click;
            // 
            // Stock
            // 
            Stock.AutoSize = true;
            Stock.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Stock.ForeColor = Color.White;
            Stock.Location = new Point(94, 243);
            Stock.Name = "Stock";
            Stock.Size = new Size(68, 25);
            Stock.TabIndex = 2;
            Stock.Text = "Stock";
            Stock.Click += Stock_Click;
            // 
            // Product
            // 
            Product.AutoSize = true;
            Product.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Product.ForeColor = Color.White;
            Product.Location = new Point(82, 186);
            Product.Name = "Product";
            Product.Size = new Size(94, 25);
            Product.TabIndex = 1;
            Product.Text = "Product";
            Product.Click += Product_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(271, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(299, 102);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 4;
            label3.Text = "Emp ID";
            // 
            // ID
            // 
            ID.BorderStyle = BorderStyle.FixedSingle;
            ID.Location = new Point(299, 139);
            ID.Name = "ID";
            ID.Size = new Size(590, 27);
            ID.TabIndex = 6;
            // 
            // UserName
            // 
            UserName.BorderStyle = BorderStyle.FixedSingle;
            UserName.Location = new Point(299, 220);
            UserName.Name = "UserName";
            UserName.Size = new Size(590, 27);
            UserName.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(299, 183);
            label4.Name = "label4";
            label4.Size = new Size(124, 25);
            label4.TabIndex = 7;
            label4.Text = "User Name";
            // 
            // NewPassword
            // 
            NewPassword.BorderStyle = BorderStyle.FixedSingle;
            NewPassword.Location = new Point(299, 301);
            NewPassword.Name = "NewPassword";
            NewPassword.Size = new Size(590, 27);
            NewPassword.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(299, 264);
            label5.Name = "label5";
            label5.Size = new Size(160, 25);
            label5.TabIndex = 9;
            label5.Text = "New Password";
            // 
            // ReEnterPassword
            // 
            ReEnterPassword.BorderStyle = BorderStyle.FixedSingle;
            ReEnterPassword.Location = new Point(299, 384);
            ReEnterPassword.Name = "ReEnterPassword";
            ReEnterPassword.Size = new Size(590, 27);
            ReEnterPassword.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkCyan;
            label8.Location = new Point(299, 347);
            label8.Name = "label8";
            label8.Size = new Size(211, 25);
            label8.TabIndex = 11;
            label8.Text = "ReEnter Passworde";
            // 
            // change
            // 
            change.BackColor = Color.DarkCyan;
            change.FlatStyle = FlatStyle.Flat;
            change.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            change.ForeColor = Color.White;
            change.Location = new Point(518, 426);
            change.Name = "change";
            change.Size = new Size(200, 66);
            change.TabIndex = 13;
            change.Text = "Change";
            change.UseVisualStyleBackColor = false;
            change.Click += change_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(181, 9);
            label2.Name = "label2";
            label2.Size = new Size(353, 51);
            label2.TabIndex = 7;
            label2.Text = "Change Password";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkCyan;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(271, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(728, 76);
            panel2.TabIndex = 16;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 517);
            Controls.Add(panel2);
            Controls.Add(change);
            Controls.Add(ReEnterPassword);
            Controls.Add(label8);
            Controls.Add(NewPassword);
            Controls.Add(label5);
            Controls.Add(UserName);
            Controls.Add(label4);
            Controls.Add(ID);
            Controls.Add(label3);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ChangePassword";
            Text = "ChangePassword";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label Report;
        private Label label1;
        private Label MangeUser;
        private Label Stock;
        private Label Product;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox ID;
        private TextBox UserName;
        private Label label4;
        private TextBox NewPassword;
        private Label label5;
        private TextBox ReEnterPassword;
        private Label label8;
        private Button change;
        private Label label2;
        private Panel panel2;
    }
}