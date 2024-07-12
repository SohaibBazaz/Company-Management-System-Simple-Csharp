namespace Company_Management_System_final
{
    partial class departmentHome
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
            panel6 = new Panel();
            label11 = new Label();
            label13 = new Label();
            label12 = new Label();
            panel7 = new Panel();
            panel8 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.BackColor = Color.Maroon;
            panel6.Controls.Add(label11);
            panel6.Controls.Add(label13);
            panel6.Controls.Add(label12);
            panel6.Location = new Point(3, 49);
            panel6.Name = "panel6";
            panel6.Size = new Size(271, 141);
            panel6.TabIndex = 8;
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
            // 
            // panel7
            // 
            panel7.BackColor = Color.Maroon;
            panel7.Location = new Point(555, 49);
            panel7.Name = "panel7";
            panel7.Size = new Size(271, 139);
            panel7.TabIndex = 9;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Maroon;
            panel8.Location = new Point(278, 49);
            panel8.Name = "panel8";
            panel8.Size = new Size(271, 141);
            panel8.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(837, 199);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(5, 266);
            panel2.Name = "panel2";
            panel2.Size = new Size(825, 283);
            panel2.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(796, 225);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(14, 5);
            label1.Name = "label1";
            label1.Size = new Size(141, 28);
            label1.TabIndex = 13;
            label1.Text = "Personal Info:";
            // 
            // departmentHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(panel8);
            Controls.Add(panel1);
            Name = "departmentHome";
            Size = new Size(833, 552);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel6;
        private Label label11;
        private Label label13;
        private Label label12;
        private Panel panel7;
        private Panel panel8;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label1;
    }
}
