namespace Library_Management_System
{
    partial class View_book_form
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            txtBQuantity = new TextBox();
            txtBPrice = new TextBox();
            txtBDate = new TextBox();
            txtBPublisher = new TextBox();
            txtBAuthor = new TextBox();
            txtBName = new TextBox();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            label9 = new Label();
            textBox1 = new TextBox();
            btnRefresh = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1145, 62);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(140, 33);
            label1.TabIndex = 1;
            label1.Text = "View Books";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.book_gif_2;
            pictureBox1.Location = new Point(1049, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(txtBQuantity);
            panel2.Controls.Add(txtBPrice);
            panel2.Controls.Add(txtBDate);
            panel2.Controls.Add(txtBPublisher);
            panel2.Controls.Add(txtBAuthor);
            panel2.Controls.Add(txtBName);
            panel2.Location = new Point(761, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(383, 473);
            panel2.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(29, 358);
            label8.Name = "label8";
            label8.Size = new Size(65, 19);
            label8.TabIndex = 12;
            label8.Text = "Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(29, 297);
            label7.Name = "label7";
            label7.Size = new Size(41, 19);
            label7.TabIndex = 11;
            label7.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(29, 234);
            label6.Name = "label6";
            label6.Size = new Size(107, 19);
            label6.TabIndex = 10;
            label6.Text = "Published Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(29, 170);
            label5.Name = "label5";
            label5.Size = new Size(110, 19);
            label5.TabIndex = 9;
            label5.Text = "Book Publicator";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(29, 109);
            label4.Name = "label4";
            label4.Size = new Size(88, 19);
            label4.TabIndex = 8;
            label4.Text = "Book Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(29, 46);
            label3.Name = "label3";
            label3.Size = new Size(83, 19);
            label3.TabIndex = 3;
            label3.Text = "Book Name";
            // 
            // button4
            // 
            button4.BackColor = Color.IndianRed;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Calibri", 12F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(34, 418);
            button4.Name = "button4";
            button4.Size = new Size(94, 34);
            button4.TabIndex = 7;
            button4.Text = "Upadate";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Calibri", 12F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(156, 418);
            button3.Name = "button3";
            button3.Size = new Size(94, 34);
            button3.TabIndex = 6;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Calibri", 12F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(274, 418);
            button2.Name = "button2";
            button2.Size = new Size(94, 34);
            button2.TabIndex = 3;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            // 
            // txtBQuantity
            // 
            txtBQuantity.Location = new Point(148, 351);
            txtBQuantity.Multiline = true;
            txtBQuantity.Name = "txtBQuantity";
            txtBQuantity.Size = new Size(219, 31);
            txtBQuantity.TabIndex = 5;
            // 
            // txtBPrice
            // 
            txtBPrice.Location = new Point(148, 290);
            txtBPrice.Multiline = true;
            txtBPrice.Name = "txtBPrice";
            txtBPrice.Size = new Size(219, 31);
            txtBPrice.TabIndex = 4;
            // 
            // txtBDate
            // 
            txtBDate.Location = new Point(148, 227);
            txtBDate.Multiline = true;
            txtBDate.Name = "txtBDate";
            txtBDate.Size = new Size(219, 31);
            txtBDate.TabIndex = 3;
            // 
            // txtBPublisher
            // 
            txtBPublisher.Location = new Point(148, 163);
            txtBPublisher.Multiline = true;
            txtBPublisher.Name = "txtBPublisher";
            txtBPublisher.Size = new Size(219, 31);
            txtBPublisher.TabIndex = 2;
            // 
            // txtBAuthor
            // 
            txtBAuthor.Location = new Point(148, 102);
            txtBAuthor.Multiline = true;
            txtBAuthor.Name = "txtBAuthor";
            txtBAuthor.Size = new Size(219, 31);
            txtBAuthor.TabIndex = 1;
            // 
            // txtBName
            // 
            txtBName.Location = new Point(148, 39);
            txtBName.Multiline = true;
            txtBName.Name = "txtBName";
            txtBName.Size = new Size(219, 31);
            txtBName.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightSalmon;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(763, 410);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSalmon;
            panel3.Controls.Add(label9);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(btnRefresh);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(0, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(763, 66);
            panel3.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(102, 26);
            label9.Name = "label9";
            label9.Size = new Size(83, 19);
            label9.TabIndex = 13;
            label9.Text = "Book Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(238, 18);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 35);
            textBox1.TabIndex = 2;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.IndianRed;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(559, 18);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(115, 35);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(45, 26);
            label2.Name = "label2";
            label2.Size = new Size(0, 19);
            label2.TabIndex = 0;
            // 
            // View_book_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 533);
            Controls.Add(panel3);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "View_book_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View_book_form";
            Load += View_book_form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel3;
        private TextBox txtBName;
        private TextBox textBox1;
        private Button btnRefresh;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button4;
        private Button button3;
        private Button button2;
        private TextBox txtBQuantity;
        private TextBox txtBPrice;
        private TextBox txtBDate;
        private TextBox txtBPublisher;
        private TextBox txtBAuthor;
        private Label label8;
        private Label label7;
        private Label label9;
    }
}