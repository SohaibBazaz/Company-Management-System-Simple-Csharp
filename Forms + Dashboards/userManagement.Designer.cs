namespace Company_Management_System_final
{
    partial class userManagement
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
            label3 = new Label();
            idtxt = new TextBox();
            viewbtn = new Button();
            updatebtn = new Button();
            label1 = new Label();
            Password = new Label();
            Username = new Label();
            passwordtxt = new TextBox();
            usernametxt = new TextBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            roletxt = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(roletxt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(idtxt);
            panel1.Controls.Add(viewbtn);
            panel1.Controls.Add(updatebtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Password);
            panel1.Controls.Add(Username);
            panel1.Controls.Add(passwordtxt);
            panel1.Controls.Add(usernametxt);
            panel1.Location = new Point(14, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 530);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 34);
            label3.Name = "label3";
            label3.Size = new Size(30, 25);
            label3.TabIndex = 11;
            label3.Text = "ID";
            label3.Click += label3_Click;
            // 
            // idtxt
            // 
            idtxt.Location = new Point(28, 62);
            idtxt.Name = "idtxt";
            idtxt.Size = new Size(231, 31);
            idtxt.TabIndex = 10;
            idtxt.TextChanged += idtxt_TextChanged;
            // 
            // viewbtn
            // 
            viewbtn.Location = new Point(160, 397);
            viewbtn.Name = "viewbtn";
            viewbtn.Size = new Size(112, 66);
            viewbtn.TabIndex = 7;
            viewbtn.Text = "VIEW DETAILS";
            viewbtn.UseVisualStyleBackColor = true;
            // 
            // updatebtn
            // 
            updatebtn.Location = new Point(28, 403);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(112, 55);
            updatebtn.TabIndex = 6;
            updatebtn.Text = "UPDATE";
            updatebtn.UseVisualStyleBackColor = true;
            updatebtn.Click += updatebtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 296);
            label1.Name = "label1";
            label1.Size = new Size(46, 25);
            label1.TabIndex = 5;
            label1.Text = "Role";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(28, 201);
            Password.Name = "Password";
            Password.Size = new Size(87, 25);
            Password.TabIndex = 4;
            Password.Text = "Password";
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(28, 107);
            Username.Name = "Username";
            Username.Size = new Size(91, 25);
            Username.TabIndex = 3;
            Username.Text = "Username";
            // 
            // passwordtxt
            // 
            passwordtxt.Location = new Point(28, 229);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(231, 31);
            passwordtxt.TabIndex = 1;
            // 
            // usernametxt
            // 
            usernametxt.Location = new Point(28, 135);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(231, 31);
            usernametxt.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(337, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(481, 275);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 33);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 3;
            label2.Text = "Employee List";
            // 
            // roletxt
            // 
            roletxt.FormattingEnabled = true;
            roletxt.Items.AddRange(new object[] { "employee", "head", "admin" });
            roletxt.Location = new Point(28, 324);
            roletxt.Name = "roletxt";
            roletxt.Size = new Size(231, 33);
            roletxt.TabIndex = 12;
            // 
            // userManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Name = "userManagement";
            Size = new Size(834, 624);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button viewbtn;
        private Button updatebtn;
        private Label label1;
        private Label Password;
        private Label Username;
        private TextBox passwordtxt;
        private TextBox usernametxt;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private TextBox idtxt;
        private ComboBox roletxt;
    }
}
