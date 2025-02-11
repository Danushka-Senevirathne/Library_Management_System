namespace Library_Management_System
{
    partial class Add_Student_Form
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnExit = new Button();
            btnSaveInfo = new Button();
            btnRefresh = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtSemail = new TextBox();
            txtScon = new TextBox();
            txtSsem = new TextBox();
            txtSdp = new TextBox();
            txtSenum = new TextBox();
            txtSName = new TextBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.student_img_1;
            pictureBox1.Location = new Point(0, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(283, 390);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSalmon;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnSaveInfo);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSemail);
            panel1.Controls.Add(txtScon);
            panel1.Controls.Add(txtSsem);
            panel1.Controls.Add(txtSdp);
            panel1.Controls.Add(txtSenum);
            panel1.Controls.Add(txtSName);
            panel1.Location = new Point(284, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 390);
            panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.IndianRed;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Calibri", 12F);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(314, 340);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(115, 33);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSaveInfo
            // 
            btnSaveInfo.BackColor = Color.IndianRed;
            btnSaveInfo.Cursor = Cursors.Hand;
            btnSaveInfo.FlatStyle = FlatStyle.Popup;
            btnSaveInfo.Font = new Font("Calibri", 12F);
            btnSaveInfo.ForeColor = Color.White;
            btnSaveInfo.Location = new Point(172, 340);
            btnSaveInfo.Name = "btnSaveInfo";
            btnSaveInfo.Size = new Size(115, 33);
            btnSaveInfo.TabIndex = 13;
            btnSaveInfo.Text = "Save Info";
            btnSaveInfo.UseVisualStyleBackColor = false;
            btnSaveInfo.Click += btnSaveInfo_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.IndianRed;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Calibri", 12F);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(23, 340);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(115, 33);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F);
            label7.Location = new Point(23, 290);
            label7.Name = "label7";
            label7.Size = new Size(98, 19);
            label7.TabIndex = 11;
            label7.Text = "Student Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F);
            label6.Location = new Point(23, 237);
            label6.Name = "label6";
            label6.Size = new Size(112, 19);
            label6.TabIndex = 10;
            label6.Text = "Student Contact";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F);
            label5.Location = new Point(23, 184);
            label5.Name = "label5";
            label5.Size = new Size(122, 19);
            label5.TabIndex = 9;
            label5.Text = "Student Semester";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F);
            label4.Location = new Point(23, 132);
            label4.Name = "label4";
            label4.Size = new Size(86, 19);
            label4.TabIndex = 8;
            label4.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F);
            label3.Location = new Point(23, 79);
            label3.Name = "label3";
            label3.Size = new Size(105, 19);
            label3.TabIndex = 7;
            label3.Text = "Enrollment No.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F);
            label2.Location = new Point(23, 26);
            label2.Name = "label2";
            label2.Size = new Size(100, 19);
            label2.TabIndex = 6;
            label2.Text = "Student Name";
            // 
            // txtSemail
            // 
            txtSemail.Location = new Point(161, 284);
            txtSemail.Multiline = true;
            txtSemail.Name = "txtSemail";
            txtSemail.Size = new Size(268, 30);
            txtSemail.TabIndex = 5;
            // 
            // txtScon
            // 
            txtScon.Location = new Point(161, 231);
            txtScon.Multiline = true;
            txtScon.Name = "txtScon";
            txtScon.Size = new Size(268, 30);
            txtScon.TabIndex = 4;
            // 
            // txtSsem
            // 
            txtSsem.Location = new Point(161, 178);
            txtSsem.Multiline = true;
            txtSsem.Name = "txtSsem";
            txtSsem.Size = new Size(268, 30);
            txtSsem.TabIndex = 3;
            // 
            // txtSdp
            // 
            txtSdp.Location = new Point(161, 126);
            txtSdp.Multiline = true;
            txtSdp.Name = "txtSdp";
            txtSdp.Size = new Size(268, 30);
            txtSdp.TabIndex = 2;
            // 
            // txtSenum
            // 
            txtSenum.Location = new Point(161, 73);
            txtSenum.Multiline = true;
            txtSenum.Name = "txtSenum";
            txtSenum.Size = new Size(268, 30);
            txtSenum.TabIndex = 1;
            // 
            // txtSName
            // 
            txtSName.Location = new Point(161, 20);
            txtSName.Multiline = true;
            txtSName.Name = "txtSName";
            txtSName.Size = new Size(268, 30);
            txtSName.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Salmon;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(725, 66);
            panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.student_gif_1;
            pictureBox2.Location = new Point(624, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(9, 16);
            label1.Name = "label1";
            label1.Size = new Size(161, 33);
            label1.TabIndex = 0;
            label1.Text = "Add Students";
            // 
            // Add_Student_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Add_Student_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Student_Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label1;
        private Button btnRefresh;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtSemail;
        private TextBox txtScon;
        private TextBox txtSsem;
        private TextBox txtSdp;
        private TextBox txtSenum;
        private TextBox txtSName;
        private Button btnExit;
        private Button btnSaveInfo;
    }
}