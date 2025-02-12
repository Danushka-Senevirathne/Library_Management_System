using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Book_Issue_Form_Load : Form
    {
        public Book_Issue_Form_Load()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void Book_Issue_Form_Load_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-NCOL2RG\\SQLEXPRESS;database =My2025;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();

            cmd = new SqlCommand("select bName from NewBook", conn);
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    comboBoxBooks.Items.Add(sdr.GetSqlString(i));
                }
            }
            sdr.Close();
            conn.Close();
        }
        int count;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtEnrollNumber.Text != "")
            {
                String eid = txtEnrollNumber.Text;
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=DESKTOP-NCOL2RG\\SQLEXPRESS;database =My2025;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select * from NewStudent where stdenroll ='" + eid + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                //--------------------------------------------------------------------
                //checking how many books issued for the entroll number
                cmd.CommandText = "select count(std_enroll) from IssueBooks where std_enroll ='" + eid + "' and book_return_date is null";
                SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                sda.Fill(ds1);

                count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());
                //--------------------------------------------------------------------

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtStdName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtDep.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtSem.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtCon.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtMail.Text = ds.Tables[0].Rows[0][6].ToString();

                }
                else
                {
                    txtStdName.Clear();
                    txtEnrollNumber.Clear();
                    txtDep.Clear();
                    txtSem.Clear();
                    txtCon.Clear();
                    txtMail.Clear();
                    MessageBox.Show("Invalid Enrollment Number. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtEnrollNumber_MouseHover(object sender, EventArgs e)
        {
            txtEnrollNumber.Clear();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (txtStdName.Text != "")
            {
                if (comboBoxBooks.SelectedIndex != -1 && count <= 2)
                {
                    String senroll = txtEnrollNumber.Text;
                    String sname = txtStdName.Text;
                    String sdep = txtDep.Text;
                    String ssem = txtSem.Text;
                    Int64 scon = Int64.Parse(txtCon.Text);
                    String smail = txtMail.Text;
                    String bookName = comboBoxBooks.Text;
                    String bookIssueDate = dateTimePicker.Text;

                    String eid = txtEnrollNumber.Text;
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "Data Source=DESKTOP-NCOL2RG\\SQLEXPRESS;database =My2025;Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.CommandText = "insert into IssueBooks (std_enroll,std_name,std_dep,std_sem,std_contact,std_email,book_name,book_issue_date) values ('" + senroll + "','" + sname + "','" + sdep + "','" + ssem + "'," + scon + ",'" + smail + "','" + bookName + "','" + bookIssueDate + "')";
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Book Issued", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Selected book of maximem number of Books Issued", "No Book Issued", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Empty fields are not allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtStdName.Clear();
            txtEnrollNumber.Clear();
            txtDep.Clear();
            txtSem.Clear();
            txtCon.Clear();
            txtMail.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Exit?","Warnung",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
