namespace Library_Management_System
{
    partial class Book_Issue_Form_Load
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
            pictureBox2 = new PictureBox();
            btnSearch = new Button();
            txtEnrollNumber = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            btnIssue = new Button();
            btnRefresh = new Button();
            btnCancel = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dateTimePicker = new DateTimePicker();
            comboBoxBooks = new ComboBox();
            txtMail = new TextBox();
            txtCon = new TextBox();
            txtSem = new TextBox();
            txtDep = new TextBox();
            txtStdName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.library_1;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(314, 499);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Salmon;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtEnrollNumber);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(313, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(647, 90);
            panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.book_gif_3;
            pictureBox2.Location = new Point(537, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(107, 86);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.IndianRed;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(408, 28);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(110, 33);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtEnrollNumber
            // 
            txtEnrollNumber.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEnrollNumber.ForeColor = Color.Gray;
            txtEnrollNumber.Location = new Point(166, 28);
            txtEnrollNumber.Multiline = true;
            txtEnrollNumber.Name = "txtEnrollNumber";
            txtEnrollNumber.Size = new Size(223, 33);
            txtEnrollNumber.TabIndex = 2;
            txtEnrollNumber.Text = "Enrollement No.";
            txtEnrollNumber.MouseHover += txtEnrollNumber_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(143, 33);
            label1.TabIndex = 0;
            label1.Text = "Issue Books";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(btnIssue);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dateTimePicker);
            panel2.Controls.Add(comboBoxBooks);
            panel2.Controls.Add(txtMail);
            panel2.Controls.Add(txtCon);
            panel2.Controls.Add(txtSem);
            panel2.Controls.Add(txtDep);
            panel2.Controls.Add(txtStdName);
            panel2.Location = new Point(313, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(647, 408);
            panel2.TabIndex = 2;
            // 
            // btnIssue
            // 
            btnIssue.BackColor = Color.IndianRed;
            btnIssue.Cursor = Cursors.Hand;
            btnIssue.FlatStyle = FlatStyle.Popup;
            btnIssue.Font = new Font("Calibri", 12F);
            btnIssue.ForeColor = Color.White;
            btnIssue.Location = new Point(166, 349);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(136, 37);
            btnIssue.TabIndex = 14;
            btnIssue.Text = "Issue";
            btnIssue.UseVisualStyleBackColor = false;
            btnIssue.Click += btnIssue_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.IndianRed;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Calibri", 12F);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(341, 349);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(132, 37);
            btnRefresh.TabIndex = 13;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.IndianRed;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Calibri", 12F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(511, 349);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 37);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F);
            label9.Location = new Point(28, 302);
            label9.Name = "label9";
            label9.Size = new Size(78, 19);
            label9.TabIndex = 12;
            label9.Text = "Issue Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F);
            label8.Location = new Point(28, 260);
            label8.Name = "label8";
            label8.Size = new Size(83, 19);
            label8.TabIndex = 11;
            label8.Text = "Book Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F);
            label7.Location = new Point(28, 219);
            label7.Name = "label7";
            label7.Size = new Size(51, 19);
            label7.TabIndex = 10;
            label7.Text = "E-Mail";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F);
            label6.Location = new Point(28, 174);
            label6.Name = "label6";
            label6.Size = new Size(85, 19);
            label6.TabIndex = 9;
            label6.Text = "Contact No.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F);
            label5.Location = new Point(28, 126);
            label5.Name = "label5";
            label5.Size = new Size(69, 19);
            label5.TabIndex = 8;
            label5.Text = "Semester";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F);
            label4.Location = new Point(28, 80);
            label4.Name = "label4";
            label4.Size = new Size(86, 19);
            label4.TabIndex = 7;
            label4.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F);
            label3.Location = new Point(28, 34);
            label3.Name = "label3";
            label3.Size = new Size(100, 19);
            label3.TabIndex = 5;
            label3.Text = "Student Name";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(166, 302);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(470, 23);
            dateTimePicker.TabIndex = 6;
            // 
            // comboBoxBooks
            // 
            comboBoxBooks.FormattingEnabled = true;
            comboBoxBooks.Location = new Point(166, 260);
            comboBoxBooks.Name = "comboBoxBooks";
            comboBoxBooks.Size = new Size(470, 23);
            comboBoxBooks.TabIndex = 5;
            comboBoxBooks.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(166, 214);
            txtMail.Multiline = true;
            txtMail.Name = "txtMail";
            txtMail.ReadOnly = true;
            txtMail.Size = new Size(470, 28);
            txtMail.TabIndex = 4;
            // 
            // txtCon
            // 
            txtCon.Location = new Point(166, 169);
            txtCon.Multiline = true;
            txtCon.Name = "txtCon";
            txtCon.ReadOnly = true;
            txtCon.Size = new Size(470, 28);
            txtCon.TabIndex = 3;
            // 
            // txtSem
            // 
            txtSem.Location = new Point(166, 121);
            txtSem.Multiline = true;
            txtSem.Name = "txtSem";
            txtSem.ReadOnly = true;
            txtSem.Size = new Size(470, 28);
            txtSem.TabIndex = 2;
            // 
            // txtDep
            // 
            txtDep.Location = new Point(166, 75);
            txtDep.Multiline = true;
            txtDep.Name = "txtDep";
            txtDep.ReadOnly = true;
            txtDep.Size = new Size(470, 28);
            txtDep.TabIndex = 1;
            // 
            // txtStdName
            // 
            txtStdName.Location = new Point(166, 29);
            txtStdName.Multiline = true;
            txtStdName.Name = "txtStdName";
            txtStdName.ReadOnly = true;
            txtStdName.Size = new Size(470, 28);
            txtStdName.TabIndex = 0;
            // 
            // Book_Issue_Form_Load
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 498);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Book_Issue_Form_Load";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book_Issue_Form";
            Load += Book_Issue_Form_Load_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Button btnSearch;
        private TextBox txtEnrollNumber;
        private Label label1;
        private TextBox txtMail;
        private TextBox txtCon;
        private TextBox txtSem;
        private TextBox txtDep;
        private TextBox txtStdName;
        private DateTimePicker dateTimePicker;
        private ComboBox comboBoxBooks;
        private Button btnIssue;
        private Button btnRefresh;
        private Button btnCancel;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}