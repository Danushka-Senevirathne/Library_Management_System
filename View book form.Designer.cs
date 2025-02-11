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
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
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
            panel1.Size = new Size(877, 62);
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
            pictureBox1.Location = new Point(790, 0);
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
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(502, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(375, 473);
            panel2.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(22, 354);
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
            label7.Location = new Point(22, 293);
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
            label6.Location = new Point(22, 230);
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
            label5.Location = new Point(22, 166);
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
            label4.Location = new Point(22, 105);
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
            label3.Location = new Point(22, 42);
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
            button4.Location = new Point(22, 418);
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
            button3.Location = new Point(147, 418);
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
            button2.Location = new Point(270, 418);
            button2.Name = "button2";
            button2.Size = new Size(94, 34);
            button2.TabIndex = 3;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(180, 351);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(184, 31);
            textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(180, 290);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(184, 31);
            textBox6.TabIndex = 4;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(180, 227);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(184, 31);
            textBox7.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(180, 163);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(184, 31);
            textBox4.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(180, 102);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(184, 31);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(180, 39);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(184, 31);
            textBox2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightSalmon;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(505, 408);
            dataGridView1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSalmon;
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(btnRefresh);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(0, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(505, 66);
            panel3.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 18);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 35);
            textBox1.TabIndex = 2;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.IndianRed;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(354, 18);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(115, 35);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(45, 26);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 0;
            label2.Text = "Book Name";
            // 
            // View_book_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 533);
            Controls.Add(panel3);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "View_book_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View_book_form";
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
        private TextBox textBox2;
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
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label8;
        private Label label7;
    }
}