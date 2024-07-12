namespace Company_Management_System_final
{
    partial class UserControl5
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
            label1 = new Label();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            nametxt = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(713, 246);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(36, 21);
            label1.Name = "label1";
            label1.Size = new Size(227, 30);
            label1.TabIndex = 1;
            label1.Text = "Pending Complaints:";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(23, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 329);
            panel1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Approved,", "Rejected" });
            comboBox1.Location = new Point(249, 446);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(37, 346);
            label2.Name = "label2";
            label2.Size = new Size(119, 32);
            label2.TabIndex = 3;
            label2.Text = "Approval";
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(513, 407);
            button1.Name = "button1";
            button1.Size = new Size(112, 57);
            button1.TabIndex = 4;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 395);
            label3.Name = "label3";
            label3.Size = new Size(206, 25);
            label3.TabIndex = 5;
            label3.Text = "Name: (Capital Sensitive)";
            // 
            // nametxt
            // 
            nametxt.Location = new Point(249, 395);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(182, 31);
            nametxt.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 449);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 7;
            label4.Text = "Verdict:";
            // 
            // UserControl5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(nametxt);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Name = "UserControl5";
            Size = new Size(833, 552);
            Load += UserControl5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel1;
        private ComboBox comboBox1;
        private Label label2;
        private Button button1;
        private Label label3;
        private TextBox nametxt;
        private Label label4;
    }
}
