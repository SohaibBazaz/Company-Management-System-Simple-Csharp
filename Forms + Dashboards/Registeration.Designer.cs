namespace Company_Management_System_final
{
    partial class adminRegisteration
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            roletxt = new ComboBox();
            showbtn = new Button();
            removebtn = new Button();
            addbtn = new Button();
            label1 = new Label();
            Password = new Label();
            Username = new Label();
            passwordtxt = new TextBox();
            usernametxt = new TextBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(roletxt);
            panel1.Controls.Add(showbtn);
            panel1.Controls.Add(removebtn);
            panel1.Controls.Add(addbtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Password);
            panel1.Controls.Add(Username);
            panel1.Controls.Add(passwordtxt);
            panel1.Controls.Add(usernametxt);
            panel1.Location = new Point(20, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 530);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // roletxt
            // 
            roletxt.FormattingEnabled = true;
            roletxt.Items.AddRange(new object[] { "employee", "head", "admin" });
            roletxt.Location = new Point(39, 381);
            roletxt.Name = "roletxt";
            roletxt.Size = new Size(231, 33);
            roletxt.TabIndex = 9;
            roletxt.SelectedIndexChanged += roletxt_SelectedIndexChanged;
            // 
            // showbtn
            // 
            showbtn.Location = new Point(87, 55);
            showbtn.Name = "showbtn";
            showbtn.Size = new Size(112, 55);
            showbtn.TabIndex = 8;
            showbtn.Text = "SHOW";
            showbtn.UseVisualStyleBackColor = true;
            showbtn.Click += button3_Click;
            // 
            // removebtn
            // 
            removebtn.Location = new Point(170, 441);
            removebtn.Name = "removebtn";
            removebtn.Size = new Size(112, 55);
            removebtn.TabIndex = 7;
            removebtn.Text = "REMOVE";
            removebtn.UseVisualStyleBackColor = true;
            removebtn.Click += removebtn_Click;
            // 
            // addbtn
            // 
            addbtn.Location = new Point(39, 441);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(112, 55);
            addbtn.TabIndex = 6;
            addbtn.Text = "ADD";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 353);
            label1.Name = "label1";
            label1.Size = new Size(46, 25);
            label1.TabIndex = 5;
            label1.Text = "Role";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(39, 258);
            Password.Name = "Password";
            Password.Size = new Size(87, 25);
            Password.TabIndex = 4;
            Password.Text = "Password";
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(39, 164);
            Username.Name = "Username";
            Username.Size = new Size(91, 25);
            Username.TabIndex = 3;
            Username.Text = "Username";
            // 
            // passwordtxt
            // 
            passwordtxt.Location = new Point(39, 286);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(231, 31);
            passwordtxt.TabIndex = 1;
            passwordtxt.TextChanged += passwordtxt_TextChanged;
            // 
            // usernametxt
            // 
            usernametxt.Location = new Point(39, 192);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(231, 31);
            usernametxt.TabIndex = 0;
            usernametxt.TextChanged += usernametxt_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(334, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(505, 527);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(481, 275);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 27);
            label2.Name = "label2";
            label2.Size = new Size(183, 25);
            label2.TabIndex = 0;
            label2.Text = "Pending Registrations";
            // 
            // adminRegisteration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "adminRegisteration";
            Size = new Size(833, 552);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox usernametxt;
        private Label Username;
        private TextBox passwordtxt;
        private Button removebtn;
        private Button addbtn;
        private Label label1;
        private Label Password;
        private Panel panel2;
        private Label label2;
        private DataGridView dataGridView1;
        private Button showbtn;
        private ComboBox roletxt;
    }
}
