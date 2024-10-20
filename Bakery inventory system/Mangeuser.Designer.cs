namespace Bakery_inventory_system
{
    partial class Mangeuser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mangeuser));
            label6 = new Label();
            Report = new Label();
            Changepassword = new Label();
            label1 = new Label();
            Stock = new Label();
            Product = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label7 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label6.ForeColor = Color.Red;
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(76, 499);
            label6.Name = "label6";
            label6.Size = new Size(96, 25);
            label6.TabIndex = 13;
            label6.Text = "Log Out";
            label6.Click += label6_Click;
            // 
            // Report
            // 
            Report.AutoSize = true;
            Report.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            Report.ForeColor = Color.White;
            Report.ImeMode = ImeMode.NoControl;
            Report.Location = new Point(87, 332);
            Report.Name = "Report";
            Report.Size = new Size(83, 25);
            Report.TabIndex = 12;
            Report.Text = "Report";
            Report.Click += Report_Click;
            // 
            // Changepassword
            // 
            Changepassword.AutoSize = true;
            Changepassword.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            Changepassword.ForeColor = Color.White;
            Changepassword.ImeMode = ImeMode.NoControl;
            Changepassword.Location = new Point(32, 441);
            Changepassword.Name = "Changepassword";
            Changepassword.Size = new Size(193, 25);
            Changepassword.TabIndex = 11;
            Changepassword.Text = "Change Password";
            Changepassword.Click += Changepassword_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(58, 384);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 10;
            label1.Text = "Manage User";
            label1.Click += label1_Click;
            // 
            // Stock
            // 
            Stock.AutoSize = true;
            Stock.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            Stock.ForeColor = Color.White;
            Stock.ImeMode = ImeMode.NoControl;
            Stock.Location = new Point(93, 277);
            Stock.Name = "Stock";
            Stock.Size = new Size(68, 25);
            Stock.TabIndex = 9;
            Stock.Text = "Stock";
            Stock.Click += Stock_Click;
            // 
            // Product
            // 
            Product.AutoSize = true;
            Product.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            Product.ForeColor = Color.White;
            Product.ImeMode = ImeMode.NoControl;
            Product.Location = new Point(81, 220);
            Product.Name = "Product";
            Product.Size = new Size(94, 25);
            Product.TabIndex = 8;
            Product.Text = "Product";
            Product.Click += Product_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(0, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(294, 163);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(Product);
            panel1.Controls.Add(Report);
            panel1.Controls.Add(Stock);
            panel1.Controls.Add(Changepassword);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(271, 664);
            panel1.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 26F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(358, 9);
            label7.Name = "label7";
            label7.Size = new Size(273, 51);
            label7.TabIndex = 7;
            label7.Text = "Manage User";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkCyan;
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(271, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(954, 76);
            panel2.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(271, 76);
            panel3.Name = "panel3";
            panel3.Size = new Size(954, 588);
            panel3.TabIndex = 16;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(440, 250);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(274, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(440, 175);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(274, 27);
            textBox2.TabIndex = 6;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkCyan;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(545, 340);
            button2.Name = "button2";
            button2.Size = new Size(169, 50);
            button2.TabIndex = 5;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(223, 340);
            button1.Name = "button1";
            button1.Size = new Size(169, 50);
            button1.TabIndex = 4;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(440, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 27);
            textBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(223, 250);
            label4.Name = "label4";
            label4.Size = new Size(90, 23);
            label4.TabIndex = 2;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(223, 175);
            label3.Name = "label3";
            label3.Size = new Size(59, 23);
            label3.TabIndex = 1;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(223, 91);
            label2.Name = "label2";
            label2.Size = new Size(31, 23);
            label2.TabIndex = 0;
            label2.Text = "ID";
            // 
            // Mangeuser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 664);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Mangeuser";
            Text = "Manage User";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label6;
        private Label Report;
        private Label Changepassword;
        private Label label1;
        private Label Stock;
        private Label Product;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label7;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}