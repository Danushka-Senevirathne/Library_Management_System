namespace Library_Management_System
{
    partial class Book_Return_Form
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
            label4 = new Label();
            label3 = new Label();
            dateTimePickerReturnDate = new DateTimePicker();
            txtIssuedDate = new TextBox();
            btnCancel = new Button();
            btnRefresh = new Button();
            btnReturn = new Button();
            txtBookName = new TextBox();
            label2 = new Label();
            dataGridViewTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.library_2;
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(334, 431);
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
            panel1.Location = new Point(333, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 73);
            panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.book_gif_1;
            pictureBox2.Location = new Point(681, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.IndianRed;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(494, 19);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(125, 32);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtEnrollNumber
            // 
            txtEnrollNumber.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEnrollNumber.ForeColor = Color.Gray;
            txtEnrollNumber.Location = new Point(200, 19);
            txtEnrollNumber.Multiline = true;
            txtEnrollNumber.Name = "txtEnrollNumber";
            txtEnrollNumber.Size = new Size(269, 32);
            txtEnrollNumber.TabIndex = 1;
            txtEnrollNumber.Text = "Enroll Number";
            txtEnrollNumber.MouseHover += txtEnrollNumber_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(150, 33);
            label1.TabIndex = 0;
            label1.Text = "Book Return";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dateTimePickerReturnDate);
            panel2.Controls.Add(txtIssuedDate);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(btnReturn);
            panel2.Controls.Add(txtBookName);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(333, 283);
            panel2.Name = "panel2";
            panel2.Size = new Size(770, 149);
            panel2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F);
            label4.Location = new Point(17, 114);
            label4.Name = "label4";
            label4.Size = new Size(123, 19);
            label4.TabIndex = 8;
            label4.Text = "Book Retern Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F);
            label3.Location = new Point(17, 67);
            label3.Name = "label3";
            label3.Size = new Size(122, 19);
            label3.TabIndex = 7;
            label3.Text = "Book Issued Date";
            // 
            // dateTimePickerReturnDate
            // 
            dateTimePickerReturnDate.Location = new Point(201, 110);
            dateTimePickerReturnDate.Name = "dateTimePickerReturnDate";
            dateTimePickerReturnDate.Size = new Size(385, 23);
            dateTimePickerReturnDate.TabIndex = 6;
            // 
            // txtIssuedDate
            // 
            txtIssuedDate.Location = new Point(200, 59);
            txtIssuedDate.Multiline = true;
            txtIssuedDate.Name = "txtIssuedDate";
            txtIssuedDate.ReadOnly = true;
            txtIssuedDate.Size = new Size(386, 35);
            txtIssuedDate.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.IndianRed;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Calibri", 12F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(622, 106);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 29);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.IndianRed;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Calibri", 12F);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(622, 59);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 29);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.IndianRed;
            btnReturn.Cursor = Cursors.Hand;
            btnReturn.FlatStyle = FlatStyle.Popup;
            btnReturn.Font = new Font("Calibri", 12F);
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(622, 12);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(110, 29);
            btnReturn.TabIndex = 2;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = false;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(200, 12);
            txtBookName.Multiline = true;
            txtBookName.Name = "txtBookName";
            txtBookName.ReadOnly = true;
            txtBookName.Size = new Size(386, 33);
            txtBookName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F);
            label2.Location = new Point(17, 20);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 0;
            label2.Text = "Book Name";
            // 
            // dataGridViewTable
            // 
            dataGridViewTable.BackgroundColor = Color.White;
            dataGridViewTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTable.Location = new Point(333, 80);
            dataGridViewTable.Name = "dataGridViewTable";
            dataGridViewTable.ReadOnly = true;
            dataGridViewTable.Size = new Size(770, 197);
            dataGridViewTable.TabIndex = 3;
            // 
            // Book_Return_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1103, 432);
            Controls.Add(dataGridViewTable);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Book_Return_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book_Return_Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button btnSearch;
        private TextBox txtEnrollNumber;
        private Label label1;
        private Panel panel2;
        private Button btnReturn;
        private TextBox txtBookName;
        private Label label2;
        private DataGridView dataGridViewTable;
        private Label label4;
        private Label label3;
        private DateTimePicker dateTimePickerReturnDate;
        private TextBox txtIssuedDate;
        private Button btnCancel;
        private Button btnRefresh;
    }
}