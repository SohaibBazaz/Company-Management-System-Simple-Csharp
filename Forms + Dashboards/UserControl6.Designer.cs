namespace Company_Management_System_final
{
    partial class UserControl6
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            usernametxt = new TextBox();
            label5 = new Label();
            endtxt = new MaskedTextBox();
            label4 = new Label();
            starttxt = new MaskedTextBox();
            label3 = new Label();
            projectnametxt = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(492, 272);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(319, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(511, 546);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(16, 31);
            label1.Name = "label1";
            label1.Size = new Size(151, 32);
            label1.TabIndex = 1;
            label1.Text = "All Projects:";
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(usernametxt);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(endtxt);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(starttxt);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(projectnametxt);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(310, 546);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(91, 369);
            button1.Name = "button1";
            button1.Size = new Size(112, 60);
            button1.TabIndex = 8;
            button1.Text = "APPLY";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // usernametxt
            // 
            usernametxt.Location = new Point(3, 283);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(200, 31);
            usernametxt.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(3, 252);
            label5.Name = "label5";
            label5.Size = new Size(235, 28);
            label5.TabIndex = 6;
            label5.Text = "Username of Employee:";
            // 
            // endtxt
            // 
            endtxt.Location = new Point(147, 182);
            endtxt.Mask = "0000/00/000";
            endtxt.Name = "endtxt";
            endtxt.Size = new Size(113, 31);
            endtxt.TabIndex = 5;
            endtxt.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(122, 185);
            label4.Name = "label4";
            label4.Size = new Size(19, 25);
            label4.TabIndex = 4;
            label4.Text = "-";
            // 
            // starttxt
            // 
            starttxt.Location = new Point(3, 179);
            starttxt.Mask = "0000/00/000";
            starttxt.Name = "starttxt";
            starttxt.Size = new Size(113, 31);
            starttxt.TabIndex = 3;
            starttxt.ValidatingType = typeof(DateTime);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(3, 133);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 2;
            label3.Text = "Duration:";
            // 
            // projectnametxt
            // 
            projectnametxt.Location = new Point(3, 69);
            projectnametxt.Name = "projectnametxt";
            projectnametxt.Size = new Size(200, 31);
            projectnametxt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(3, 38);
            label2.Name = "label2";
            label2.Size = new Size(146, 28);
            label2.TabIndex = 0;
            label2.Text = "Project Name:";
            // 
            // UserControl6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserControl6";
            Size = new Size(833, 552);
            Load += UserControl6_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private TextBox projectnametxt;
        private Label label5;
        private MaskedTextBox endtxt;
        private Label label4;
        private MaskedTextBox starttxt;
        private Label label3;
        private TextBox usernametxt;
        private Button button1;
    }
}
