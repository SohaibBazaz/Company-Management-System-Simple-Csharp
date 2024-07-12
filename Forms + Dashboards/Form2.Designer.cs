namespace Company_Management_System_final
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            pictureBox1 = new PictureBox();
            passwordtxt = new RichTextBox();
            panel1 = new Panel();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            confirmpasswordtxt = new RichTextBox();
            exitbtn = new Button();
            registerbtn = new Button();
            panel3 = new Panel();
            usernametxt = new RichTextBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(241, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 129);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // passwordtxt
            // 
            passwordtxt.BackColor = Color.DarkGray;
            passwordtxt.BorderStyle = BorderStyle.None;
            passwordtxt.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            passwordtxt.Location = new Point(48, 3);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(348, 45);
            passwordtxt.TabIndex = 1;
            passwordtxt.Text = "Password";
            passwordtxt.TextChanged += passwordtxt_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(iconPictureBox3);
            panel1.Controls.Add(passwordtxt);
            panel1.Location = new Point(98, 260);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 51);
            panel1.TabIndex = 8;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = SystemColors.ControlDarkDark;
            iconPictureBox3.ForeColor = SystemColors.ControlText;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPictureBox3.IconColor = SystemColors.ControlText;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 48;
            iconPictureBox3.Location = new Point(0, 3);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(48, 48);
            iconPictureBox3.TabIndex = 2;
            iconPictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(confirmpasswordtxt);
            panel2.Location = new Point(98, 326);
            panel2.Name = "panel2";
            panel2.Size = new Size(399, 51);
            panel2.TabIndex = 10;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.ControlDarkDark;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 48;
            iconPictureBox1.Location = new Point(0, 3);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(48, 48);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // confirmpasswordtxt
            // 
            confirmpasswordtxt.BackColor = Color.DarkGray;
            confirmpasswordtxt.BorderStyle = BorderStyle.None;
            confirmpasswordtxt.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            confirmpasswordtxt.Location = new Point(48, 3);
            confirmpasswordtxt.Name = "confirmpasswordtxt";
            confirmpasswordtxt.Size = new Size(351, 45);
            confirmpasswordtxt.TabIndex = 1;
            confirmpasswordtxt.Text = "Password";
            // 
            // exitbtn
            // 
            exitbtn.BackColor = Color.DarkGray;
            exitbtn.FlatStyle = FlatStyle.Flat;
            exitbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            exitbtn.Location = new Point(583, -1);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(32, 34);
            exitbtn.TabIndex = 13;
            exitbtn.Text = "X";
            exitbtn.UseVisualStyleBackColor = false;
            exitbtn.Click += exitbtn_Click;
            // 
            // registerbtn
            // 
            registerbtn.BackColor = Color.DarkGray;
            registerbtn.FlatStyle = FlatStyle.Flat;
            registerbtn.Location = new Point(253, 425);
            registerbtn.Name = "registerbtn";
            registerbtn.Size = new Size(112, 53);
            registerbtn.TabIndex = 12;
            registerbtn.Text = "Sign Up";
            registerbtn.UseVisualStyleBackColor = false;
            registerbtn.Click += registerbtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(usernametxt);
            panel3.Controls.Add(iconPictureBox2);
            panel3.Location = new Point(98, 194);
            panel3.Name = "panel3";
            panel3.Size = new Size(399, 51);
            panel3.TabIndex = 9;
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
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.DimGray;
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 48;
            iconPictureBox2.Location = new Point(0, 0);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(48, 48);
            iconPictureBox2.TabIndex = 0;
            iconPictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(250, 160);
            label1.Name = "label1";
            label1.Size = new Size(115, 31);
            label1.TabIndex = 14;
            label1.Text = "SIGN UP";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(616, 514);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(exitbtn);
            Controls.Add(registerbtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrations";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private RichTextBox passwordtxt;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private RichTextBox confirmpasswordtxt;
        private Button exitbtn;
        private Button registerbtn;
        private Panel panel3;
        private RichTextBox usernametxt;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label label1;
    }
}