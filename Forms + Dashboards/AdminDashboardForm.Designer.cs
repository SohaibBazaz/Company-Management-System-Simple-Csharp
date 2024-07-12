namespace Company_Management_System_final
{
    partial class AdminDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboardForm));
            panel3 = new Panel();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            registrationbtn = new Button();
            rolesbtn = new Button();
            homebtn = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            panel4 = new Panel();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            panel5 = new Panel();
            adminRegisteration1 = new adminRegisteration();
            adminHome1 = new adminHome();
            userManagement1 = new userManagement();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonShadow;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(registrationbtn);
            panel3.Controls.Add(rolesbtn);
            panel3.Controls.Add(homebtn);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 749);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Maroon;
            label2.Font = new Font("Segoe UI", 7F);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(200, 290);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 10;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDarkDark;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(0, 509);
            button2.Name = "button2";
            button2.Size = new Size(267, 59);
            button2.TabIndex = 9;
            button2.Text = "Logout";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(33, 34);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 132);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 8;
            label1.Click += label1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(94, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 78);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // registrationbtn
            // 
            registrationbtn.BackColor = SystemColors.ControlDark;
            registrationbtn.BackgroundImageLayout = ImageLayout.Stretch;
            registrationbtn.FlatAppearance.BorderSize = 0;
            registrationbtn.FlatStyle = FlatStyle.Flat;
            registrationbtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registrationbtn.ForeColor = SystemColors.ActiveCaptionText;
            registrationbtn.Location = new Point(0, 280);
            registrationbtn.Name = "registrationbtn";
            registrationbtn.Size = new Size(267, 59);
            registrationbtn.TabIndex = 6;
            registrationbtn.Text = "Registrations";
            registrationbtn.UseVisualStyleBackColor = false;
            registrationbtn.Click += registrationbtn_Click;
            // 
            // rolesbtn
            // 
            rolesbtn.BackColor = SystemColors.ControlDark;
            rolesbtn.BackgroundImageLayout = ImageLayout.Stretch;
            rolesbtn.FlatAppearance.BorderSize = 0;
            rolesbtn.FlatStyle = FlatStyle.Flat;
            rolesbtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rolesbtn.ForeColor = SystemColors.ActiveCaptionText;
            rolesbtn.Location = new Point(3, 345);
            rolesbtn.Name = "rolesbtn";
            rolesbtn.Size = new Size(270, 59);
            rolesbtn.TabIndex = 4;
            rolesbtn.Text = "User Management";
            rolesbtn.UseVisualStyleBackColor = false;
            rolesbtn.Click += rolesbtn_Click;
            // 
            // homebtn
            // 
            homebtn.BackColor = SystemColors.ControlDark;
            homebtn.BackgroundImageLayout = ImageLayout.Stretch;
            homebtn.FlatAppearance.BorderSize = 0;
            homebtn.FlatStyle = FlatStyle.Flat;
            homebtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homebtn.ForeColor = SystemColors.ActiveCaptionText;
            homebtn.Location = new Point(0, 215);
            homebtn.Name = "homebtn";
            homebtn.Size = new Size(270, 59);
            homebtn.TabIndex = 2;
            homebtn.Text = "Home";
            homebtn.UseVisualStyleBackColor = false;
            homebtn.Click += button4_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(245, 570);
            panel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 18);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Maroon;
            panel4.Location = new Point(314, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 18);
            panel4.TabIndex = 2;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // panel5
            // 
            panel5.Controls.Add(adminRegisteration1);
            panel5.Controls.Add(adminHome1);
            panel5.Controls.Add(userManagement1);
            panel5.Location = new Point(276, 24);
            panel5.Name = "panel5";
            panel5.Size = new Size(835, 626);
            panel5.TabIndex = 2;
            // 
            // adminRegisteration1
            // 
            adminRegisteration1.Location = new Point(-25, -45);
            adminRegisteration1.Name = "adminRegisteration1";
            adminRegisteration1.Size = new Size(1250, 828);
            adminRegisteration1.TabIndex = 12;
            adminRegisteration1.Load += adminRegisteration1_Load;
            // 
            // adminHome1
            // 
            adminHome1.Location = new Point(-15, 0);
            adminHome1.Name = "adminHome1";
            adminHome1.Size = new Size(1250, 828);
            adminHome1.TabIndex = 11;
            // 
            // userManagement1
            // 
            userManagement1.Location = new Point(3, -21);
            userManagement1.Name = "userManagement1";
            userManagement1.Size = new Size(1251, 936);
            userManagement1.TabIndex = 0;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1100, 641);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboardForm";
            Load += AdminDashboardForm_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Button homebtn;
        private Panel panel4;
        private Button button1;
        private Button registrationbtn;
        private Button rolesbtn;
        private Label label1;
        private PictureBox pictureBox1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Panel panel5;
        private Button button2;
        private Label label2;
        private userManagement userManagement1;
        private adminHome adminHome1;
        private adminRegisteration adminRegisteration1;
    }
}