namespace Library_Management_System
{
    partial class View_Student_Form_Load
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
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnCancel = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtMail = new TextBox();
            txtCon = new TextBox();
            txtSem = new TextBox();
            txtDepart = new TextBox();
            txtEnroll = new TextBox();
            txtName = new TextBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel3 = new Panel();
            btnRefresh = new Button();
            txtSearchStudent = new TextBox();
            label2 = new Label();
            StudentGridView = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSalmon;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(txtMail);
            panel1.Controls.Add(txtCon);
            panel1.Controls.Add(txtSem);
            panel1.Controls.Add(txtDepart);
            panel1.Controls.Add(txtEnroll);
            panel1.Controls.Add(txtName);
            panel1.Location = new Point(810, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 453);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F);
            label8.Location = new Point(19, 308);
            label8.Name = "label8";
            label8.Size = new Size(45, 19);
            label8.TabIndex = 13;
            label8.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F);
            label7.Location = new Point(19, 254);
            label7.Name = "label7";
            label7.Size = new Size(85, 19);
            label7.TabIndex = 12;
            label7.Text = "Contact No.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F);
            label6.Location = new Point(19, 203);
            label6.Name = "label6";
            label6.Size = new Size(69, 19);
            label6.TabIndex = 11;
            label6.Text = "Semester";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F);
            label5.Location = new Point(19, 151);
            label5.Name = "label5";
            label5.Size = new Size(86, 19);
            label5.TabIndex = 10;
            label5.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F);
            label4.Location = new Point(19, 97);
            label4.Name = "label4";
            label4.Size = new Size(105, 19);
            label4.TabIndex = 9;
            label4.Text = "Enrollment No.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F);
            label3.Location = new Point(19, 46);
            label3.Name = "label3";
            label3.Size = new Size(100, 19);
            label3.TabIndex = 8;
            label3.Text = "Student Name";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.IndianRed;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Calibri", 12F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(244, 377);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(103, 35);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Calibri", 12F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(132, 377);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 35);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.IndianRed;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Calibri", 12F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(19, 377);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(103, 35);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(143, 301);
            txtMail.Multiline = true;
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(204, 31);
            txtMail.TabIndex = 5;
            // 
            // txtCon
            // 
            txtCon.Location = new Point(143, 247);
            txtCon.Multiline = true;
            txtCon.Name = "txtCon";
            txtCon.Size = new Size(204, 31);
            txtCon.TabIndex = 4;
            // 
            // txtSem
            // 
            txtSem.Location = new Point(143, 196);
            txtSem.Multiline = true;
            txtSem.Name = "txtSem";
            txtSem.Size = new Size(204, 31);
            txtSem.TabIndex = 3;
            // 
            // txtDepart
            // 
            txtDepart.Location = new Point(143, 144);
            txtDepart.Multiline = true;
            txtDepart.Name = "txtDepart";
            txtDepart.Size = new Size(204, 31);
            txtDepart.TabIndex = 2;
            // 
            // txtEnroll
            // 
            txtEnroll.Location = new Point(143, 90);
            txtEnroll.Multiline = true;
            txtEnroll.Name = "txtEnroll";
            txtEnroll.Size = new Size(204, 31);
            txtEnroll.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(143, 39);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(204, 31);
            txtName.TabIndex = 0;
            txtName.TextChanged += textBox2_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Salmon;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1179, 57);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.student_gif_11;
            pictureBox1.Location = new Point(1081, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(170, 33);
            label1.TabIndex = 0;
            label1.Text = "View Students";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSalmon;
            panel3.Controls.Add(btnRefresh);
            panel3.Controls.Add(txtSearchStudent);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(0, 57);
            panel3.Name = "panel3";
            panel3.Size = new Size(811, 69);
            panel3.TabIndex = 2;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.IndianRed;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(488, 17);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(109, 33);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtSearchStudent
            // 
            txtSearchStudent.Location = new Point(230, 17);
            txtSearchStudent.Multiline = true;
            txtSearchStudent.Name = "txtSearchStudent";
            txtSearchStudent.Size = new Size(233, 33);
            txtSearchStudent.TabIndex = 1;
            txtSearchStudent.TextChanged += txtSearchStudent_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(101, 23);
            label2.Name = "label2";
            label2.Size = new Size(100, 19);
            label2.TabIndex = 0;
            label2.Text = "Student Name";
            // 
            // StudentGridView
            // 
            StudentGridView.BackgroundColor = Color.Snow;
            StudentGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentGridView.Location = new Point(0, 125);
            StudentGridView.Name = "StudentGridView";
            StudentGridView.Size = new Size(811, 384);
            StudentGridView.TabIndex = 3;
            StudentGridView.CellClick += StudentGridView_CellClick;
            // 
            // View_Student_Form_Load
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 509);
            Controls.Add(StudentGridView);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "View_Student_Form_Load";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View_Student_Form";
            Load += View_Student_Form_Load_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StudentGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView StudentGridView;
        private TextBox txtName;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnRefresh;
        private TextBox txtSearchStudent;
        private Label label2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtMail;
        private TextBox txtCon;
        private TextBox txtSem;
        private TextBox txtDepart;
        private TextBox txtEnroll;
    }
}