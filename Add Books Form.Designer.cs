namespace Library_Management_System
{
    partial class Add_Books_Form
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
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtName = new TextBox();
            txtAuthor = new TextBox();
            txtPublicator = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.books_quote2;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 441);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSalmon;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(247, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(506, 79);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 26);
            label1.Name = "label1";
            label1.Size = new Size(131, 33);
            label1.TabIndex = 4;
            label1.Text = "Add Books";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.book_gif_1;
            pictureBox2.Location = new Point(420, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(90, 79);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(324, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(431, 361);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(282, 110);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 2;
            label2.Text = "Book Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(282, 151);
            label3.Name = "label3";
            label3.Size = new Size(130, 19);
            label3.TabIndex = 3;
            label3.Text = "Book Auther Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(282, 242);
            label4.Name = "label4";
            label4.Size = new Size(139, 19);
            label4.TabIndex = 5;
            label4.Text = "Book Perchase Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(283, 195);
            label5.Name = "label5";
            label5.Size = new Size(110, 19);
            label5.TabIndex = 4;
            label5.Text = "Book Publicator";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(282, 336);
            label6.Name = "label6";
            label6.Size = new Size(101, 19);
            label6.TabIndex = 7;
            label6.Text = "Book Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(282, 292);
            label7.Name = "label7";
            label7.Size = new Size(77, 19);
            label7.TabIndex = 6;
            label7.Text = "Book Price";
            // 
            // txtName
            // 
            txtName.Location = new Point(437, 110);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(288, 23);
            txtName.TabIndex = 8;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(437, 151);
            txtAuthor.Multiline = true;
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(288, 23);
            txtAuthor.TabIndex = 9;
            txtAuthor.TextChanged += textBox2_TextChanged;
            // 
            // txtPublicator
            // 
            txtPublicator.Location = new Point(437, 195);
            txtPublicator.Multiline = true;
            txtPublicator.Name = "txtPublicator";
            txtPublicator.Size = new Size(288, 23);
            txtPublicator.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(437, 292);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(288, 23);
            txtPrice.TabIndex = 11;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(437, 336);
            txtQuantity.Multiline = true;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(288, 23);
            txtQuantity.TabIndex = 12;
            txtQuantity.TextChanged += textBox5_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(437, 242);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(288, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkSalmon;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(437, 379);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 36);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkSalmon;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(605, 379);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 36);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel\r\n";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // Add_Books_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(754, 441);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtPublicator);
            Controls.Add(txtAuthor);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Add_Books_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Books";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtName;
        private TextBox txtAuthor;
        private TextBox txtPublicator;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private DateTimePicker dateTimePicker1;
        private Button btnSave;
        private Button btnCancel;
    }
}