namespace Company_Management_System_final
{
    partial class UserControl2
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
            label2 = new Label();
            panel1 = new Panel();
            textBox1 = new MaskedTextBox();
            idtxt = new TextBox();
            label4 = new Label();
            showbtn = new Button();
            button1 = new Button();
            label3 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(485, 293);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(3, 35);
            label1.Name = "label1";
            label1.Size = new Size(254, 32);
            label1.TabIndex = 1;
            label1.Text = "Your Attendance Log";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(271, 32);
            label2.TabIndex = 2;
            label2.Text = "Mark Your Attendance";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(idtxt);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(showbtn);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 552);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(72, 163);
            textBox1.Mask = "0000/00/00";
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 4;
            textBox1.MaskInputRejected += textBox1_MaskInputRejected_1;
            // 
            // idtxt
            // 
            idtxt.Location = new Point(72, 247);
            idtxt.Name = "idtxt";
            idtxt.Size = new Size(150, 31);
            idtxt.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(72, 216);
            label4.Name = "label4";
            label4.Size = new Size(143, 28);
            label4.TabIndex = 6;
            label4.Text = "Enter your ID:";
            label4.Click += label4_Click;
            // 
            // showbtn
            // 
            showbtn.BackColor = Color.Maroon;
            showbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            showbtn.ForeColor = SystemColors.ButtonHighlight;
            showbtn.Location = new Point(171, 320);
            showbtn.Name = "showbtn";
            showbtn.Size = new Size(112, 59);
            showbtn.TabIndex = 5;
            showbtn.Text = "SHOW";
            showbtn.UseVisualStyleBackColor = false;
            showbtn.Click += showbtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(12, 320);
            button1.Name = "button1";
            button1.Size = new Size(134, 59);
            button1.TabIndex = 4;
            button1.Text = "PRESENT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(72, 132);
            label3.Name = "label3";
            label3.Size = new Size(62, 28);
            label3.TabIndex = 2;
            label3.Text = "Date:";
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(341, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(492, 549);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "UserControl2";
            Size = new Size(833, 552);
            Load += UserControl2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Label label3;
        private Button showbtn;
        private TextBox idtxt;
        private Label label4;
        private MaskedTextBox textBox1;
    }
}
