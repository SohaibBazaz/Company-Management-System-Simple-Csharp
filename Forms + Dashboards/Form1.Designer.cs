namespace Company_Management_System_final
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            usernametxt = new RichTextBox();
            panel1 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            passwordtxt = new RichTextBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            loginbtn = new Button();
            checkBox1 = new CheckBox();
            button2 = new Button();
            exitbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(278, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 157);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // usernametxt
            // 
            usernametxt.BackColor = Color.DarkGray;
            usernametxt.BorderStyle = BorderStyle.None;
            usernametxt.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            usernametxt.Location = new Point(48, 3);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(348, 45);
            usernametxt.TabIndex = 1;
            usernametxt.Text = "Username";
            usernametxt.TextChanged += usernametxt_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(usernametxt);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Location = new Point(148, 275);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 51);
            panel1.TabIndex = 2;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.DimGray;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 48;
            iconPictureBox1.Location = new Point(0, 0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(48, 48);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(passwordtxt);
            panel2.Controls.Add(iconPictureBox3);
            panel2.Location = new Point(148, 343);
            panel2.Name = "panel2";
            panel2.Size = new Size(399, 51);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // passwordtxt
            // 
            passwordtxt.BackColor = Color.DarkGray;
            passwordtxt.BorderStyle = BorderStyle.None;
            passwordtxt.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            passwordtxt.Location = new Point(48, 3);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(351, 45);
            passwordtxt.TabIndex = 1;
            passwordtxt.Text = "Password";
            passwordtxt.TextChanged += passwordtxt_TextChanged;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = SystemColors.ControlDarkDark;
            iconPictureBox3.ForeColor = SystemColors.ControlText;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPictureBox3.IconColor = SystemColors.ControlText;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 48;
            iconPictureBox3.Location = new Point(0, 0);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(48, 48);
            iconPictureBox3.TabIndex = 0;
            iconPictureBox3.TabStop = false;
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.DarkGray;
            loginbtn.FlatStyle = FlatStyle.Flat;
            loginbtn.Location = new Point(306, 462);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(112, 54);
            loginbtn.TabIndex = 2;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBox1.Location = new Point(148, 407);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(162, 29);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Remember Me";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(435, 397);
            button2.Name = "button2";
            button2.Size = new Size(112, 39);
            button2.TabIndex = 5;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // exitbtn
            // 
            exitbtn.BackColor = Color.DarkGray;
            exitbtn.FlatStyle = FlatStyle.Flat;
            exitbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            exitbtn.Location = new Point(670, 0);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(32, 34);
            exitbtn.TabIndex = 6;
            exitbtn.Text = "X";
            exitbtn.UseVisualStyleBackColor = false;
            exitbtn.Click += exitbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(196, 186);
            label1.Name = "label1";
            label1.Size = new Size(324, 31);
            label1.TabIndex = 7;
            label1.Text = "DPL Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(315, 230);
            label2.Name = "label2";
            label2.Size = new Size(90, 31);
            label2.TabIndex = 8;
            label2.Text = "Login ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(550, 287);
            label3.Name = "label3";
            label3.Size = new Size(135, 25);
            label3.TabIndex = 9;
            label3.Text = "(Case-Sensitive)";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(699, 578);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(exitbtn);
            Controls.Add(button2);
            Controls.Add(checkBox1);
            Controls.Add(loginbtn);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private RichTextBox usernametxt;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel2;
        private RichTextBox passwordtxt;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Button loginbtn;
        private CheckBox checkBox1;
        private Button button2;
        private Button exitbtn;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
