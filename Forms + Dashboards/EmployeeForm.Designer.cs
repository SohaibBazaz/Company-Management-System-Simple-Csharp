using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Company_Management_System_final
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            panel3 = new Panel();
            label3 = new Label();
            complainbtn = new Button();
            userControl21 = new UserControl2();
            attendancebtn = new Button();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            projectbtn = new Button();
            homebtn = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            userControl11 = new Company_2.UserControl1();
            userControl31 = new UserControl3();
            employeeHome1 = new employeeHome();
            userControl22 = new UserControl2();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonShadow;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(complainbtn);
            panel3.Controls.Add(userControl21);
            panel3.Controls.Add(attendancebtn);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(projectbtn);
            panel3.Controls.Add(homebtn);
            panel3.Location = new Point(0, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(255, 734);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 114);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 13;
            label3.Text = "label3";
            label3.Click += label3_Click;
            // 
            // complainbtn
            // 
            complainbtn.BackColor = SystemColors.ControlDark;
            complainbtn.BackgroundImageLayout = ImageLayout.Stretch;
            complainbtn.FlatAppearance.BorderSize = 0;
            complainbtn.FlatStyle = FlatStyle.Flat;
            complainbtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            complainbtn.ForeColor = SystemColors.ActiveCaptionText;
            complainbtn.Location = new Point(0, 355);
            complainbtn.Name = "complainbtn";
            complainbtn.Size = new Size(269, 59);
            complainbtn.TabIndex = 12;
            complainbtn.Text = "Complain";
            complainbtn.UseVisualStyleBackColor = false;
            complainbtn.Click += complainbtn_Click;
            // 
            // userControl21
            // 
            userControl21.Location = new Point(261, 11);
            userControl21.Name = "userControl21";
            userControl21.Size = new Size(825, 624);
            userControl21.TabIndex = 13;
            // 
            // attendancebtn
            // 
            attendancebtn.BackColor = SystemColors.ControlDark;
            attendancebtn.BackgroundImageLayout = ImageLayout.Stretch;
            attendancebtn.FlatAppearance.BorderSize = 0;
            attendancebtn.FlatStyle = FlatStyle.Flat;
            attendancebtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            attendancebtn.ForeColor = SystemColors.ActiveCaptionText;
            attendancebtn.Location = new Point(0, 290);
            attendancebtn.Name = "attendancebtn";
            attendancebtn.Size = new Size(272, 59);
            attendancebtn.TabIndex = 11;
            attendancebtn.Text = "Attendance";
            attendancebtn.UseVisualStyleBackColor = false;
            attendancebtn.Click += attendancebtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Maroon;
            label2.Font = new Font("Segoe UI", 7F);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(174, 235);
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
            button2.Location = new Point(2, 513);
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
            // projectbtn
            // 
            projectbtn.BackColor = SystemColors.ControlDark;
            projectbtn.BackgroundImageLayout = ImageLayout.Stretch;
            projectbtn.FlatAppearance.BorderSize = 0;
            projectbtn.FlatStyle = FlatStyle.Flat;
            projectbtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            projectbtn.ForeColor = SystemColors.ActiveCaptionText;
            projectbtn.Location = new Point(-8, 225);
            projectbtn.Name = "projectbtn";
            projectbtn.Size = new Size(277, 59);
            projectbtn.TabIndex = 4;
            projectbtn.Text = "Projects";
            projectbtn.UseVisualStyleBackColor = false;
            projectbtn.Click += projectbtn_Click;
            // 
            // homebtn
            // 
            homebtn.BackColor = SystemColors.ControlDark;
            homebtn.BackgroundImageLayout = ImageLayout.Stretch;
            homebtn.FlatAppearance.BorderSize = 0;
            homebtn.FlatStyle = FlatStyle.Flat;
            homebtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homebtn.ForeColor = SystemColors.ActiveCaptionText;
            homebtn.Location = new Point(-8, 160);
            homebtn.Name = "homebtn";
            homebtn.Size = new Size(277, 59);
            homebtn.TabIndex = 2;
            homebtn.Text = "Home";
            homebtn.UseVisualStyleBackColor = false;
            homebtn.Click += homebtn_Click;
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
            panel1.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Maroon;
            panel4.Location = new Point(314, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 18);
            panel4.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(245, 570);
            panel2.TabIndex = 0;
            // 
            // userControl11
            // 
            userControl11.Location = new Point(261, 12);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(1250, 828);
            userControl11.TabIndex = 5;
            // 
            // userControl31
            // 
            userControl31.Location = new Point(261, 12);
            userControl31.Name = "userControl31";
            userControl31.Size = new Size(1250, 828);
            userControl31.TabIndex = 14;
            userControl31.Load += userControl31_Load;
            // 
            // employeeHome1
            // 
            employeeHome1.Location = new Point(261, 12);
            employeeHome1.Name = "employeeHome1";
            employeeHome1.Size = new Size(1250, 828);
            employeeHome1.TabIndex = 15;
            employeeHome1.Load += employeeHome1_Load_1;
            // 
            // userControl22
            // 
            userControl22.Location = new Point(251, 14);
            userControl22.Name = "userControl22";
            userControl22.Size = new Size(1250, 828);
            userControl22.TabIndex = 16;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 641);
            Controls.Add(userControl22);
            Controls.Add(employeeHome1);
            Controls.Add(panel3);
            Controls.Add(userControl31);
            Controls.Add(userControl11);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeForm";
            Load += EmployeeForm_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label2;
        private Button button2;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button projectbtn;
        private Button homebtn;
        private Panel panel1;
        private Panel panel4;
        private Panel panel2;
        private Button attendancebtn;
        private Button complainbtn;
        private Company_2.UserControl1 userControl11;
        private UserControl2 userControl21;
        private UserControl3 userControl31;
        private Label label3;
        private employeeHome employeeHome1;
        private UserControl2 userControl22;
    }
}