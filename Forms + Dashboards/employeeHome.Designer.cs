namespace Company_Management_System_final
{
    partial class employeeHome
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label11 = new Label();
            label12 = new Label();
            panel6 = new Panel();
            label13 = new Label();
            panel8 = new Panel();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(15, 214);
            label1.Name = "label1";
            label1.Size = new Size(148, 30);
            label1.TabIndex = 2;
            label1.Text = "Personal Info";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 283);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(799, 225);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(72, 55);
            label11.Name = "label11";
            label11.Size = new Size(91, 32);
            label11.TabIndex = 0;
            label11.Text = "label11";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(39, -2);
            label12.Name = "label12";
            label12.Size = new Size(161, 30);
            label12.TabIndex = 0;
            label12.Text = "Project Count:";
            label12.Click += label12_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Maroon;
            panel6.Controls.Add(label11);
            panel6.Controls.Add(label13);
            panel6.Controls.Add(label12);
            panel6.Location = new Point(58, 31);
            panel6.Name = "panel6";
            panel6.Size = new Size(247, 141);
            panel6.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(2, 55);
            label13.Name = "label13";
            label13.Size = new Size(0, 30);
            label13.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Maroon;
            panel8.Controls.Add(label4);
            panel8.Controls.Add(label3);
            panel8.Location = new Point(527, 31);
            panel8.Name = "panel8";
            panel8.Size = new Size(247, 141);
            panel8.TabIndex = 7;
            panel8.Paint += panel8_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(87, 55);
            label4.Name = "label4";
            label4.Size = new Size(78, 32);
            label4.TabIndex = 2;
            label4.Text = "label4";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(44, 0);
            label3.Name = "label3";
            label3.Size = new Size(179, 30);
            label3.TabIndex = 3;
            label3.Text = "Your Complains:";
            // 
            // employeeHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel6);
            Controls.Add(panel8);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "employeeHome";
            Size = new Size(833, 552);
            Load += employeeHome_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dataGridView1;
        private Label label11;
        private Label label12;
        private Panel panel6;
        private Label label13;
        private Panel panel8;
        private Label label3;
        private Label label4;
    }
}
